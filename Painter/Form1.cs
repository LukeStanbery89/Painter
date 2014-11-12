using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Painter {
    public partial class Form1 : Form {
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        bool k = false;

        public Form1() {
            InitializeComponent();
        }

        private void red_Click(object sender, EventArgs e) {
            p.Color = red.BackColor;
            default1.BackColor = red.BackColor;
        }

        private void black_Click(object sender, EventArgs e) {
            p.Color = black.BackColor;
            default1.BackColor = black.BackColor;
        }

        private void green_Click(object sender, EventArgs e) {
            p.Color = green.BackColor;
            default1.BackColor = green.BackColor;
        }

        private void blue_Click(object sender, EventArgs e) {
            p.Color = blue.BackColor;
            default1.BackColor = blue.BackColor;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e) {
            sp = e.Location;
            if (e.Button == MouseButtons.Left) {
                k = true;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e) {
            k = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e) {
            if (k) {
                ep = e.Location;
                g = canvas.CreateGraphics();
                g.DrawLine(p, sp, ep);
            }
            sp = ep;
        }

        private void orange_Click(object sender, EventArgs e) {
            p.Color = orange.BackColor;
            default1.BackColor = orange.BackColor;
        }

        private void yellow_Click(object sender, EventArgs e) {
            p.Color = yellow.BackColor;
            default1.BackColor = yellow.BackColor;
        }

        private void indigo_Click(object sender, EventArgs e) {
            p.Color = indigo.BackColor;
            default1.BackColor = indigo.BackColor;
        }

        private void violet_Click(object sender, EventArgs e) {
            p.Color = violet.BackColor;
            default1.BackColor = violet.BackColor;
        }

        private void white_Click(object sender, EventArgs e) {
            p.Color = white.BackColor;
            default1.BackColor = white.BackColor;
        }

        private void brushThickness_SelectedIndexChanged(object sender, EventArgs e) {
            p.Width = float.Parse(brushThickness.Text);
        }

        private void clearCanvas_Click(object sender, EventArgs e) {
            canvas.Refresh();
        }

        private void brown_Click(object sender, EventArgs e) {
            p.Color = brown.BackColor;
            default1.BackColor = brown.BackColor;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Drawing.Bitmap bm = new Bitmap(this.canvas.Width, this.canvas.Height);
            canvas.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.canvas.Width, this.canvas.Height));
            bm.Save("C:\\Users\\LukeS\\Documents\\test_image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}