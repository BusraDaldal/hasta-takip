namespace WindowsFormsApp1
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
            this.cmbAdi = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.Label();
            this.cmbDogumYili = new System.Windows.Forms.Label();
            this.cmbUcret = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoğumYılı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ücret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İndirimliÜcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yaş = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.dateDogumTar = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAdi
            // 
            this.cmbAdi.AutoSize = true;
            this.cmbAdi.Location = new System.Drawing.Point(13, 13);
            this.cmbAdi.Name = "cmbAdi";
            this.cmbAdi.Size = new System.Drawing.Size(22, 13);
            this.cmbAdi.TabIndex = 0;
            this.cmbAdi.Text = "Adı";
            this.cmbAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.AutoSize = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(221, 13);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(45, 13);
            this.cmbCinsiyet.TabIndex = 1;
            this.cmbCinsiyet.Text = "Cinsiyeti";
            // 
            // cmbDogumYili
            // 
            this.cmbDogumYili.AutoSize = true;
            this.cmbDogumYili.Location = new System.Drawing.Point(13, 67);
            this.cmbDogumYili.Name = "cmbDogumYili";
            this.cmbDogumYili.Size = new System.Drawing.Size(57, 13);
            this.cmbDogumYili.TabIndex = 2;
            this.cmbDogumYili.Text = "Doğum Yılı";
            // 
            // cmbUcret
            // 
            this.cmbUcret.AutoSize = true;
            this.cmbUcret.Location = new System.Drawing.Point(223, 63);
            this.cmbUcret.Name = "cmbUcret";
            this.cmbUcret.Size = new System.Drawing.Size(33, 13);
            this.cmbUcret.TabIndex = 3;
            this.cmbUcret.Text = "Ücret";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(76, 12);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 4;
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(272, 10);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.txtCinsiyet.TabIndex = 5;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(272, 56);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adı,
            this.Cinsiyeti,
            this.DoğumYılı,
            this.Ücret,
            this.İndirimliÜcret,
            this.Yaş});
            this.dataGridView1.Location = new System.Drawing.Point(1, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Adı
            // 
            this.Adı.HeaderText = "Adı";
            this.Adı.Name = "Adı";
            // 
            // Cinsiyeti
            // 
            this.Cinsiyeti.HeaderText = "Cinsiyeti";
            this.Cinsiyeti.Name = "Cinsiyeti";
            // 
            // DoğumYılı
            // 
            this.DoğumYılı.HeaderText = "DoğumYılı";
            this.DoğumYılı.Name = "DoğumYılı";
            // 
            // Ücret
            // 
            this.Ücret.HeaderText = "Ücret";
            this.Ücret.Name = "Ücret";
            // 
            // İndirimliÜcret
            // 
            this.İndirimliÜcret.HeaderText = "İndirimliÜcret";
            this.İndirimliÜcret.Name = "İndirimliÜcret";
            // 
            // Yaş
            // 
            this.Yaş.HeaderText = "Yaş";
            this.Yaş.Name = "Yaş";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(446, 12);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.Location = new System.Drawing.Point(446, 49);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnHastaEkle.TabIndex = 10;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = true;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // dateDogumTar
            // 
            this.dateDogumTar.Location = new System.Drawing.Point(76, 61);
            this.dateDogumTar.Name = "dateDogumTar";
            this.dateDogumTar.Size = new System.Drawing.Size(141, 20);
            this.dateDogumTar.TabIndex = 11;
            this.dateDogumTar.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 261);
            this.Controls.Add(this.dateDogumTar);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.cmbUcret);
            this.Controls.Add(this.cmbDogumYili);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.cmbAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmbAdi;
        private System.Windows.Forms.Label cmbCinsiyet;
        private System.Windows.Forms.Label cmbDogumYili;
        private System.Windows.Forms.Label cmbUcret;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoğumYılı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ücret;
        private System.Windows.Forms.DataGridViewTextBoxColumn İndirimliÜcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yaş;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.DateTimePicker dateDogumTar;
    }
}

