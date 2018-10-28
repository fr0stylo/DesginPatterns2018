using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Game.Entities;
using Game.Graphics;
using Game.Input;
using Game.FactoryPattern;
using System.Collections.Generic;
using Game.Facade;
using Game.Helpers.Enums;

namespace Game
{
    public partial class Form1 : Form
    {
        private bool shouldRender = true;
        private IGameFacade game;
        private GraphicsHandler render;
        private string time = "00:00";
        private int ticks = 0;
        private readonly GameStateSingleton _gameState = GameStateSingleton.GetInstance();
        private bool _inConstructionMode = false;
        private TowerTypes _currentTowerType;
        private BaloonFactory Player1BaloonFactory;
        private BaloonFactory Player2BaloonFactory;

        public Form1()
        {
            Application.Idle += HandleApplicationIdle;
            InitializeComponent();
            BackColor = Color.Black;
            game = new Entities.Game(Width, Height);
            render = new GraphicsHandler(CreateGraphics(), Color.Black, this.Width, this.Height);


            PlayerName.Text = _gameState.GetCurrentPlayer().Name;
            PlayerName.BackColor = Color.Transparent;
            PlayerName.ForeColor = Color.White;
            timer1.Enabled = true;
            timer1.Interval = 1000 / 60;
            GameTimer.Enabled = true;
            GameTimer.Interval = 1000;
            Player1BaloonFactory = new BaloonFactory(true);
            Player2BaloonFactory = new BaloonFactory(false);
        }

        void HandleApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle())
            {
                Update();
                if (!shouldRender) continue;
                Render();
                shouldRender = false;
            }
        }

        new void Update()
        {
            game.Update();
        }

        void Render()
        {
            render.Render(game);

            shouldRender = false;
        }

        bool IsApplicationIdle()
        {
            NativeMessage result;
            return PeekMessage(out result, IntPtr.Zero, (uint)0, (uint)0, (uint)0) == 0;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NativeMessage
        {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            shouldRender = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_inConstructionMode)
            {
                var inputs = MouseInput.GetInstance();
                inputs.HandleClick(e.Location, _currentTowerType);

                Cursor = Cursors.Arrow;
                _inConstructionMode = false;
            }
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
            IBaloon baloon = Player1BaloonFactory.CreateBaloon(BaloonTypes.Powerful);
            _gameState.AddPlayer1Baloon(baloon);
        }

        private void IntermediateBaloon_Click(object sender, EventArgs e)
        {
            IBaloon baloon = Player1BaloonFactory.CreateBaloon(BaloonTypes.Intermediate);
            _gameState.AddPlayer1Baloon(baloon);
        }

        private void WeakBaloon_Click(object sender, EventArgs e)
        {
            IBaloon baloon = Player1BaloonFactory.CreateBaloon(BaloonTypes.Weak);
            _gameState.AddPlayer1Baloon(baloon);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            int seconds = Convert.ToInt32(time.Substring(3, 2));
            int minutes = Convert.ToInt32(time.Substring(0, 2));
            seconds += 1;

            if (seconds == 60)
            {
                minutes += 1;
                seconds = 0;
            }

            time = minutes < 10 ? 0 + minutes.ToString() : minutes.ToString();
            time += ":";
            time += seconds < 10 ? 0 + seconds.ToString() : seconds.ToString();
            TimeLabel.Text = time;
        }

        private void ArrowTower_Click(object sender, EventArgs e)
        {
            //            Cursor = new Cursor(new Bitmap(Tower.TowerBitmap).GetHicon());
            _inConstructionMode = true;
            _currentTowerType = TowerTypes.Arrow;
        }
    }
}