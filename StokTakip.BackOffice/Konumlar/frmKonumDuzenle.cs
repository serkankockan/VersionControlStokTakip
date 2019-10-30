using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;
using StokTakip.Entities.Tools;

namespace StokTakip.BackOffice.Konumlar
{
    public partial class frmKonumDuzenle : DevExpress.XtraEditors.XtraForm
    {
        StokTakipContext context = new StokTakipContext();
        ButonTanimDAL butonTanimDal = new ButonTanimDAL();
        TableTools tableTools = new TableTools();


        public frmKonumDuzenle()
        {
            InitializeComponent();
            AraclarButonYukle();
        }

        private void AraclarButonYukle()
        {
            tableTools.RefreshAll(context);

            foreach (var item in context.ButonTanimlar.ToList())
            {
                SimpleButton dynamicButton = new SimpleButton();

                dynamicButton.Height = 41;
                dynamicButton.Width = 132;
                dynamicButton.Text = item.Turu;
                dynamicButton.Name = item.Id.ToString();
                dynamicButton.Left = (this.ClientSize.Width - Width) / 2;
                dynamicButton.Top = (this.ClientSize.Height - Height) / 2;
                dynamicButton.Click += new EventHandler(btnPaneleEkle_Click);
                flowLayoutPanel1.Controls.Add(dynamicButton);
            }
        }

        private void frmKonumDuzenle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkleDuzenle_Click(object sender, EventArgs e)
        {
            frmAracEkle form = new frmAracEkle(new Entities.Tables.ButonTanim(),false);
            form.ShowDialog();
            if (form.kaydedildi)
            {
                flowLayoutPanel1.Controls.Clear();
                AraclarButonYukle();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            frmAracSec form = new frmAracSec();
            form.ShowDialog();
            if (form.secildi)
            {
                flowLayoutPanel1.Controls.Clear();
                AraclarButonYukle();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void butonYukle()
        {
            tableTools.RefreshAll(context);

            foreach (var item in context.ButonTanimlar.ToList())
            {
                var button = new SimpleButton
                {
                    Name = item.Id.ToString(),
                    Text = item.Turu,
                    Width = 132,
                    Height = 41,
                    Left = (this.ClientSize.Width - Width) / 2,
                    Top = (this.ClientSize.Height - Height) / 2,
                    Anchor = AnchorStyles.None
                };
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void btnPaneleEkle_Click(object sender, EventArgs e)
        {

            var group = new GroupControl()
            {
                Name = "test",
                Text = "test",
                Width = 132,
                Height = 41,
                //Location = new System.Drawing.Point(18, 12),
            };
            panelControl1.Controls.Add(group);
        }
    }
}