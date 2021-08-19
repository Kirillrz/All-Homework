using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWinForms
{
    public partial class Startupform : Form
    {
        public Startupform()
        {
            InitializeComponent();
        }

        private void Startupform_Load(object sender, EventArgs e)
        {

        }

        private void Simplebotton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Start programm");
        }
    }
}
