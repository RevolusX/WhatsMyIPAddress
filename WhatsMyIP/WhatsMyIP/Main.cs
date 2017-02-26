using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WhatsMyIP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Disable your firewall before using this program", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            label1.Text = new WebClient().DownloadString("http://www.ipecho.net/plain");
        }
    }
}
