using System;
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
                var sonListe = context.ButonTanimlar.Where(c => c.Turu == liste.Turu).ToList();

                foreach (var butonTanimlari in sonListe) // Araçları biçimlendirip panele ekler
                {
                    GroupControl groupControl = new GroupControl();
                    groupControl.Name = liste.Id.ToString();
                    groupControl.Text = liste.Id.ToString();
                    groupControl.Height = butonTanimlari.GroupHeight.Value;
                    groupControl.Width = butonTanimlari.GroupWidth.Value;
                    groupControl.Location = new Point(liste.X.Value,liste.Y.Value);
                    groupControl.AllowDrop = true;
                    PanelKat.Controls.Add(groupControl);
                    

                    groupControl.MouseDown += groupControl_MouseDown;
                    groupControl.MouseUp += groupControl_MouseUp;
                    groupControl.MouseMove += groupControl_MouseMove;

                    SimpleButton simpleButton = new SimpleButton();
                    simpleButton.Name = liste.Id.ToString();
                    simpleButton.AccessibleName = liste.Id.ToString();
                    simpleButton.Dock = (DockStyle)System.Enum.Parse(typeof(DockStyle), butonTanimlari.SimpleDock);
                    simpleButton.LookAndFeel.Style = LookAndFeelStyle.Flat;
                    simpleButton.LookAndFeel.UseDefaultLookAndFeel = false;
                    simpleButton.Appearance.BackColor = colorConverter(butonTanimlari.SimpleArkaPlanRengi);
                    simpleButton.Appearance.BorderColor = colorConverter(butonTanimlari.SimpleKenarRengi);
                    groupControl.Controls.Add(simpleButton);

                    simpleButton.Click += btnDuzenleGoruntule_Click;

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

        private void btnDuzenleGoruntule_Click(object sender, EventArgs e)
        {
            SimpleButton buton = sender as SimpleButton;
            frmUrunleriGoruntule form = new frmUrunleriGoruntule(buton.AccessibleName);
            form.ShowDialog();

        }
    }
}   