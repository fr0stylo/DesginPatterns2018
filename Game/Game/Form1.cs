using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Game.Entities;
using Game.Graphics;
using Game.Input;

namespace Game {
    public partial class Form1 : Form {
        private bool shouldRender = true;
        private Entities.Game game;
        public GraphicsHandler render;
        private GameStateSingleton gameState = GameStateSingleton.getInstance();

        public Form1() {
            Application.Idle += HandleApplicationIdle;
            InitializeComponent();
            BackColor = Color.Black;
            game = new Entities.Game(Width, Height);
            render = new GraphicsHandler(CreateGraphics(), Color.Black);


            PlayerName.Text = gameState.Players[0].Name;
            PlayerName.BackColor = Color.Transparent;
            PlayerName.ForeColor = Color.Azure;
            timer1.Enabled = true;
            timer1.Interval = 1000/100;
        }

        void HandleApplicationIdle(object sender, EventArgs e) {
            while (IsApplicationIdle()) {
                Update();
                if (!shouldRender) continue;
                Render();
                shouldRender = false;
            }
        }

        new void Update() {
            Console.WriteLine("Update");
            game.Update();
            // ...
        }

        void Render() {
            Console.WriteLine("Render");
            render.Render(game);

            shouldRender = false;
        }

        bool IsApplicationIdle() {
            NativeMessage result;
            return PeekMessage(out result, IntPtr.Zero, (uint) 0, (uint) 0, (uint) 0) == 0;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NativeMessage {
            public IntPtr Handle;
            public uint Message;
            public IntPtr WParameter;
            public IntPtr LParameter;
            public uint Time;
            public Point Location;
        }

        [DllImport("user32.dll")]
        public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax,
            uint remove);

        private void timer1_Tick(object sender, EventArgs e) {
            shouldRender = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            var inputs = MouseInput.GetInstance();
            inputs.HandleClick(e.Location);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            var inputs = MouseInput.GetInstance();
            inputs.HandleDragStart(new Point(e.X, e.Y));
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            var inputs = MouseInput.GetInstance();
            inputs.HandleDragEnd(new Point(e.X, e.Y));
        }
    }
}