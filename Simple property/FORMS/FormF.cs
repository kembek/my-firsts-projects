using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PropertyApp.FORMS
{
    public partial class FormF : Form
    {
        public FormF()
        {
            InitializeComponent();
        }

        Point last;

        void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;

            }

        }

        void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLclassInsert.RefreshO(this.dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLclassUpdateR.RefreshOR(this.dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLclassInsert.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
