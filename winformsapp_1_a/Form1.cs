using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformsapp_1_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var age = tbAge.Text;
            MessageBox.Show($"Your name is {name} and you are {age} years old");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}