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

namespace ComPort1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //intialize portname & the remain configration use the defult 
            //(we can edit BaudRate,Parity,..... from serialport setting in properties of visual studio)
            string[] ports = SerialPort.GetPortNames();
            cboxportname.Items.AddRange(ports);//load all ports number to the combox
            serialPort1.PortName = cboxportname.Text;//user select value
           
        }

        private void Send_Click(object sender, EventArgs e)
        {

            try
            {
                if (!serialPort1.IsOpen)//check if the serialport is not  open
                {
                    serialPort1.Open();
                }
                serialPort1.WriteLine("ABC"); //write to the port
                serialPort1.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
