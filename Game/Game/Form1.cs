using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Game.Entities;
using Game.Graphics;
using Game.Input;
using Game.FactoryPattern;
using System.Collections.Generic;

namespace Game {
    public partial class Form1 : Form {
        private bool shouldRender = true;
        private Entities.Game game;
        public GraphicsHandler render;
        private string time = "00:00";
        private int ticks = 0;
        private GameStateSingleton gameState = GameStateSingleton.getInstance();

        public Form1() {
            Application.Idle += HandleApplicationIdle;
            InitializeComponent();
            BackColor = Color.Black;
            game = new Entities.Game(Width, Height);
            render = new GraphicsHandler(CreateGraphics(), Color.Black);


            PlayerName.Text = gameState.GetCurrentPlayer().Name;
            PlayerName.BackColor = Color.Transparent;
            PlayerName.ForeColor = Color.Azure;
            timer1.Enabled = true;
            timer1.Interval = 1000/100;
            GameTimer.Enabled = true;
            GameTimer.Interval = 1;
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

        private void StrongBaloon_Click(object sender, EventArgs e)
        {
            var baloons = BaloonFactory.GetInstance();
            baloons.CreateBaloon("PowerfulBaloon");
            
        }

        private void IntermediateBaloon_Click(object sender, EventArgs e)
        {
            var baloons = BaloonFactory.GetInstance();
            baloons.CreateBaloon("IntermediateBaloon");
        }

        private void WeakBaloon_Click(object sender, EventArgs e)
        {
            var baloons = BaloonFactory.GetInstance();
            baloons.CreateBaloon("WeakBaloon");
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (ticks % 10 == 0)
            {
                int seconds = Convert.ToInt32(time.Substring(3, 2));
                int minutes = Convert.ToInt32(time.Substring(0, 2));
                seconds += 1;
                if (seconds == 60)
                {
                    minutes += 1;
                    seconds = 0;
                }
                time = minutes < 10 ? 0.ToString() + minutes.ToString() : minutes.ToString();
                time += ":";
                time += seconds < 10 ? 0.ToString() + seconds.ToString() : seconds.ToString();
                TimeLabel.Text = time;
            }
            ticks++;
        }
    }
}