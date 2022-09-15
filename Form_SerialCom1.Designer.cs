
namespace RS485_Port {
    partial class Form_SerialCom1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.SerPort = new System.IO.Ports.SerialPort(this.components);
            this.textBox_RxData = new System.Windows.Forms.TextBox();
            this.groupBox_ReceivedData = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_SerialCom = new System.Windows.Forms.TabPage();
            this.groupBox_SeralComPort = new System.Windows.Forms.GroupBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.label_BaudRate = new System.Windows.Forms.Label();
            this.button_ClosePort = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.progressBar_PortAvailable = new System.Windows.Forms.ProgressBar();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_PortSelect = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_ReceivedData.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_SerialCom.SuspendLayout();
            this.groupBox_SeralComPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerPort
            // 
            this.SerPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerPort_rx_Chars);
            // 
            // textBox_RxData
            // 
            this.textBox_RxData.Location = new System.Drawing.Point(6, 28);
            this.textBox_RxData.Multiline = true;
            this.textBox_RxData.Name = "textBox_RxData";
            this.textBox_RxData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_RxData.Size = new System.Drawing.Size(650, 431);
            this.textBox_RxData.TabIndex = 1;
            this.textBox_RxData.Text = "Select a serial com port. Waiting... ";
            // 
            // groupBox_ReceivedData
            // 
            this.groupBox_ReceivedData.Controls.Add(this.textBox_RxData);
            this.groupBox_ReceivedData.Location = new System.Drawing.Point(570, 101);
            this.groupBox_ReceivedData.Name = "groupBox_ReceivedData";
            this.groupBox_ReceivedData.Size = new System.Drawing.Size(663, 472);
            this.groupBox_ReceivedData.TabIndex = 2;
            this.groupBox_ReceivedData.TabStop = false;
            this.groupBox_ReceivedData.Text = "Received Data";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_SerialCom);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(33, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 459);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage_SerialCom
            // 
            this.tabPage_SerialCom.Controls.Add(this.groupBox_SeralComPort);
            this.tabPage_SerialCom.Location = new System.Drawing.Point(4, 29);
            this.tabPage_SerialCom.Name = "tabPage_SerialCom";
            this.tabPage_SerialCom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SerialCom.Size = new System.Drawing.Size(523, 426);
            this.tabPage_SerialCom.TabIndex = 0;
            this.tabPage_SerialCom.Text = "Serial Com";
            this.tabPage_SerialCom.UseVisualStyleBackColor = true;
            // 
            // groupBox_SeralComPort
            // 
            this.groupBox_SeralComPort.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox_SeralComPort.Controls.Add(this.textBox_Status);
            this.groupBox_SeralComPort.Controls.Add(this.label_BaudRate);
            this.groupBox_SeralComPort.Controls.Add(this.button_ClosePort);
            this.groupBox_SeralComPort.Controls.Add(this.button_Refresh);
            this.groupBox_SeralComPort.Controls.Add(this.progressBar_PortAvailable);
            this.groupBox_SeralComPort.Controls.Add(this.comboBox_BaudRate);
            this.groupBox_SeralComPort.Controls.Add(this.comboBox_PortSelect);
            this.groupBox_SeralComPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_SeralComPort.Location = new System.Drawing.Point(15, 21);
            this.groupBox_SeralComPort.Name = "groupBox_SeralComPort";
            this.groupBox_SeralComPort.Size = new System.Drawing.Size(493, 101);
            this.groupBox_SeralComPort.TabIndex = 1;
            this.groupBox_SeralComPort.TabStop = false;
            this.groupBox_SeralComPort.Text = "Seral Com Port";
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(6, 69);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(475, 26);
            this.textBox_Status.TabIndex = 7;
            this.textBox_Status.Text = "\r\nRefresh if Com Cable just plugged in\r\n";
            // 
            // label_BaudRate
            // 
            this.label_BaudRate.AutoSize = true;
            this.label_BaudRate.Location = new System.Drawing.Point(258, 12);
            this.label_BaudRate.Name = "label_BaudRate";
            this.label_BaudRate.Size = new System.Drawing.Size(95, 20);
            this.label_BaudRate.TabIndex = 5;
            this.label_BaudRate.Text = "Baud Rate";
            // 
            // button_ClosePort
            // 
            this.button_ClosePort.BackColor = System.Drawing.Color.Pink;
            this.button_ClosePort.Location = new System.Drawing.Point(390, 12);
            this.button_ClosePort.Name = "button_ClosePort";
            this.button_ClosePort.Size = new System.Drawing.Size(91, 51);
            this.button_ClosePort.TabIndex = 4;
            this.button_ClosePort.Text = "Close Port";
            this.button_ClosePort.UseVisualStyleBackColor = false;
            this.button_ClosePort.Click += new System.EventHandler(this.button_ClosePort_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Refresh.Location = new System.Drawing.Point(146, 0);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(91, 32);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // progressBar_PortAvailable
            // 
            this.progressBar_PortAvailable.Location = new System.Drawing.Point(146, 33);
            this.progressBar_PortAvailable.Name = "progressBar_PortAvailable";
            this.progressBar_PortAvailable.Size = new System.Drawing.Size(91, 27);
            this.progressBar_PortAvailable.TabIndex = 2;
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(262, 35);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(112, 28);
            this.comboBox_BaudRate.TabIndex = 1;
            this.comboBox_BaudRate.Text = "115200";
            this.comboBox_BaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_BaudRate_SelectedIndexChanged);
            // 
            // comboBox_PortSelect
            // 
            this.comboBox_PortSelect.FormattingEnabled = true;
            this.comboBox_PortSelect.Location = new System.Drawing.Point(6, 33);
            this.comboBox_PortSelect.Name = "comboBox_PortSelect";
            this.comboBox_PortSelect.Size = new System.Drawing.Size(134, 28);
            this.comboBox_PortSelect.TabIndex = 0;
            this.comboBox_PortSelect.Text = "Select a Port";
            this.comboBox_PortSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox_PortSelect_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form_SerialCom1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 641);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox_ReceivedData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form_SerialCom1";
            this.Text = "Form_SerialCom1";
            this.Load += new System.EventHandler(this.Form_SerialCom1_Load);
            this.groupBox_ReceivedData.ResumeLayout(false);
            this.groupBox_ReceivedData.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_SerialCom.ResumeLayout(false);
            this.groupBox_SeralComPort.ResumeLayout(false);
            this.groupBox_SeralComPort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort SerPort;
        private System.Windows.Forms.TextBox textBox_RxData;
        private System.Windows.Forms.GroupBox groupBox_ReceivedData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_SerialCom;
        private System.Windows.Forms.GroupBox groupBox_SeralComPort;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.Label label_BaudRate;
        private System.Windows.Forms.Button button_ClosePort;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ProgressBar progressBar_PortAvailable;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_PortSelect;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

