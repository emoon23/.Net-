using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientMetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit out of the Client
        }

        private void Std_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected Standard Adapter");
        }

        private void Ctzn_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected Citizen Adapter");
        }

        private void Cstm_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected Custom Solutions");
        }
    }
}
