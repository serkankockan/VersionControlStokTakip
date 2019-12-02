using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Word;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;

namespace StokTakip.BackOffice.Konumlar
{
    public partial class frmAracEkle : DevExpress.XtraEditors.XtraForm
    {
        private StokTakipContext context = new StokTakipContext();
        private ButonTanimDAL buttonTanimDal = new ButonTanimDAL();
        private ButonTanim _entity;
        private bool _duzenle;
        int secim;

        public bool kaydedildi = false;

        public frmAracEkle(Entities.Tables.ButonTanim entity,bool duzenle)
        {

            InitializeComponent();

            _duzenle = duzenle;
            _entity = entity;

            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            toggleSwitch1.DataBindings.Add("EditValue", _entity, "FlowVisible", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _entity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTuru.DataBindings.Add("EditValue", _entity, "Turu", false, DataSourceUpdateMode.OnPropertyChanged);

            if (_duzenle)
            {
                groupControl1.Height = _entity.GroupHeight.Value;
                groupControl1.Width = _entity.GroupWidth.Value;
                flowLayoutPanel1.Dock = (DockStyle)System.Enum.Parse(typeof(DockStyle), _entity.FlowDock);
                flowLayoutPanel1.Height = _entity.FlowHeight.Value;
                simpleButton1.Dock = (DockStyle)System.Enum.Parse(typeof(DockStyle), _entity.SimpleDock);
                colorPickEditArkaPlan.EditValue = _entity.SimpleArkaPlanRengi;
                colorPickEditKenar.EditValue = _entity.SimpleKenarRengi;
            }

            if (_entity.Gorsel != null)
            {
                ımageSlider1.Images.Add(Image.FromStream(buttonTanimDal.ResimGetir(context, _entity.Id)));
            }
        }

        private void trackBarControl1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //simpleButton1.Width = Convert.ToInt32(trackBarControl1.EditValue);
            groupControl1.Width = Convert.ToInt32(trackBarControl1.EditValue);
        }

        private void colorPickEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            simpleButton1.Appearance.BackColor = colorPickEditArkaPlan.Color;
        }

        private void frmAracEkle_Load(object sender, EventArgs e)
        {
            trackBarControl1.Value = Convert.ToInt32(groupControl1.Width);
            trackBarControl2.Value = Convert.ToInt32(groupControl1.Height);

            groupControl1.Height = Convert.ToInt32(trackBarControl2.EditValue);
            groupControl1.Width = Convert.ToInt32(trackBarControl1.EditValue);

            
        }

        private void colorPickEdit1_EditValueChanged(object sender, EventArgs e)
        {
            simpleButton1.Appearance.BackColor = colorPickEditArkaPlan.Color;

        }

        private void trackBarControl2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            groupControl1.Height = Convert.ToInt32(trackBarControl2.EditValue);

        }

        private void colorPickEdit2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            simpleButton1.Appearance.BorderColor = colorPickEditKenar.Color;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _entity.GroupHeight = groupControl1.Height;
            _entity.GroupWidth = groupControl1.Width;
            _entity.FlowDock = flowLayoutPanel1.Dock.ToString();
            _entity.FlowHeight = flowLayoutPanel1.Height;
            _entity.SimpleDock = simpleButton1.Dock.ToString();
            _entity.SimpleArkaPlanRengi = colorPickEditArkaPlan.Color.ToArgb().ToString();
            _entity.SimpleKenarRengi = colorPickEditKenar.Color.ToArgb().ToString();
            ResimKaydet();

            if (buttonTanimDal.AddOrUpdate(context, _entity))
            {
                kaydedildi = true;
                buttonTanimDal.Save(context);
                this.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_EditValueChanged(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                flowLayoutPanel1.Visible = true;
            }
            else
            {
                flowLayoutPanel1.Visible = false;
            }
        }

        private void colorPickEditKenar_EditValueChanged(object sender, EventArgs e)
        {
            simpleButton1.Appearance.BorderColor = colorPickEditKenar.Color;

        }

        private void AraclarButonYukle()
        {
            foreach (var item in context.ButonTanimlar.ToList())
            {
                SimpleButton button = new SimpleButton()
                {
                    Name = item.Id.ToString(),
                    Text = item.Turu,
                    Height = 50,
                    Width = 153,
                    Left = (this.ClientSize.Width - Width) / 2,
                    Top = (this.ClientSize.Height - Height) / 2,
                    Anchor = AnchorStyles.None,
                };
                button.Click += new EventHandler(Arac_Click);
            }
        }

        private void Arac_Click(object sender, EventArgs e)
        {

            var b = (SimpleButton)sender;
            secim = Convert.ToInt32(b.Name);

            //var liste = buttonTanimDal.AracTanimlariListele(context, Convert.ToInt32(secim));

            _entity = buttonTanimDal.GetByFilter(context, c => c.Id == secim);

            groupControl1.Height = _entity.GroupHeight.Value;
            groupControl1.Width = _entity.GroupWidth.Value;
            flowLayoutPanel1.Dock = (DockStyle)System.Enum.Parse(typeof(DockStyle), _entity.FlowDock);
            flowLayoutPanel1.Height = _entity.FlowHeight.Value;
            simpleButton1.Dock = (DockStyle)System.Enum.Parse(typeof(DockStyle), _entity.SimpleDock);
            colorPickEditArkaPlan.EditValue = _entity.SimpleArkaPlanRengi;
            colorPickEditKenar.EditValue = _entity.SimpleKenarRengi;

            txtAdi.Text = _entity.Turu;
            txtAciklama.Text = _entity.Aciklama;
            toggleDurumu.EditValue = _entity.Durumu;
            toggleSwitch1.EditValue = _entity.FlowVisible;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGorsel_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtGorsel.Text = open.FileName;
                ımageSlider1.Images.Add(Image.FromFile(open.FileName));
            }
            else
            {
                return;
            }
        }

        void ResimKaydet()
        {
            if (txtGorsel.Text != null && txtGorsel.Text != "")
            {
                string image = txtGorsel.Text;
                Bitmap bmp = new Bitmap(image);
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                byte[] bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));

                _entity.Gorsel = bimage;

            }
        }
    }
}