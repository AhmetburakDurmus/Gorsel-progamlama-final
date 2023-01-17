using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formvizeödevi
{
    public partial class DersF : Form
    {
        public DersF()
        {
            InitializeComponent();
        }
        FVDataEntities db = new FVDataEntities();


        private void DersF_Load(object sender, EventArgs e)
        {
            OYtcomboBox.DisplayMember = "YonetimAdSoyad";
            OYtcomboBox.ValueMember = "Id";
            OYtcomboBox.DataSource = db.Yonetim.ToList();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void DersF_FormClosing(object sender, FormClosingEventArgs e)
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


        private void Eklebutton_Click(object sender, EventArgs e)
        {
            Ders drs = new Ders();
            drs.DersAd = txtDersAd.Text;
            drs.Kredi = textDersKredi.Text;
            drs.OkulYonetimId = int.Parse(OYtcomboBox.SelectedValue.ToString());
            db.Ders.Add(drs);
            db.SaveChanges();
            MessageBox.Show("Ders Eklendi");
        }

        private void Güncelebutton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtDersId.Text);
            var drs = db.Ders.Find(x);
            drs.DersAd = txtDersAd.Text;
            drs.Kredi = textDersKredi.Text;
            drs.OkulYonetimId = int.Parse(OYtcomboBox.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ders Güncellendi");
        }

        private void Listelebutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Ders
                                          select new
                                          {
                                              x.Id,
                                              x.DersAd,
                                              x.Kredi,
                                              x.Yonetim.YonetimAdSoyad


                                          }).ToList();
        }

        private void Silbutton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtDersId.Text);
            var drs = db.Ders.Find(x);
            db.Ders.Remove(drs);
            db.SaveChanges();
            MessageBox.Show("Ders Silindi");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string aranan = textBox5.Text;
            var degerler = from item in db.Ders
                           where item.DersAd.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            txtDersId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtDersAd.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textDersKredi.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            OYtcomboBox.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
        }
    }
}

