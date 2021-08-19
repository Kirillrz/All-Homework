using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppWF.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _text_Click(object sender, EventArgs e)
        {
            var weekends = Enumchik.Sun | Enumchik.Sut;
            _text.Text = (weekends & Enumchik.Sut).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._text.Click += new System.EventHandler(this._text_Click);
        }
    }
}
