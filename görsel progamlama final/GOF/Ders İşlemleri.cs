using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOF
{
    public partial class Ders_İşlemleri : Form
    {
        public Ders_İşlemleri()
        {
            InitializeComponent();
        }
        GPDFEntities db = new GPDFEntities();


        private void Ders_İşlemleri_Load(object sender, EventArgs e)
        {
            cmbEğitmen.DisplayMember = "AdSoyad";
            cmbEğitmen.ValueMember = "Id";
            cmbEğitmen.DataSource = db.Personel.ToList();

            List<ComboBoxDersKredi> list = new List<ComboBoxDersKredi>();
            list.Add(new ComboBoxDersKredi() { ID = "1", Name = "1" });
            list.Add(new ComboBoxDersKredi() { ID = "2", Name = "2" });

            cmbDersKredi.DataSource = list;
            cmbDersKredi.DisplayMember = "Name";
            cmbDersKredi.ValueMember = "ID";

            List<ComboBoxDersRenk> list1 = new List<ComboBoxDersRenk>();
            list1.Add(new ComboBoxDersRenk() { ID = "1", Name = "Siyah" });
            list1.Add(new ComboBoxDersRenk() { ID = "2", Name = "Beyaz" });

            cmbRenk.DataSource = list1;
            cmbRenk.DisplayMember = "Name";
            cmbRenk.ValueMember = "ID";
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            Ders drs = new Ders();
            drs.Ad = txtDersAd.Text;
            drs.Kredisi = int.Parse(cmbDersKredi.SelectedValue.ToString());
            drs.OkulYonetimId = int.Parse(cmbEğitmen.SelectedValue.ToString());
            drs.DersRenk = int.Parse(cmbRenk.SelectedValue.ToString());
            db.Ders.Add(drs);
            db.SaveChanges();
            MessageBox.Show("Ders Eklendi");
        }

        private void btnDersGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var drs = db.Ders.Find(x);
            drs.Ad = txtDersAd.Text;
            drs.Kredisi = int.Parse(cmbDersKredi.SelectedValue.ToString());
            drs.OkulYonetimId = int.Parse(cmbEğitmen.SelectedValue.ToString());
            drs.DersRenk = int.Parse(cmbRenk.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ders Güncellendi");
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var drs = db.Ders.Find(x);
            db.Ders.Remove(drs);
            db.SaveChanges();
            MessageBox.Show("Ders Silindi");
        }
        internal class ComboBoxDersRenk
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
        internal class ComboBoxDersKredi
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
    }

}
