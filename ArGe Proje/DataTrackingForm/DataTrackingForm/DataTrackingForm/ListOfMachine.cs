using DevExpress.XtraEditors;
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
    public partial class ListOfMachine : Form
    {
        public ListOfMachine()
        {
            InitializeComponent();
        }
        DataDal dataDal = new DataDal();
        
        private void ListOfMachine_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            VeriListele(MakineListesi.Id);

        }

        private void VeriListele(int id)
        {
            var data = dataDal.ShowMachineData(MakineListesi.Id);
            btnData1.Text = GelenVeriYaziUyarlama((double)data.Data1 /100);
            btnData2.Text = GelenVeriYaziUyarlama((double)data.Data2 /100);
            btnData3.Text = GelenVeriYaziUyarlama((double)data.Data3 /10);
            btnData4.Text = GelenVeriYaziUyarlama((double)data.Data4 );
            btnData5.Text = GelenVeriYaziUyarlama((double)data.Data5);
            btnData6.Text = GelenVeriYaziUyarlama((double)data.Data6);
            btnData7.Text = GelenVeriYaziUyarlama((double)data.Data7);
            btnData8.Text = GelenVeriYaziUyarlama((double)data.Data8);
            btnData9.Text = GelenVeriYaziUyarlama((double)data.Data9);
            btnData10.Text = GelenVeriYaziUyarlama((double)data.Data10);
            btnData11.Text = GelenVeriYaziUyarlama((double)data.Data11);
            btnData12.Text = GelenVeriYaziUyarlama((double)data.Data12);

            btnData1.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data1);
            btnData2.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data2);
            btnData3.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data3);
            btnData4.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data4);
            btnData5.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data5);
            btnData6.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data6);
            btnData7.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data7);
            btnData8.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data8);
            btnData9.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data9);
            btnData10.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data10);
            btnData11.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data11);
            btnData12.Appearance.BackColor = GelenDataRenkUyarlama((double)data.Data12);
        }

        private Color GelenDataRenkUyarlama(double deger)
        {
            Color color;
            if (deger == 0)
            {
                color = Color.Red;
                return color;
            }
            else if (deger == 1)
            {
                color = Color.LawnGreen;
                return color;
            }
            else if (deger == -1)
            {
                color = Color.Blue;
                return color;
            }
            else
            {
                color = Color.Black;
                return color; 
            }
        }
        private string GelenVeriYaziUyarlama(double deger) 
        {
            string yazi = "";
            if (deger == 0)
            {
                yazi = "LOW";
                return yazi;
            }
            else if (deger == 1)
            {
                yazi = "HIGH";
                return yazi;
            }
            else if (deger == -1)
            {
                yazi = "NONE";
                return yazi;
            }
            else
            {
                yazi = deger.ToString();
                return yazi;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VeriListele(MakineListesi.Id);
        }
    }
}
