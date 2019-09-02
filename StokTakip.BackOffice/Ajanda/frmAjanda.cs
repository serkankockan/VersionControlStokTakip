using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using StokTakip.Entities.Context;


namespace StokTakip.BackOffice.Ajanda
{
    public partial class frmAjanda : DevExpress.XtraEditors.XtraForm
    {

        StokTakipContext context = new StokTakipContext();

        public frmAjanda()
        {
            InitializeComponent();

            
            context.EfAppointments.Load(); // verilerin gelmesi için önceilkle load uygulanır
            context.EfResources.Load();

            schedulerControl1.DataStorage.Appointments.DataSource = context.EfAppointments.Local.ToBindingList(); // canlı çalışılacağı için binding yapıldı
            schedulerControl1.DataStorage.Resources.DataSource = context.EfResources.Local.ToBindingList();
        }

        private void frmAjanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();
        }
    }
}