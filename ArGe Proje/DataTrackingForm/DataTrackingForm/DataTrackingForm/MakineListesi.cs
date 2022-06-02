using DevExpress.XtraGrid.Views.Layout;
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
    public partial class MakineListesi : Form
    {
        public static int Id;
        public MakineListesi()
        {
            InitializeComponent();
        }
        MachineData machineData = new MachineData();
        DataDal dataDal = new DataDal();
        DataTrackingDbEntities1 dataTracking = new DataTrackingDbEntities1();
        private void MakineListesi_Load(object sender, EventArgs e)
        {

            var degerler = (from x in dataTracking.Machines
                            select new
                            {
                                x.Id,
                                x.MachineName,
                                x.Brand,
                                x.Frequency,
                                x.Model,
                                x.Power,
                                x.Type,
                                x.Voltage,
                                x.SerialNumber,
                                x.ProductionDate
                            }).ToList();
            gridControl1.DataSource = degerler;
            machineData.btnVeriGoster.Enabled = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMachineName.Text = gridView1.GetFocusedRowCellValue("MachineName").ToString();
            txtVoltage.Text = gridView1.GetFocusedRowCellValue("Voltage").ToString();
            txtFrequency.Text = gridView1.GetFocusedRowCellValue("Frequency").ToString();
            txtPower.Text = gridView1.GetFocusedRowCellValue("Power").ToString();
            txtType.Text = gridView1.GetFocusedRowCellValue("Type").ToString();
            txtBrand.Text = gridView1.GetFocusedRowCellValue("Brand").ToString();
            txtModel.Text = gridView1.GetFocusedRowCellValue("Model").ToString();
            txtSerialNumber.Text = gridView1.GetFocusedRowCellValue("SerialNumber").ToString();
            txtProductionDate.Text = gridView1.GetFocusedRowCellValue("ProductionDate").ToString();

            Id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
        }

        private void MakineListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            machineData.btnVeriGoster.Enabled = false;
        }
    }
}
