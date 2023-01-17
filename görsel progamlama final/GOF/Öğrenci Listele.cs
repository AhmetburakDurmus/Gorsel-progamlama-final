using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GOF.Personel_Listele;

namespace GOF
{
    public partial class Öğrenci_Listele : Form
    {
        public Öğrenci_Listele()
        {
            InitializeComponent();
        }
        GPDFEntities db = new GPDFEntities();
        private void Öğrenci_Listele_Load(object sender, EventArgs e)
        {
            List<ComboBoxFiltre> list = new List<ComboBoxFiltre>();
            list.Add(new ComboBoxFiltre() { ID = "1", Name = "Ad-Soyad" });
            list.Add(new ComboBoxFiltre() { ID = "2", Name = "Öğrenci No" });
            list.Add(new ComboBoxFiltre() { ID = "3", Name = "Bölüm" });
            list.Add(new ComboBoxFiltre() { ID = "4", Name = "Tümü" });

            cmbFiltre.DataSource = list;
            cmbFiltre.DisplayMember = "Name";
            cmbFiltre.ValueMember = "ID";

            List<ComboBoxFiltre> list2 = new List<ComboBoxFiltre>();

            list2.Add(new ComboBoxFiltre() { ID = "1", Name = "A-Z" });
            list2.Add(new ComboBoxFiltre() { ID = "2", Name = "Z-A" });

            cmbÖlçü.DataSource = list2;
            cmbÖlçü.DisplayMember = "Name";
            cmbÖlçü.ValueMember = "ID";

            dataGridViewOgr.DataSource = (from x in db.Ogrenci
                                          select new
                                          {
                                              x.Id,
                                              x.AdSoyad,
                                              x.KayitTarih,
                                              x.OgrenciNo,
                                              x.DTarih,
                                              x.Bolum
                                          }).ToList();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridViewOgr.DataSource = (from x in db.Ogrenci
                                          select new
                                          {
                                              x.Id,
                                              x.AdSoyad,
                                              x.KayitTarih,
                                              x.OgrenciNo,
                                              x.DTarih,
                                              x.Bolum
                                          }).ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text;
            if (cmbFiltre.Text == "Ad-Soyad")
            {
                var degerler = from item in db.Ogrenci
                               where item.AdSoyad.Contains(aranan)
                               select new { item.AdSoyad, item.OgrenciNo, item.Bolum };
                dataGridViewOgr.DataSource = degerler.ToList();
            }
            if (cmbFiltre.Text == "Öğrenci No")
            {
                var degerler = from item in db.Ogrenci
                               where item.OgrenciNo.Contains(aranan)
                               select new { item.AdSoyad, item.OgrenciNo, item.Bolum };
                dataGridViewOgr.DataSource = degerler.ToList();
            }
            if (cmbFiltre.Text == "Bölüm")
            {
                var degerler = from item in db.Ogrenci
                               where item.Bolum.ToString().Contains(aranan)
                               select new { item.AdSoyad, item.OgrenciNo, item.Bolum };
                dataGridViewOgr.DataSource = degerler.ToList();
            }
            if (cmbFiltre.Text == "Tümü")
            {
                var degerler = from item in db.Ogrenci
                               where item.AdSoyad.Contains(aranan) || item.OgrenciNo.Contains(aranan) || item.Bolum.ToString().Contains(aranan)
                               select new { item.AdSoyad, item.OgrenciNo, item.Bolum };
                dataGridViewOgr.DataSource = degerler.ToList();
            }

        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            var data = (from x in db.Ogrenci
                        select new
                        {
                            x.Id,
                            x.AdSoyad,
                            x.KayitTarih,
                            x.OgrenciNo,
                            x.DTarih,
                            x.Bolum
                        }).ToList();
            if (cmbÖlçü.Text == "A-Z")
            {
                data = data.OrderBy(x => x.AdSoyad).ToList();
            }
            else if (cmbÖlçü.Text == "Z-A")
            {
                data = data.OrderByDescending(x => x.AdSoyad).ToList();
            }
            dataGridViewOgr.DataSource = data;
        }

        private void dataGridViewOgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewOgr.SelectedCells[0].RowIndex;
            Öğrenci öğrenci = new Öğrenci();

            öğrenci.labelId.Text = dataGridViewOgr.Rows[selected].Cells[0].Value.ToString();
            öğrenci.txtÖgrAd.Text = dataGridViewOgr.Rows[selected].Cells[1].Value.ToString();
            öğrenci.kytTarih.Text = dataGridViewOgr.Rows[selected].Cells[2].Value.ToString();
            öğrenci.mskÖgrNo.Text = dataGridViewOgr.Rows[selected].Cells[3].Value.ToString();
            öğrenci.dTarih.Text = dataGridViewOgr.Rows[selected].Cells[4].Value.ToString();
            öğrenci.cmbBölüm.Text = dataGridViewOgr.Rows[selected].Cells[5].Value.ToString();

            öğrenci.MdiParent = this.MdiParent;
            öğrenci.Show();
        }
    }
}
