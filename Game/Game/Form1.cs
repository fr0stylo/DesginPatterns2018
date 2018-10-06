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

namespace Game {
    public partial class Form1 : Form {
        private Graphics graphics;
        private int updateCounter = 0;

        public Form1()
        {
            Application.Idle += HandleApplicationIdle;
            this.graphics = CreateGraphics();
        }

        void HandleApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle())
            {
                Update();
                Render();
            }
        }

        void Update() {
            Console.WriteLine("Update");
            updateCounter += 1;
            // ...
        }

        void Render()
        {
            Console.WriteLine("Render");
            graphics.DrawLine(Pens.Black, 1, 1, updateCounter%Width, updateCounter%Height);
            // ...
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
        public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax, uint remove);
    }
}