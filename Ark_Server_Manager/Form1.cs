using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Ark_Server_Manager
{
    public partial class Form1 : Form
    {
        string configFilePath = "./config.txt";
        
        
        public Form1()
        {
            string[] lines = File.ReadAllLines(configFilePath);
            string serverPath = lines[0];
            string appPath = lines[1];
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("./config.txt");
            Process ArkServer = new Process();
            ArkServer.StartInfo.FileName = lines[0];
            ArkServer.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            ArkServer.Start();
        }
    }
}
