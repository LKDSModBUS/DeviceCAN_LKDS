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

namespace DeviceManagerLKDS
{
    public partial class Form_ATS : Form
    {
        public Form_ATS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                byte[] array = File.ReadAllBytes(dlg.FileName);
                userControl_ATS1.SetData(array);
            }

        }
    }
}
