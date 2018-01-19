using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            DateTime DogumTarihi = dateDogumTar.Value;

          
            Hasta hasta = new Hasta
            {
                Adi = txtAdi.Text,
                Ucret = Convert.ToInt32(txtUcret.Text),
                DogumYili = DogumTarihi.Year,
                Cinsiyet = cmbCinsiyet.Text,
            };

            hasta.YasHesapla();
            hasta.IndirimliUcretHesapla();

            dataGridView1.Rows.Add(hasta.Adi, hasta.DogumYili, hasta.Cinsiyet, hasta.Ucret, hasta.yas, hasta.IndirimliUcret);





        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
