﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SerialArduino
{
    public partial class FormMain : Form
    {
        public Boolean loop = true;
        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Serial serial = new Serial();
                serial.setComPort(Convert.ToInt32(edtCom.Text));
                serial.setBauds(Convert.ToInt32(edtBauds.Text));
                serial.exec(serial.getComPort(), serial.getBauds());
            }catch(Exception error){
                MessageBox.Show("Error: Set the config", "Error");
            }
            
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Reading data...", "Serial Arduino");
                while (loop)
                {
                    lsbReceivedData.Items.Add(Serial.Receive(Serial.port));
                    Thread.Sleep(1000);
                }
            }catch(Exception error){
                MessageBox.Show("Error: Set the config", "Error");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            loop = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsbReceivedData.Items.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                String data = edtCMD.Text;
                Serial.Writing(Serial.port, data);
                lsbSentData.Items.Add(data);
                edtCMD.Text = "";
            }catch(Exception error){
                MessageBox.Show("Error: Set the config", "Error");
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anas Araid", "About");
        }

    }
    public class Serial
    {
        // ATTRIBUTI
        public int comPort, bauds;
        public static SerialPort port;
        // COSTRUTTORE
        public Serial()
        {

        }
        public void exec(int comPort, int bauds)
        {
            try
            {
                port = new SerialPort("COM" + getComPort(), getBauds());
                port.Open();
                MessageBox.Show("COM"+ getComPort() + " open", "Serial arduino");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }

        }
        // METODI GET E SET
        public void setComPort(int comPort)
        {
            this.comPort = comPort;
        }
        public void setBauds(int bauds)
        {
            this.bauds = bauds;
        }
        public int getComPort()
        {
            return comPort;
        }
        public int getBauds()
        {
            return bauds;
        }
        // METODI
        public static String Receive(SerialPort port)
        {
            while (true)
            {
                String data = port.ReadLine();
                return data;
            }

        }
        public static void Writing(SerialPort port, String data)
        {
            port.Write(data + "\n");
        }
    }
}
