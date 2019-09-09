using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace StokTakip.Update
{
    public partial class frmGuncelle : DevExpress.XtraEditors.XtraForm
    {
        WebClient indir = new WebClient();

        public static bool IsRunning(string programAdi)
        {
            return Process.GetProcessesByName(programAdi).Length > 0; //Programın çalışıp çalışmadığı kontrol edilir
        }

        public frmGuncelle()
        {
            InitializeComponent();

            if (IsRunning("StokTakip.BackOffice"))
            {
                if (MessageBox.Show("Güncelleme işleminden önce açık olan uygulamanızın kapatılması gerekiyor. Onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    foreach (var process in Process.GetProcessesByName("StokTakip.BackOffice"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                }
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
