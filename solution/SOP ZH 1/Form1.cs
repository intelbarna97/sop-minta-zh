using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SOP_ZH_1
{
    public partial class Form1 : Form
    {
        private static Graphics g;

        private static int degrees = 0;

        public Form1()
        {
            InitializeComponent();

            g = pictureBox1.CreateGraphics();
        }

        private void Draw(int addDegree)
        {
            double rad = (Math.PI / 180) * degrees;
            g.DrawRectangle(new Pen(pictureBox1.BackColor), 200 + (float)Math.Cos(rad) * 100, 200 + (float)Math.Sin(rad) * 100, 20, 20);
            degrees += addDegree;
            rad = (Math.PI / 180) * degrees;
            g.DrawRectangle(Pens.Blue, 200 + (float)Math.Cos(rad) * 100, 200 + (float)Math.Sin(rad) * 100, 20, 20);
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            // Kérd le a trackBar1 értékét (d)!

            // Indíts egy szálon egy 100x lefutó ciklust, mely meghívja a Draw(d) metódust. (Minden egyes ciklusvégrehajtás után 100ms-ig késleltesd a szálat.)

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
