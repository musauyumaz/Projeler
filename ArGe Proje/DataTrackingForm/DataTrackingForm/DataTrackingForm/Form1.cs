using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTrackingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gelenVeri;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                gelenVeri = serialPort1.ReadLine();
                //this.Invoke(new EventHandler(timer1_Tick));
            }
            else
            {
                MessageBox.Show("Seri port açık değil timer başlatılamadı", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnBaglan.Text = "Bağlan";
            btnBaglandiMi.BackColor = Color.White;
            btnBaglan.BackColor = Color.White;
            button1.BackColor = Color.White;
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                comboBoxPorts.Properties.Items.Add(port);
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen)
            {
                try
                {

                    serialPort1.PortName = comboBoxPorts.Text;
                    serialPort1.BaudRate = int.Parse(cmbBaudRate.Text);
                    serialPort1.DataBits = int.Parse(cmbDataBits.Text);
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.Open();
                    btnBaglandiMi.Appearance.BackColor = Color.Green;
                    btnBaglandiMi.Text = "Bağlantı Sağlandı";
                    btnBaglan.BackColor = Color.Green;
                    panelControl1.Enabled = false;
                    button1.Enabled = true;
                    button1.BackColor = Color.White;
                    simpleButton1.Enabled = true;
                    cmbTimerInterval.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Mesajı : " + ex.Message, "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        string[] splittedData;
        string[] gelenVeriParcalandi = new string[13];
        Data data = new Data();
        DataDal dataDal = new DataDal();
        private void timer1_Tick(object sender, EventArgs e)
        {
            gelenVeri = (gelenVeri == null) ? "Veri Yok " : gelenVeri;
            listBox1.Items.Add(gelenVeri);
            splittedData = gelenVeri.Split('*');

            for (int i = 0; i < splittedData.Length; i++)
            {
                gelenVeriParcalandi[i] = splittedData[i];
            }
            //label9.Text = "1";
            //label5.Text = (gelenVeriParcalandi[0] == null) ? "Veri Yok" : gelenVeriParcalandi[0];
            //label6.Text = (gelenVeriParcalandi[1] == null) ? "Veri Yok" : gelenVeriParcalandi[1];
            //label7.Text = (gelenVeriParcalandi[2] == null) ? "Veri Yok" : gelenVeriParcalandi[2];
            //label8.Text = (gelenVeriParcalandi[3] == null) ? "Veri Yok" : gelenVeriParcalandi[3];
            //label11.Text = (gelenVeriParcalandi[4] == null) ? "Veri Yok" : gelenVeriParcalandi[4];
            //label13.Text = (gelenVeriParcalandi[5] == null) ? "Veri Yok" : gelenVeriParcalandi[5];
            //label15.Text = (gelenVeriParcalandi[6] == null) ? "Veri Yok" : gelenVeriParcalandi[6];
            //label17.Text = (gelenVeriParcalandi[7] == null) ? "Veri Yok" : gelenVeriParcalandi[7];

            dataDal.DataTransferToDatabase(gelenVeriParcalandi, data);

        }

        private void btnPortYenile_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                comboBoxPorts.Properties.Items.Add(port);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnBaglan.BackColor = Color.White;
            button1.BackColor = Color.Red;
            timer1.Enabled = false;
            serialPort1.Close();
            panelControl1.Enabled = true;
            button1.Enabled = false;
            listBox1.Items.Clear();
            btnBaglandiMi.Appearance.BackColor = Color.Red;
            btnBaglandiMi.Text = "Bağlantı Kesildi";
            simpleButton1.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(cmbTimerInterval.Text) * 1000;
            timer1.Enabled = true;
        }
    }
}
