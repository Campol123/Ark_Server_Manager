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

namespace Ark_Server_Manager
{
    public partial class Form2 : Form
    {
        string configFilePath = "./config.txt";
        public Form2()
        {
            string[] lines = File.ReadAllLines(configFilePath);
            string serverPath = lines[0];
            string appPath = lines[1];
            InitializeComponent();
            textBox_server_location.Text = serverPath;
            textBox_app_location.Text = appPath;
        }
        
        private void button_set_server_location_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(configFilePath);
            lines[0] = textBox_server_location.Text;
            File.WriteAllLines(configFilePath, lines);
        }

        private void button_set_app_location_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(configFilePath);
            lines[1] = textBox_app_location.Text;
            File.WriteAllLines(configFilePath, lines);
        }


    }
}
