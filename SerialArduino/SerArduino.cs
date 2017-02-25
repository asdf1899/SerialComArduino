using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialArduino
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
    public class Serial
    {
        // ATTRIBUTI
        public int comPort, bauds;
        // COSTRUTTORE
        public Serial(int comPort, int bauds)
        {
            setComPort(comPort);
            setBauds(bauds);
            try
            {
                SerialPort port = new SerialPort("COM" + getComPort(), getBauds());
                port.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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

    }


}
