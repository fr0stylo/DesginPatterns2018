using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Graphics;
using Game.Properties;

namespace Game {
    public partial class Form1 : Form {
        private bool shouldRender = true;
        private Random Generator = new Random();
        private List<PointF[]> points = new List<PointF[]>();
        public GraphicsHandler render;
        public Form1() {
            Application.Idle += HandleApplicationIdle;
            InitializeComponent();
            BackColor = Color.Black;

            render = new GraphicsHandler(CreateGraphics());

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

        void Update() {
            Console.WriteLine("Update");
            points.Add(new[] { new PointF(Generator.Next(Width), Generator.Next(Height)), new PointF(Generator.Next(Width), Generator.Next(Height)) });
            // ...
        }

        void Render() {
//            graphics.DrawImage(Resources.JE87HUq, new Point(0,0));
            Console.WriteLine("Render");
            render.Render();
//            if (Generator.Next(Height)%Width > Width/2) {
//                graphics.Clear(BackColor);
//            }
//            foreach (var p in points) {
//                var color = Color.FromArgb(Generator.Next(255), Generator.Next(255), Generator.Next(255), Generator.Next(255));
//                graphics.DrawLine(new Pen(color), p[0], p[1]);
//            }

//            points.Clear();
            shouldRender = false;
            // ...
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
    }
}