using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SleighRush
{
    public partial class Menu : Form 
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            //Test for user input, if text box left blank unable to enter in game!
            string text = inputBox.Text;
            if (text == "")
            {
                MessageBox.Show("Name is required!");
            }
            else if(text != null)
            {
                MessageBox.Show(text,"Welcome");
                GameScreen gs = new GameScreen();
                gs.Show();
            }
           // this.Hide();

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
