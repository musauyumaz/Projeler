using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTrackingForm
{
    public partial class MachineData : Form
    {
        public MachineData()
        {
            InitializeComponent();
        }
        MakineListesi makineListesi;
        private void btnMakineListesi1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (makineListesi == null || makineListesi.IsDisposed)
            {
                makineListesi = new MakineListesi();
                makineListesi.MdiParent = this;
                makineListesi.Show();
                btnVeriGoster.Enabled = true;
            }
            else
            {
                btnVeriGoster.Enabled = false;
            }



        }
        Form1 form1;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new Form1();
                form1.MdiParent = this;
                form1.Show();
            }

        }
        ListOfMachine machine;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (machine == null || machine.IsDisposed)
            {
                machine = new ListOfMachine();
                machine.MdiParent = this;
                machine.Show();
            }
        }
    }
}
