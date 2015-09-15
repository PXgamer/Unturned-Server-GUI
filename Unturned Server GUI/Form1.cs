using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Unturned_Server_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vars.map = listBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            vars.name = textBox1.Text;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            vars.gamemode = listBox2.SelectedItem.ToString();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            vars.PVsetting = listBox4.SelectedItem.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            vars.pass = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            vars.port = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(vars.cmd, vars.cmd + vars.def + vars.name + " -" + vars.map + " -" + vars.gamemode + " -" + vars.sync + " -" + vars.PVsetting + " -pass " + vars.pass + " -port " + vars.port + " -players " + vars.players + " " + vars.end);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vars.dir = @"C:\Program Files (x86)\Steam\steamapps\Unturned\Servers\" + vars.name;
            if (File.Exists(vars.dir + @"\Server\Commands.dat"))
            {
                string[] lines = new string[6];
                lines[0] = "Name " + vars.name;
                lines[1] = "Map " + vars.map;
                lines[2] = "Mode " + vars.gamemode;
                lines[5] = "Password " + vars.pass;
                lines[6] = "Port " + vars.port;

                File.WriteAllLines(vars.dir + @"\Server\Commands.dat", lines);
            }
            else
            {
                File.Create(vars.dir + @"\Server\Commands.dat");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            vars.sync = listBox3.SelectedItem.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            vars.players = textBox4.Text;
        }
    }
}
