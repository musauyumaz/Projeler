
namespace DataTrackingForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbBaudRate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxPorts = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDataBits = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.cmbParity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbStopBits = new DevExpress.XtraEditors.ComboBoxEdit();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBaglandiMi = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPortYenile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTimerInterval = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaudRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPorts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDataBits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbParity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStopBits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimerInterval.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPortYenile);
            this.panelControl1.Controls.Add(this.cmbStopBits);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.cmbParity);
            this.panelControl1.Controls.Add(this.btnBaglan);
            this.panelControl1.Controls.Add(this.cmbDataBits);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.comboBoxPorts);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cmbBaudRate);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(13, 29);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(605, 720);
            this.panelControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 33);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Baud Rate :";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Location = new System.Drawing.Point(224, 36);
            this.cmbBaudRate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBaudRate.Properties.Appearance.Options.UseFont = true;
            this.cmbBaudRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBaudRate.Properties.Items.AddRange(new object[] {
            "9600",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Size = new System.Drawing.Size(355, 40);
            this.cmbBaudRate.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 127);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 33);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Port Name :";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Location = new System.Drawing.Point(224, 119);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxPorts.Properties.Appearance.Options.UseFont = true;
            this.comboBoxPorts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxPorts.Size = new System.Drawing.Size(355, 40);
            this.comboBoxPorts.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(61, 218);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(116, 33);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "DataBits :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(92, 310);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 33);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Parity :";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Location = new System.Drawing.Point(224, 210);
            this.cmbDataBits.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDataBits.Properties.Appearance.Options.UseFont = true;
            this.cmbDataBits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDataBits.Properties.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.cmbDataBits.Size = new System.Drawing.Size(355, 40);
            this.cmbDataBits.TabIndex = 8;
            // 
            // btnBaglan
            // 
            this.btnBaglan.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnBaglan.Location = new System.Drawing.Point(21, 462);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(237, 117);
            this.btnBaglan.TabIndex = 0;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // cmbParity
            // 
            this.cmbParity.Location = new System.Drawing.Point(224, 308);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbParity.Properties.Appearance.Options.UseFont = true;
            this.cmbParity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbParity.Properties.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cmbParity.Size = new System.Drawing.Size(355, 40);
            this.cmbParity.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(54, 394);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(123, 33);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Stop Bits :";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.Location = new System.Drawing.Point(224, 391);
            this.cmbStopBits.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbStopBits.Properties.Appearance.Options.UseFont = true;
            this.cmbStopBits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStopBits.Properties.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive"});
            this.cmbStopBits.Size = new System.Drawing.Size(355, 40);
            this.cmbStopBits.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(988, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(902, 708);
            this.listBox1.TabIndex = 6;
            // 
            // btnBaglandiMi
            // 
            this.btnBaglandiMi.Location = new System.Drawing.Point(684, 29);
            this.btnBaglandiMi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaglandiMi.Name = "btnBaglandiMi";
            this.btnBaglandiMi.Size = new System.Drawing.Size(255, 146);
            this.btnBaglandiMi.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 32F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(649, 423);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(319, 182);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "---->";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnPortYenile
            // 
            this.btnPortYenile.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnPortYenile.Location = new System.Drawing.Point(342, 462);
            this.btnPortYenile.Name = "btnPortYenile";
            this.btnPortYenile.Size = new System.Drawing.Size(237, 117);
            this.btnPortYenile.TabIndex = 13;
            this.btnPortYenile.Text = "Portları Yenile";
            this.btnPortYenile.UseVisualStyleBackColor = true;
            this.btnPortYenile.Click += new System.EventHandler(this.btnPortYenile_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button1.Location = new System.Drawing.Point(692, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 117);
            this.button1.TabIndex = 14;
            this.button1.Text = "Bağlantıyı Kes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(692, 306);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(249, 33);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Veri Çekim Hızı (sn) :";
            // 
            // cmbTimerInterval
            // 
            this.cmbTimerInterval.EditValue = "";
            this.cmbTimerInterval.Enabled = false;
            this.cmbTimerInterval.Location = new System.Drawing.Point(649, 357);
            this.cmbTimerInterval.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cmbTimerInterval.Name = "cmbTimerInterval";
            this.cmbTimerInterval.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTimerInterval.Properties.Appearance.Options.UseFont = true;
            this.cmbTimerInterval.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTimerInterval.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "30",
            "60"});
            this.cmbTimerInterval.Size = new System.Drawing.Size(319, 40);
            this.cmbTimerInterval.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTimerInterval);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnBaglandiMi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaudRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPorts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDataBits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbParity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStopBits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimerInterval.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbStopBits;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbParity;
        private System.Windows.Forms.Button btnBaglan;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDataBits;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxPorts;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBaudRate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.SimpleButton btnBaglandiMi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Button btnPortYenile;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTimerInterval;
    }
}

