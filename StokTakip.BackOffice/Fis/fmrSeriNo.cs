using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;

namespace StokTakip.BackOffice.Fis
{
    public partial class fmrSeriNo : DevExpress.XtraEditors.XtraForm
    {

        public string veriSeriNo;

        public fmrSeriNo(string veri)
        {
            InitializeComponent();

            if (veri != null)
            {
                string[] veriListesi = veri.Split(new[] {System.Environment.NewLine},
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in veriListesi)
                {
                    listeSeriNo.Items.Add(item);
                    
                }

            }

        }

        private void fmrSeriNo_Load(object sender, EventArgs e)
        {

        }

        void KayitAc()
        {
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            grpBilgi.Enabled = true;
            txtSeriNo.Enabled = true;
            txtSeriNo.Focus();

        }

        void KayitKapat()
        {
            btnYeni.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            grpBilgi.Enabled = false;
            txtSeriNo.Text = "";
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KayitAc();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listeSeriNo.Items.Remove(listeSeriNo.SelectedItem);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listeSeriNo.Items.Add(txtSeriNo.Text);
            KayitKapat();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrSeriNo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listeSeriNo.Items.Count != 0)
            {
                foreach (var item in listeSeriNo.Items)
                {
                    veriSeriNo += item + System.Environment.NewLine;
                }
            }
        }
    }
}
