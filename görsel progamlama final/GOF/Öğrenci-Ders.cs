using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOF
{
    public partial class Öğrenci_Ders : Form
    {
        public Öğrenci_Ders()
        {
            InitializeComponent();
        }
        GPDFEntities db = new GPDFEntities();
        private void Öğrenci_Ders_Load(object sender, EventArgs e)
        {
            cmbDers.DisplayMember = "Ad";
            cmbDers.ValueMember = "Id";

            cmbÖgr.DisplayMember = "AdSoyad";
            cmbÖgr.ValueMember = "Id";

            cmbDers.DataSource = db.Ders.ToList();
            cmbÖgr.DataSource = db.Ogrenci.ToList();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var ögrdrs = db.OgrenciDers.Find(x);
            ögrdrs.OgrenciId = int.Parse(cmbÖgr.SelectedValue.ToString());
            ögrdrs.DersId = int.Parse(cmbDers.SelectedValue.ToString());
            MessageBox.Show("Öğrencinin Dersi Güncellendi");
        }

        private void btnGüncelle_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var ögrdrs = db.OgrenciDers.Find(x);
            ögrdrs.OgrenciId = int.Parse(cmbÖgr.SelectedValue.ToString());
            ögrdrs.DersId = int.Parse(cmbDers.SelectedValue.ToString());
            MessageBox.Show("Öğrencinin Dersi Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var ögrdrs = db.OgrenciDers.Find(x);
            db.OgrenciDers.Remove(ögrdrs);
            db.SaveChanges();
            MessageBox.Show("Ders Silindi");
        }
    }
}
