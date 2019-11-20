using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.CodedUISupport;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using StokTakip.Entities.Context;
using StokTakip.Entities.Data_Access;
using StokTakip.Entities.Tables;
using StokTakip.Entities.Tables.Other_Tables;

namespace StokTakip.BackOffice.Konumlar
{
    public partial class frmUrunleriGoruntule : DevExpress.XtraEditors.XtraForm
    {
        private string _konumKodu;
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        StokTakipContext context = new StokTakipContext();
        StokHareket stokHareket = new StokHareket();
        StokDAL stok = new StokDAL();
        List<ToplamStokGorsel> liste = new List<ToplamStokGorsel>();
        

        public frmUrunleriGoruntule(string konumKodu)
        {

            InitializeComponent();

            _konumKodu = konumKodu;
            MessageBox.Show(FlowKontrol("test").ToString());

        }

        private void frmUrunleriGoruntule_Load(object sender, EventArgs e)
        {
            AracDoldur();
            
            //groupControl.Name = liste.Id.ToString();
            //groupControl.Text = liste.Id.ToString();
            //groupControl.Height = butonTanimlari.GroupHeight.Value;
            //groupControl.Width = butonTanimlari.GroupWidth.Value;
            //groupControl.Location = new Point(liste.X.Value, liste.Y.Value);
            //groupControl.AllowDrop = true;
            //flowAnaKapsayici.Controls.Add(groupControl);
        }

        void AracDoldur()
        {
            liste = stokHareketDal.KonumStoklari(context, "9") as List<ToplamStokGorsel>;
            var orderByDescending = liste.OrderByDescending(c=>c.StokGrubu);

            string sonDeger = null;
            string ilkDeger = null;
            string mevcutDeger = null;
            int sayac = 0;
            bool degistir = true;

            foreach (var items in orderByDescending)
            {
                if (FlowKontrol(items.StokGrubu) != true)
                {
                    FlowLayoutPanel flowPanel = new FlowLayoutPanel();
                    flowPanel.Dock = DockStyle.Top;
                    flowPanel.AutoSize = true;
                    flowPanel.AccessibleName = items.StokGrubu;

                    LabelControl label3 = new LabelControl();
                    label3.AutoSizeMode = LabelAutoSizeMode.None;
                    label3.Dock = DockStyle.Top;
                    label3.Text = "Stok Grubu: " + items.StokGrubu;

                    GroupControl groupControl = new GroupControl();
                    groupControl.ShowCaption = false;
                    groupControl.Height = 140;
                    groupControl.Width = 124;

                    LabelControl label1 = new LabelControl();
                    label1.AutoSizeMode = LabelAutoSizeMode.None;
                    label1.Dock = DockStyle.Bottom;
                    label1.Text = items.StokAdi;

                    LabelControl label2 = new LabelControl();
                    label2.AutoSizeMode = LabelAutoSizeMode.None;
                    label2.Dock = DockStyle.Bottom;
                    label2.Text = items.SeriNo;

                    ImageSlider imageSlider = new ImageSlider();
                    imageSlider.Dock = DockStyle.Top;
                    imageSlider.Cursor = DefaultCursor;
                    imageSlider.Width = 120;
                    imageSlider.Height = 84;
                    Stream stream = new MemoryStream(items.Gorsel);
                    imageSlider.Images.Add(Image.FromStream(stream));

                    xtraScrollableControl3.Controls.Add(flowPanel);
                    flowPanel.Controls.Add(label3);
                    flowPanel.Controls.Add(groupControl);
                    groupControl.Controls.Add(imageSlider);
                    groupControl.Controls.Add(label1);
                    groupControl.Controls.Add(label2);

                }
                else if (FlowKontrol(items.StokGrubu))
                {
                    List<Control> list1 = new List<Control>();

                    GetAllControl(xtraScrollableControl3, list1);

                    foreach (Control control in list1.Where(c => c.AccessibleName == items.StokGrubu))
                    {
                        if (control.GetType() == typeof(FlowLayoutPanel))
                        {
                            GroupControl groupControl = new GroupControl();
                            groupControl.ShowCaption = false;
                            groupControl.Height = 140;
                            groupControl.Width = 124;

                            LabelControl label1 = new LabelControl();
                            label1.AutoSizeMode = LabelAutoSizeMode.None;
                            label1.Dock = DockStyle.Bottom;
                            label1.Text = items.StokAdi;

                            LabelControl label2 = new LabelControl();
                            label2.AutoSizeMode = LabelAutoSizeMode.None;
                            label2.Dock = DockStyle.Bottom;
                            label2.Text = items.SeriNo;

                            ImageSlider imageSlider = new ImageSlider();
                            imageSlider.Dock = DockStyle.Top;
                            imageSlider.Cursor = DefaultCursor;
                            imageSlider.Width = 120;
                            imageSlider.Height = 84;
                            Stream stream = new MemoryStream(items.Gorsel);
                            imageSlider.Images.Add(Image.FromStream(stream));

                            control.Controls.Add(groupControl);
                            groupControl.Controls.Add(imageSlider);
                            groupControl.Controls.Add(label1);
                            groupControl.Controls.Add(label2);
                        }
                    }

                    void GetAllControl(Control c, List<Control> list)
                    {
                        foreach (Control control in c.Controls)
                        {
                            list.Add(control);

                            if (control.GetType() == typeof(FlowLayoutPanel))
                                GetAllControl(control, list);
                        }
                    }
                }

            }
        }

        private void groupControl8_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool FlowKontrol(string flowAdi)
        {
            bool kontrol = false;

            List<Control> list1 = new List<Control>();

            GetAllControl(xtraScrollableControl3, list1);

                foreach (Control control in list1.Where(c => c.AccessibleName == flowAdi))
                {
                    if (control.GetType() == typeof(FlowLayoutPanel))
                    {
                        kontrol = true;
                    }
                }

            void GetAllControl(Control c, List<Control> list)
            {
                foreach (Control control in c.Controls)
                {
                    list.Add(control);

                    if (control.GetType() == typeof(FlowLayoutPanel))
                        GetAllControl(control, list);
                }
            }

            return kontrol;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}