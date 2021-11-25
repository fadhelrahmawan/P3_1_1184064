using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1184064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tampilkan_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (Senin.Checked)
            {
                jadwal = "Senin, 09.00 - 10.00";
            }
            else if (Selasa.Checked)
            {
                jadwal = "Selasa, 09.00 - 10.00";
            }
            else if (Rabu.Checked)
            {
                jadwal = "Rabu, 09.00 - 10.00";
            }
            else if (Kamis.Checked)
            {
                jadwal = "Kamis, 09.00 - 10.00";
            }
            else if (Jumat.Checked)
            {
                jadwal = "Jumat, 09.00 - 10.00";
            }
            else if (Sabtu.Checked)
            {
                jadwal = "Sabtu, 09.00 - 10.00";
            }
            if (Biola.Checked)
            {
                kelas = kelas + "Biola";
            }
            if (Gitar.Checked)
            {
                kelas = kelas + "Gitar";
            }
            if (Piano.Checked)
            {
                kelas = kelas + "Piano";
            }
            if (Biola.Checked)
            {
                kelas = kelas + "Biola";
            }
            if (Drum.Checked)
            {
                kelas = kelas + "Drum";
            }
            if (Vokal.Checked)
            {
                kelas = kelas + "Vokal";
            }
            if (DJ.Checked)
            {
                kelas = kelas + "DJ";
                   
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari kelas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show
                ("Nama : " + BOXNAMA.Text +
                "\nJenisKelamin : " + Pilihkelamin.Text +
                "\nTanggal Lahir : " + TGLL.Text +
                "\n PILIHAN KELAS : " + kelas +
                "\n PILIHAN JADWAL : " + jadwal, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        

    }


        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void Senin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Selesai_Click(object sender, EventArgs e)
        {

        }
    }
}
