using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS485_Port {
    
    public partial class Form_SerialCom1 : Form {
        public static string str_DataRxed_from_SerPort = "fake rxed data";
        private static bool bF_SerPort_Ready = false;
        //cc-------------------------------------------------------------------------------------------------------------
        public Form_SerialCom1() {
            InitializeComponent();
            populate_PortNames();
            str_DataRxed_from_SerPort = "No data yet";
            //Thread SerialPort_Thread = new Thread(new ThreadStart(serialPort1DataReceived));
            //SerialPort_Thread.Start();  // Start secondary thread  

        }
        //cc------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------
        private void populate_PortNames() {
            comboBox_PortSelect.Items.Clear();
            foreach (string PortName in SerialPort.GetPortNames()) {
                comboBox_PortSelect.Items.Add(PortName);
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        private void comboBox_PortSelect_SelectedIndexChanged(object sender, EventArgs e) {
            textBox_RxData.Text = "";
            try {
                //-- close any opened serial port
                if (SerPort.IsOpen) {
                    SerPort.Close();
                }

                //-- get serial port & open
                get_selected_SerPort();
                progressBar_PortAvailable.Value = 0;

                SerPort.Open();
                progressBar_PortAvailable.Value = 100;
                textBox_Status.Text = SerPort.PortName + " is now opened.";
                for (long i = 0; i < 1000000; i++) {
                    ;
                }
                textBox_RxData.Text = "Done";
                bF_SerPort_Ready = true;

                //-- setup peripheral functions
                button_ClosePort.Enabled = true;
                textBox_RxData.Text += "Ready...";
                SerPort_read_n_show();

            } catch {
                textBox_Status.Text = "Invalid Serial Port! Please select Com Port!";
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        private void get_selected_SerPort() {
            SerPort.PortName = comboBox_PortSelect.Text;
            SerPort.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text);
        }
        //--------------------------------------------------------------------------------------------------------------
        private void button_ClosePort_Click(object sender, EventArgs e) {
            if (SerPort.IsOpen) {
                SerPort.Close();
                progressBar_PortAvailable.Value = 0;
                comboBox_PortSelect.Text = "Select a Com Port";
                textBox_Status.Text = "Previous Com Port has closed.";
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        private void button_Refresh_Click(object sender, EventArgs e) {
            populate_PortNames();
        }
        //--------------------------------------------------------------------------------------------------------------
        private void SerPort_read_n_show() {
            if (bF_SerPort_Ready) {
                str_DataRxed_from_SerPort = SerPort.ReadLine();
                textBox_RxData.Text += str_DataRxed_from_SerPort + "\r\n";
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        public void serialPort1DataReceived(object sender, SerialDataReceivedEventArgs e) {
            try {
                str_DataRxed_from_SerPort = SerPort.ReadLine();


                Invoke(new EventHandler(putData));

            } catch {

            }
        }
        //--------------------------------------------------------------------------------------------------------------
        private void putData(object sender, EventArgs e) {
            textBox_RxData.Text += str_DataRxed_from_SerPort;
        }
        //--------------------------------------------------------------------------------------------------------------
        //public static void Data_Rx() {
        //    str_DataRxed_from_SerialPort = serialPort1.ReadLine();
        //    textBox_RxData.Text += str_DataRxed_from_SerialPort + "\r\n";

        //}
        //--------------------------------------------------------------------------------------------------------------
    }
}
