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
using System.Threading;

namespace DesktopDz
{
    public partial class Form1 : Form
    {
        Process[] lp = Process.GetProcesses();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (Process p in lp) 
            {
                listBox1.Items.Add(p.ProcessName);
                listBox2.Items.Add(p.Id);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Refresh();
            listBox2.Refresh();
        }
    }
}
