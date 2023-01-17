using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formvizeödevi
{
    public partial class OgrenciF : Form
    {
        DataTable Tablo = new DataTable();
        public OgrenciF()
        {
            
            InitializeComponent();
        }
        FVDataEntities db = new FVDataEntities();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.OgrenciAdSoyad = textAdSoyad.Text;
            ogr.KayitTarih = kytTarih.Value;
            ogr.OgrenciNo = mskOgrNo.Text;
            ogr.DTarih = DTarih.Value;
            ogr.Bolum = textBolum.Text;
            db.Ogrenci.Add(ogr);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi");
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        
        private void textOgrenciNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenüF fr = new MenüF();
            fr.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciF fr = new OgrenciF();
            fr.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DersF fr = new DersF();
            fr.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OgrenciDersF fr = new OgrenciDersF();
            fr.Show();
            this.Hide();
        }

        private void yonetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YonetimF fr = new YonetimF();
            fr.Show();
            this.Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            YonetimF fr = new YonetimF();
            fr.Show();
            this.Hide();
        }

        private void OgrenciF_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("progamı kapatmak istiyormusunuz", "Cıkıs", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            { 
                e.Cancel = true; 
            }
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Ogrenci
                                          select new
                                          {
                                              x.Id,
                                              x.OgrenciAdSoyad,
                                              x.KayitTarih,
                                              x.OgrenciNo,
                                              x.DTarih,
                                              x.Bolum

                                          }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textId.Text);
            var ogr = db.Ogrenci.Find(x);
            ogr.OgrenciAdSoyad = textAdSoyad.Text;
            ogr.KayitTarih = kytTarih.Value;
            ogr.OgrenciNo = mskOgrNo.Text;
            ogr.DTarih = DTarih.Value;
            ogr.Bolum = textBolum.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textId.Text);
            var ogr = db.Ogrenci.Find(x);
            db.Ogrenci.Remove(ogr);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Silindi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            textId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textAdSoyad.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            kytTarih.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            mskOgrNo.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            DTarih.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            textBolum.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = textAra.Text;
            var degerler = from item in db.Ogrenci
                           where item.OgrenciAdSoyad.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }
    }
}
