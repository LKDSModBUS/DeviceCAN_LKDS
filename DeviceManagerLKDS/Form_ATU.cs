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
    public partial class Form_ATU : Form
    {
        public Form_ATU()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                byte[] array = File.ReadAllBytes(dlg.FileName);
                userControl1_ATU1.SetData(array);
            }
        }
    }
}

