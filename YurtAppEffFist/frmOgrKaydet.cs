using BLL;
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
    public partial class frmOgrKaydet : Form
    {
        public int ogrenciId = 0;
        public frmOgrKaydet()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            foreach (Control item in this.Controls["pnlTxt"].Controls)
            {
                item.Text = string.Empty;
            }
            ogrenciId = 0;
            btnSil.Enabled = false;
            btnKaydet.Text = "Kaydet";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci ogr = new Ogrenci();
            Okul okl = new Okul();
            ogr.ad = txt_Ad.Text.Trim();
            ogr.soyad = txt_Soyad.Text.Trim();
            ogr.ogrenciId = ogrenciId;
            ogr.tc = txt_Tc.Text.Trim();
            ogr.anneAd = txt_AnneAdi.Text.Trim();
            ogr.anneSoyad = txt_AnneSoy.Text.Trim();
            ogr.babaAd = txt_BabaAdi.Text.Trim();
            ogr.babaSoyad = txt_BabaSoy.Text.Trim();
            ogr.okulId = (int)cmb_OklAdi.SelectedValue;
            okl.OkulID = (int)cmb_OklAdi.SelectedValue;
            okl.Okul_Ad = cmb_OklAdi.Text;
            ogr.okulu = okl;



            switch (ogrenciId)
            {
                case 0:
                    if (obl.OgrenciKaydet(ogr))
                    {
                        MessageBox.Show("Kayıt Başarılı");

                    }
                    else
                    {
                        MessageBox.Show("Yeniden Deneyiniz!!");
                    }

                    break;
                default:
                    if (obl.OgrenciGuncelle(ogr))
                    {

                        MessageBox.Show("Güncelleme Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Başarısız!");
                    }
                    break;
            }
            


        }

        private void frmOgrKaydet_Load(object sender, EventArgs e)
        { OkulBL obl = new OkulBL();
            cmb_OklAdi.DataSource = obl.okulListesi();
            cmb_OklAdi.DisplayMember = "Okul_Ad";
            cmb_OklAdi.ValueMember = "Okul_ID";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kayıt Silinecek. Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.Yes)
            {
                {
                    using (YurtContext ctx = new YurtContext())
                    {
                        OgrenciBL obl = new OgrenciBL();
                        Ogrenci o = ctx.Ogrenciler.Find(ogrenciId);
                        obl.OgrenciSil(o);        
                    }
                    MessageBox.Show("Silme Başarılı");
                    Temizle();
                }

            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
                 Temizle();
            }
        }
    }
}
