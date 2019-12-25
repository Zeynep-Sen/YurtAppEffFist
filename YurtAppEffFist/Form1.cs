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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ogrenciKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrKaydet frm = new frmOgrKaydet();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ogrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrBul frm = new frmOgrBul();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ogrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrBul frm = new frmOgrBul();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
