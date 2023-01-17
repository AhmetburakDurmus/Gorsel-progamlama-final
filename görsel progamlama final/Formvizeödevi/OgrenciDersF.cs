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
    public partial class OgrenciDersF : Form
    {
        public OgrenciDersF()
        {
            InitializeComponent();
        }
        FVDataEntities db = new FVDataEntities();

        private void OgrenciDers_Load(object sender, EventArgs e)
        {
            cmbDersAd.DisplayMember = "DersAd";
            cmbDersAd.ValueMember = "Id";

            cmbOgrId.DisplayMember = "OgrenciAdSoyad";
            cmbOgrId.ValueMember = "Id";

            cmbDersAd.DataSource = db.Ders.ToList();
            cmbOgrId.DataSource = db.Ogrenci.ToList();
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
        private void yonetimToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            YonetimF fr = new YonetimF();
            fr.Show();
            this.Hide();
        }

        private void OgrenciDersF_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("progamı kapatmak istiyormusunuz", "Cıkıs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textId.Text);
            var ogrdrs = db.OgrenciDers.Find(x);

            ogrdrs.DersId = int.Parse(cmbDersAd.SelectedValue.ToString());
            ogrdrs.OgrenciId = int.Parse(cmbOgrId.SelectedValue.ToString());

            db.SaveChanges();
            MessageBox.Show("Öğrencinin Dersi Güncellendi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.OgrenciDers
                                        select new
                                        {
                                            x.Id,
                                            x.Ogrenci.OgrenciAdSoyad,
                                            x.Ders.DersAd


                                        }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciDers ogrdrs = new OgrenciDers
            {
                DersId = int.Parse(cmbDersAd.SelectedValue.ToString()),
                OgrenciId = int.Parse(cmbOgrId.SelectedValue.ToString())
            };
            db.OgrenciDers.Add(ogrdrs);

            db.SaveChanges();
            MessageBox.Show("Öğrenciye Ders Eklendi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textId.Text);
            var ogrdrs = db.OgrenciDers.Find(x);

            db.OgrenciDers.Remove(ogrdrs);
            db.SaveChanges();

            MessageBox.Show("Yönetici Silindi");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string aranan = textAra.Text;
            var degerler = from item in db.Ogrenci
                           where item.OgrenciAdSoyad.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            textId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            cmbOgrId.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            cmbDersAd.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
        }

        private void cmbDersAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
