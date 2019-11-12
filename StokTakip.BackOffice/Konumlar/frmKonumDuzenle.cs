﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Office.Utils;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using StokTakip.BackOffice.Stok_Hareketleri;
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
        private ButonKonumDAL butonKonumDal = new ButonKonumDAL();
        private ButonKonum entity;
        TableTools tableTools = new TableTools();
        public ButonKonum butonKonum = new ButonKonum();

        bool isDragged = false;
        Point ptOffset;

        public frmKonumDuzenle()
        {
            InitializeComponent();
            
            GroupOlustur();

        }

        private void frmKonumDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkleDuzenle_Click(object sender, EventArgs e)
        {
            konumKaydet();

            frmAracEkle form = new frmAracEkle(new Entities.Tables.ButonTanim(),false);
            form.ShowDialog();
            if (form.kaydedildi)
            {
                PanelKat.Controls.Clear();
                GroupOlustur();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            frmAracSec form = new frmAracSec("Duzenle");
            form.ShowDialog();
            if (form.secildi)
            {
                PanelKat.Controls.Clear();
                GroupOlustur();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            PanelKat.Controls.Add(group);
        }

        public void GroupOlustur()
        {
            foreach (var liste in context.ButonKonumlar.ToList())
            {
                var sonListe = context.ButonTanimlar.Where(c => c.Id == liste.TurKodu).ToList();

                foreach (var butonTanimlari in sonListe) // Araçları biçimlendirip panele ekler
                {
                    GroupControl groupControl = new GroupControl();
                    groupControl.Name = liste.Id.ToString();
                    groupControl.Text = liste.Id.ToString();
                    groupControl.Height = butonTanimlari.GroupHeight.Value;
                    groupControl.Width = butonTanimlari.GroupWidth.Value;
                    groupControl.Location = new Point(liste.X.Value,liste.Y.Value);
                    groupControl.AllowDrop = true;
                    groupControl.Text = "Masa - 1";
                    groupControl.TabIndex = 0;
                    groupControl.AccessibleName = liste.KonumKodu;

                    DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
                    DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
                    DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
                    DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
                    DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
                    DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
                    DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
                    DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
                    DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
                    DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
                    DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
                    DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKonumDuzenle));
                    
                    buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
                    toolTipTitleItem1.Text = "İzlemeler";
                    toolTipItem1.LeftIndent = 6;
                    toolTipItem1.Text = "Konumda bulunan ürünleri gösterir";
                    superToolTip1.Items.Add(toolTipTitleItem1);
                    superToolTip1.Items.Add(toolTipItem1);
                    buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
                    toolTipTitleItem2.Text = "Düzenle";
                    toolTipItem2.LeftIndent = 6;
                    toolTipItem2.Text = "Konumda ürün ekleme, silme, düzenleme işlemleri yapılır.";
                    superToolTip2.Items.Add(toolTipTitleItem2);
                    superToolTip2.Items.Add(toolTipItem2);
                    buttonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions3.Image")));
                    toolTipTitleItem3.Text = "Silme";
                    toolTipItem3.LeftIndent = 6;
                    toolTipItem3.Text = "Konumu siler. Konum üzerinde ürünler var ise ürünleri boşa çıkartır.";
                    superToolTip3.Items.Add(toolTipTitleItem3);
                    superToolTip3.Items.Add(toolTipItem3);

                    groupControl.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
                        new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Izle", false, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, superToolTip1, true, false, true, null, -1),
                        new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Düzenle", false, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, superToolTip2, true, false, true, null, -1),
                        new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sil", false, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, superToolTip3, true, false, true, null, -1)});
                    groupControl.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;

                    groupControl.LookAndFeel.SkinName = "Office 2007 Black";
                    groupControl.LookAndFeel.UseDefaultLookAndFeel = false;
                    groupControl.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
                    
                    PanelKat.Controls.Add(groupControl);
                    
                    groupControl.MouseDown += groupControl_MouseDown;
                    groupControl.MouseUp += groupControl_MouseUp;
                    groupControl.MouseMove += groupControl_MouseMove;
                    groupControl.CustomButtonClick += groupControl_CustomButtonClick;
                    

                    FlowLayoutPanel flowLayout = new FlowLayoutPanel();
                    flowLayout.Height = butonTanimlari.FlowHeight.Value;
                    flowLayout.Dock = (DockStyle)System.Enum.Parse(typeof(DockStyle), butonTanimlari.FlowDock);
                    flowLayout.Visible = butonTanimlari.FlowVisible;
                    groupControl.Controls.Add(flowLayout);
                }
            }
        }
        

        private Color colorConverter(object gelenRenk)
        {
            Type t = gelenRenk.GetType();
            Color renk = new Color();

            if (t.Equals(typeof(int)))
            {
                renk = Color.FromArgb(Convert.ToInt32(gelenRenk));
                return renk;
            }
            else
            {
                renk = Color.FromArgb(Convert.ToInt32(gelenRenk));
                return renk;
            }
        }


        private void groupControl_MouseDown(object sender, MouseEventArgs e)
        {
            GroupControl grp = sender as GroupControl;

            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                Point ptStartPosition = grp.PointToScreen(new Point(e.X, e.Y));

                ptOffset = new Point();
                ptOffset.X = grp.Location.X - ptStartPosition.X;
                ptOffset.Y = grp.Location.Y - ptStartPosition.Y;
            }
            else
            {
                isDragged = false;
            }
            
        }

        private void groupControl_MouseMove(object sender, MouseEventArgs e)
        {
            GroupControl grp = sender as GroupControl;
            if (isDragged)
            {
                Point newPoint = grp.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                grp.Location = newPoint;
            }
        }

        private void groupControl_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKonumEkle_Click(object sender, EventArgs e)
        {
            konumKaydet();

            frmAracSec form = new frmAracSec("PaneleEkle");
            form.ShowDialog();
            if (form.secildi)
            {
                PanelKat.Controls.Clear();
                GroupOlustur();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            konumKaydet();

            MessageBox.Show("Konumlar kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void konumKaydet()
        {
            List<Control> list1 = new List<Control>();

            GetAllControl(PanelKat, list1);

            foreach (var items in context.ButonKonumlar.Where(c => c.Durumu == true).ToList())
            {
                foreach (Control control in list1.Where(c => c.Name == Convert.ToString(items.Id)).ToList())
                {
                    if (control.GetType() == typeof(GroupControl))
                    {
                        entity = butonKonumDal.GetByFilter(context, c => c.Id == items.Id);
                        entity.X = control.Location.X;
                        entity.Y = control.Location.Y;
                        if (butonKonumDal.AddOrUpdate(context, entity))
                        {
                            butonKonumDal.Save(context);
                        }
                    }
                }
            }

            void GetAllControl(Control c, List<Control> list)
            {
                foreach (Control control in c.Controls)
                {
                    list.Add(control);

                    if (control.GetType() == typeof(GroupControl))
                        GetAllControl(control, list);
                }
            }
        }

        

        private void groupControl_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {

            GroupControl groupControl = sender as GroupControl;

            if (e.Button == groupControl.CustomHeaderButtons[0])
            {
                MessageBox.Show("0'a basıldı");
            }

            if (e.Button == groupControl.CustomHeaderButtons[1])
            {
                frmStokDuzenle form = new frmStokDuzenle(groupControl.AccessibleName);
                form.ShowDialog();
            }

            if (e.Button == groupControl.CustomHeaderButtons[2])
            {
                MessageBox.Show("2'e basıldı");
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}   