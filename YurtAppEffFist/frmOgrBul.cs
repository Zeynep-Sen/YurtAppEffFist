using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtAppEffFist
{
    public partial class frmOgrBul : Form
    {
        public frmOgrBul()
        {
            InitializeComponent();
        }
        frmOgrKaydet frm = new frmOgrKaydet();
        YurtContext ctx = new YurtContext();
        private void btn_bul_Click(object sender, EventArgs e)
        {

            Ogrenci ogr = ctx.Ogrenciler.Find(txt_Bul.Text);
            if (ogr == null)
            {
                MessageBox.Show("Öğrenci Bulunamadı");
            }
            else
            {
                frm.Show();
                frm.btnSil.Visible = true;
                frm.btnKaydet.Text = "Güncelle";
                frm.txt_Ad.Text = ogr.ad;
                frm.txt_Soyad.Text = ogr.soyad;
                frm.txt_AnneAdi.Text = ogr.anneAd;
                frm.txt_AnneSoy.Text = ogr.anneSoyad;
                frm.txt_BabaAdi.Text = ogr.babaAd;
                frm.txt_BabaSoy.Text = ogr.babaSoyad;
                frm.txt_Tc.Text = ogr.tc;
                frm.ogrenciId = ogr.ogrenciId;
                
            }
        }

       
    }
}
