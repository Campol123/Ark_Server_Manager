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
            
            if (!IsProcessOpen(Path.GetFileName(lines[0]).Replace(".exe", "")))
            {
                textBox_status.ForeColor = Color.Red;
                textBox_status.Text = "Status: Closed";
                textBox_error.Text = "";
                Form2 settingsForm = new Form2();
                settingsForm.Show();
            }
            else
            {
                textBox_error.Text = "Stop server before opening settings";
                textBox_status.ForeColor = Color.Green;
                textBox_status.Text = "Status: Running";



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("./config.txt");
            if (!IsProcessOpen(Path.GetFileName(lines[0]).Replace(".exe", "")))
            {
                textBox_status.ForeColor = Color.Red;
                textBox_status.Text = "Status: Closed";
                textBox_error.Text = "";
                Form2 settingsForm = new Form2();
                settingsForm.Show();
            }
            else
            {
                textBox_error.Text = "Stop server before opening settings";
                textBox_status.ForeColor = Color.Green;
                textBox_status.Text = "Status: Running";
                


            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string[] lines = File.ReadAllLines("./config.txt");
            Process ArkServer = new Process();
            ArkServer.StartInfo.FileName = lines[0];
            //ArkServer.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            ArkServer.Start();
            if (lines[1]!="no path")
            {
                Process App = new Process();
                App.StartInfo.FileName = lines[1];
                App.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                App.Start();
                
            }
            textBox_status.ForeColor = Color.Green;
            textBox_status.Text = "Status: Running";
        }
        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("./config.txt");
            if (IsProcessOpen(Path.GetFileName(lines[0]).Replace(".exe", "")))
            {
                textBox_status.ForeColor = Color.Green;
                textBox_status.Text = "Status: Running";
                textBox_error.Text = "";
            }
            else
            {
                textBox_status.ForeColor = Color.Red;
                textBox_status.Text = "Status: Closed";


            }
        }
    }
}
