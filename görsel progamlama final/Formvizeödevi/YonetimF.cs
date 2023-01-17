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
    public partial class YonetimF : Form
    {
        public YonetimF()
        {
            InitializeComponent();
        }
        FVDataEntities db = new FVDataEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textId.Text);
            var yntm = db.Yonetim.Find(x);
            yntm.YonetimAdSoyad = textAdSoyad.Text;
            yntm.Gorevi = textGorev.Text;
            yntm.YonetimTip = byte.Parse(cmbYT.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Yönetici Güncellendi");
        }
        
        private void YonetimF_Load(object sender, EventArgs e)
        {
            List<cmb> list = new List<cmb>();
            list.Add(new cmb() { ID = "11", Name = "Idare" });
            list.Add(new cmb() { ID = "12", Name = "Ogretmen" });
            list.Add(new cmb() { ID = "13", Name = "OgrenciIsleri" });

            cmbYT.DataSource = list;
            cmbYT.DisplayMember = "Name";
            cmbYT.ValueMember = "ID";
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
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

        private void YonetimF_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            Yonetim yntm = new Yonetim();
            yntm.YonetimAdSoyad = textAdSoyad.Text;
            yntm.Gorevi = textGorev.Text;
            yntm.YonetimTip = byte.Parse(cmbYT.SelectedValue.ToString());
            db.Yonetim.Add(yntm);
            db.SaveChanges();
            MessageBox.Show("Yönetici Eklendi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Yonetim
                                           select new
                                           {
                                               x.Id,
                                               x.YonetimAdSoyad,
                                               x.Gorevi,
                                               x.YonetimTip
                                           }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textId.Text);
            var yntm = db.Yonetim.Find(x);
            db.Yonetim.Remove(yntm);
            db.SaveChanges();
            MessageBox.Show("Yönetici Silindi");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string aranan = textAra.Text;
            var degerler = from item in db.Yonetim
                           where item.YonetimAdSoyad.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            textId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textAdSoyad.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textGorev.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            cmbYT.SelectedValue = dataGridView1.Rows[selected].Cells[3].Value.ToString();
        }
    }
}
