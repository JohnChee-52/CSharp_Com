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
        public static string str_RxData = "fake rxed data";
        public static bool bF_SerPort_Ready = false;
        //cc-------------------------------------------------------------------------------------------------------------
        public Form_SerialCom1() {
            InitializeComponent();
            populate_PortNames();

            str_RxData = "No data yet";
            SerPort.ReadTimeout = 500; //ms
            SerPort.WriteTimeout = 500; //ms


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

                //-- get serial port from displayed
                Set_SerPort_to_UsrChoice();

                //-- signal to user that port is being set and available
                progressBar_PortAvailable.Value = 0;
                SerPort.Open(); //should be successful, since we had checked which com ports are available
                bF_SerPort_Ready = true;

                //-- dramatize the opening of the selected com port
                progressBar_PortAvailable.Value = 100;
                textBox_Status.Text = SerPort.PortName + " is now opened.";
                textBox_RxData.Text = "Waiting to receive data...";

                //-- enable Close button since Port is already opened
                button_ClosePort.Enabled = true;

                Thread.Sleep(500); //Give time for the progress bar to display
                SerPort_read_n_show();

            } catch { //if opening a port is not successful, then..
                textBox_Status.Text = "Invalid Serial Port! Please select Com Port!";
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        private void Set_SerPort_to_UsrChoice() {
            SerPort.PortName = comboBox_PortSelect.Text; //Set the Serial port to one of recently populated serial port names 
            SerPort.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text); //Set the baudrate according to that displayed
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
        public void SerPort_read_n_show() {
            while (bF_SerPort_Ready) {
                try {
                    str_RxData = SerPort.ReadLine();
                    textBox_RxData.Text += str_RxData + "\r\n";
                } catch (TimeoutException) {

                }
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        //public void serialPort1DataRxed(object sender, SerialDataReceivedEventArgs e) {
        //    try {
        //        str_RxData = SerPort.ReadLine();


        //        Invoke(new EventHandler(putData));

        //    } catch {

        //    }
        //}
        //--------------------------------------------------------------------------------------------------------------
        private void putData(object sender, EventArgs e) {
            //textBox_RxData.Text += str_RxData;
        }

        private void comboBox_BaudRate_SelectedIndexChanged(object sender, EventArgs e) {

        }
        //--------------------------------------------------------------------------------------------------------------
    }
}
