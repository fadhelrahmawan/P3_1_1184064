namespace P3_4_1184064
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nama = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.tgl = new System.Windows.Forms.Label();
            this.BOXNAMA = new System.Windows.Forms.TextBox();
            this.Pilihkelamin = new System.Windows.Forms.ComboBox();
            this.TGLL = new System.Windows.Forms.DateTimePicker();
            this.kelas = new System.Windows.Forms.GroupBox();
            this.Biola = new System.Windows.Forms.CheckBox();
            this.Gitar = new System.Windows.Forms.CheckBox();
            this.DJ = new System.Windows.Forms.CheckBox();
            this.Piano = new System.Windows.Forms.CheckBox();
            this.Vokal = new System.Windows.Forms.CheckBox();
            this.Drum = new System.Windows.Forms.CheckBox();
            this.PILIHJADWAL = new System.Windows.Forms.GroupBox();
            this.Senin = new System.Windows.Forms.RadioButton();
            this.Selasa = new System.Windows.Forms.RadioButton();
            this.Sabtu = new System.Windows.Forms.RadioButton();
            this.Rabu = new System.Windows.Forms.RadioButton();
            this.Jumat = new System.Windows.Forms.RadioButton();
            this.Kamis = new System.Windows.Forms.RadioButton();
            this.Tampilkan = new System.Windows.Forms.Button();
            this.Selesai = new System.Windows.Forms.Button();
            this.FromPendaftaran = new System.Windows.Forms.Label();
            this.kelas.SuspendLayout();
            this.PILIHJADWAL.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(302, 62);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(35, 13);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Location = new System.Drawing.Point(302, 91);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(71, 13);
            this.JenisKelamin.TabIndex = 1;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // tgl
            // 
            this.tgl.AutoSize = true;
            this.tgl.Location = new System.Drawing.Point(302, 121);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(72, 13);
            this.tgl.TabIndex = 2;
            this.tgl.Text = "Tanggal Lahir";
            // 
            // BOXNAMA
            // 
            this.BOXNAMA.Location = new System.Drawing.Point(393, 62);
            this.BOXNAMA.Name = "BOXNAMA";
            this.BOXNAMA.Size = new System.Drawing.Size(200, 20);
            this.BOXNAMA.TabIndex = 3;
            // 
            // Pilihkelamin
            // 
            this.Pilihkelamin.FormattingEnabled = true;
            this.Pilihkelamin.Items.AddRange(new object[] {
            "LAKI LAKI",
            "PEREMPUAN"});
            this.Pilihkelamin.Location = new System.Drawing.Point(393, 88);
            this.Pilihkelamin.Name = "Pilihkelamin";
            this.Pilihkelamin.Size = new System.Drawing.Size(200, 21);
            this.Pilihkelamin.TabIndex = 4;
            this.Pilihkelamin.Text = "Jenis Kelamin";
            // 
            // TGLL
            // 
            this.TGLL.Location = new System.Drawing.Point(393, 115);
            this.TGLL.Name = "TGLL";
            this.TGLL.Size = new System.Drawing.Size(200, 20);
            this.TGLL.TabIndex = 5;
            // 
            // kelas
            // 
            this.kelas.Controls.Add(this.Biola);
            this.kelas.Controls.Add(this.Gitar);
            this.kelas.Controls.Add(this.DJ);
            this.kelas.Controls.Add(this.Piano);
            this.kelas.Controls.Add(this.Vokal);
            this.kelas.Controls.Add(this.Drum);
            this.kelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelas.Location = new System.Drawing.Point(92, 185);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(224, 121);
            this.kelas.TabIndex = 6;
            this.kelas.TabStop = false;
            this.kelas.Text = "PILIHAN KELAS";
            // 
            // Biola
            // 
            this.Biola.AutoSize = true;
            this.Biola.Location = new System.Drawing.Point(6, 24);
            this.Biola.Name = "Biola";
            this.Biola.Size = new System.Drawing.Size(62, 20);
            this.Biola.TabIndex = 14;
            this.Biola.Tag = "";
            this.Biola.Text = "Biola";
            this.Biola.UseVisualStyleBackColor = true;
            // 
            // Gitar
            // 
            this.Gitar.AutoSize = true;
            this.Gitar.Location = new System.Drawing.Point(6, 47);
            this.Gitar.Name = "Gitar";
            this.Gitar.Size = new System.Drawing.Size(59, 20);
            this.Gitar.TabIndex = 15;
            this.Gitar.Text = "Gitar";
            this.Gitar.UseVisualStyleBackColor = true;
            // 
            // DJ
            // 
            this.DJ.AutoSize = true;
            this.DJ.Location = new System.Drawing.Point(134, 70);
            this.DJ.Name = "DJ";
            this.DJ.Size = new System.Drawing.Size(45, 20);
            this.DJ.TabIndex = 19;
            this.DJ.Text = "DJ";
            this.DJ.UseVisualStyleBackColor = true;
            // 
            // Piano
            // 
            this.Piano.AutoSize = true;
            this.Piano.Location = new System.Drawing.Point(6, 70);
            this.Piano.Name = "Piano";
            this.Piano.Size = new System.Drawing.Size(66, 20);
            this.Piano.TabIndex = 16;
            this.Piano.Text = "Piano";
            this.Piano.UseVisualStyleBackColor = true;
            // 
            // Vokal
            // 
            this.Vokal.AutoSize = true;
            this.Vokal.Location = new System.Drawing.Point(134, 47);
            this.Vokal.Name = "Vokal";
            this.Vokal.Size = new System.Drawing.Size(66, 20);
            this.Vokal.TabIndex = 18;
            this.Vokal.Text = "Vokal";
            this.Vokal.UseVisualStyleBackColor = true;
            // 
            // Drum
            // 
            this.Drum.AutoSize = true;
            this.Drum.Location = new System.Drawing.Point(134, 24);
            this.Drum.Name = "Drum";
            this.Drum.Size = new System.Drawing.Size(62, 20);
            this.Drum.TabIndex = 17;
            this.Drum.Text = "Drum";
            this.Drum.UseVisualStyleBackColor = true;
            // 
            // PILIHJADWAL
            // 
            this.PILIHJADWAL.Controls.Add(this.Senin);
            this.PILIHJADWAL.Controls.Add(this.Selasa);
            this.PILIHJADWAL.Controls.Add(this.Sabtu);
            this.PILIHJADWAL.Controls.Add(this.Rabu);
            this.PILIHJADWAL.Controls.Add(this.Jumat);
            this.PILIHJADWAL.Controls.Add(this.Kamis);
            this.PILIHJADWAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PILIHJADWAL.Location = new System.Drawing.Point(540, 185);
            this.PILIHJADWAL.Name = "PILIHJADWAL";
            this.PILIHJADWAL.Size = new System.Drawing.Size(208, 121);
            this.PILIHJADWAL.TabIndex = 7;
            this.PILIHJADWAL.TabStop = false;
            this.PILIHJADWAL.Text = "PILIHAN JADWAL";
            this.PILIHJADWAL.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Senin
            // 
            this.Senin.AutoSize = true;
            this.Senin.Location = new System.Drawing.Point(0, 24);
            this.Senin.Name = "Senin";
            this.Senin.Size = new System.Drawing.Size(64, 20);
            this.Senin.TabIndex = 8;
            this.Senin.TabStop = true;
            this.Senin.Text = "Senin";
            this.Senin.UseVisualStyleBackColor = true;
            this.Senin.CheckedChanged += new System.EventHandler(this.Senin_CheckedChanged);
            // 
            // Selasa
            // 
            this.Selasa.AutoSize = true;
            this.Selasa.Location = new System.Drawing.Point(0, 47);
            this.Selasa.Name = "Selasa";
            this.Selasa.Size = new System.Drawing.Size(74, 20);
            this.Selasa.TabIndex = 9;
            this.Selasa.TabStop = true;
            this.Selasa.Text = "Selasa";
            this.Selasa.UseVisualStyleBackColor = true;
            // 
            // Sabtu
            // 
            this.Sabtu.AutoSize = true;
            this.Sabtu.Location = new System.Drawing.Point(103, 69);
            this.Sabtu.Name = "Sabtu";
            this.Sabtu.Size = new System.Drawing.Size(65, 20);
            this.Sabtu.TabIndex = 13;
            this.Sabtu.TabStop = true;
            this.Sabtu.Text = "Sabtu";
            this.Sabtu.UseVisualStyleBackColor = true;
            // 
            // Rabu
            // 
            this.Rabu.AutoSize = true;
            this.Rabu.Location = new System.Drawing.Point(0, 70);
            this.Rabu.Name = "Rabu";
            this.Rabu.Size = new System.Drawing.Size(62, 20);
            this.Rabu.TabIndex = 11;
            this.Rabu.TabStop = true;
            this.Rabu.Text = "Rabu";
            this.Rabu.UseVisualStyleBackColor = true;
            // 
            // Jumat
            // 
            this.Jumat.AutoSize = true;
            this.Jumat.Location = new System.Drawing.Point(103, 47);
            this.Jumat.Name = "Jumat";
            this.Jumat.Size = new System.Drawing.Size(66, 20);
            this.Jumat.TabIndex = 12;
            this.Jumat.TabStop = true;
            this.Jumat.Text = "Jumat";
            this.Jumat.UseVisualStyleBackColor = true;
            // 
            // Kamis
            // 
            this.Kamis.AutoSize = true;
            this.Kamis.Location = new System.Drawing.Point(103, 24);
            this.Kamis.Name = "Kamis";
            this.Kamis.Size = new System.Drawing.Size(67, 20);
            this.Kamis.TabIndex = 10;
            this.Kamis.TabStop = true;
            this.Kamis.Text = "Kamis";
            this.Kamis.UseVisualStyleBackColor = true;
            // 
            // Tampilkan
            // 
            this.Tampilkan.Location = new System.Drawing.Point(299, 401);
            this.Tampilkan.Name = "Tampilkan";
            this.Tampilkan.Size = new System.Drawing.Size(75, 23);
            this.Tampilkan.TabIndex = 20;
            this.Tampilkan.Text = "&Tampilkan";
            this.Tampilkan.UseVisualStyleBackColor = true;
            this.Tampilkan.Click += new System.EventHandler(this.Tampilkan_Click);
            // 
            // Selesai
            // 
            this.Selesai.Location = new System.Drawing.Point(418, 401);
            this.Selesai.Name = "Selesai";
            this.Selesai.Size = new System.Drawing.Size(75, 23);
            this.Selesai.TabIndex = 21;
            this.Selesai.Text = "&Selesai";
            this.Selesai.UseVisualStyleBackColor = true;
            this.Selesai.Click += new System.EventHandler(this.Selesai_Click);
            // 
            // FromPendaftaran
            // 
            this.FromPendaftaran.AutoSize = true;
            this.FromPendaftaran.Location = new System.Drawing.Point(355, 9);
            this.FromPendaftaran.Name = "FromPendaftaran";
            this.FromPendaftaran.Size = new System.Drawing.Size(91, 13);
            this.FromPendaftaran.TabIndex = 22;
            this.FromPendaftaran.Text = "From Pendaftaran";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FromPendaftaran);
            this.Controls.Add(this.Selesai);
            this.Controls.Add(this.Tampilkan);
            this.Controls.Add(this.PILIHJADWAL);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.TGLL);
            this.Controls.Add(this.Pilihkelamin);
            this.Controls.Add(this.BOXNAMA);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Nama);
            this.Name = "Form1";
            this.Text = "Musik Dj ";
            this.kelas.ResumeLayout(false);
            this.kelas.PerformLayout();
            this.PILIHJADWAL.ResumeLayout(false);
            this.PILIHJADWAL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label tgl;
        private System.Windows.Forms.TextBox BOXNAMA;
        private System.Windows.Forms.ComboBox Pilihkelamin;
        private System.Windows.Forms.DateTimePicker TGLL;
        private System.Windows.Forms.GroupBox kelas;
        private System.Windows.Forms.GroupBox PILIHJADWAL;
        private System.Windows.Forms.RadioButton Senin;
        private System.Windows.Forms.RadioButton Selasa;
        private System.Windows.Forms.RadioButton Kamis;
        private System.Windows.Forms.RadioButton Rabu;
        private System.Windows.Forms.RadioButton Jumat;
        private System.Windows.Forms.RadioButton Sabtu;
        private System.Windows.Forms.CheckBox Biola;
        private System.Windows.Forms.CheckBox Gitar;
        private System.Windows.Forms.CheckBox Piano;
        private System.Windows.Forms.CheckBox Drum;
        private System.Windows.Forms.CheckBox Vokal;
        private System.Windows.Forms.CheckBox DJ;
        private System.Windows.Forms.Button Tampilkan;
        private System.Windows.Forms.Button Selesai;
        private System.Windows.Forms.Label FromPendaftaran;
    }
}

