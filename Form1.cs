using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_3_1184064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbMouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsbMouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar mouse";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! anda memilih gambar salah";
            }
        }

        private void tsbMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar Monitor";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! anda memilih gambar salah";
            }
        }

        private void tsbPrinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar Printer";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! anda memilih gambar salah";
            }
        }

        private void tsbKeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar Printer";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! anda memilih gambar salah";
            }
        }

        private void tsbScanner_Click(object sender, EventArgs e)
        {
            if (rbScanner.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar Printer";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! anda memilih gambar salah";
            }
        }
    }
}
