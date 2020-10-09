using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFileStreamWrite_Click(object sender, EventArgs e)
        {
            //long someValue = 0x1234569ABCDEF0;

            long someValue = 123456789;
            
            Stream outStream = new FileStream("a.dat", FileMode.Create);

            byte[] wBytes = BitConverter.GetBytes(someValue);

            outStream.Write(wBytes, 0, wBytes.Length);
            
            outStream.Close();
            Console.WriteLine("WRITE DATA DONE.");
            function_bad();
        }

        private void function_bad()
        {
            Console.Write("I'm a bad function");
        }

        private void buttonFileStreamRead_Click(object sender, EventArgs e)
        {
            byte[] rBytes = new byte[8];

            Stream inStream = new FileStream("a.dat", FileMode.Open);

            inStream.Read(rBytes, 0, rBytes.Length);

            long readValue = BitConverter.ToInt64(rBytes, 0);

            Console.WriteLine("READ DATA = " + readValue);
            
            inStream.Close();
            function_bad();
        }
    }
}
