using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevActOnePar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string panelDataOutput 
        {
                    set{

                        inputOneData.Text = value;
                        
                }
        
        }

        public string panelDataOutput2
        {
            set
            {

                
                inputTwoData.Text = value;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void panelOneBtn_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();

            userControl21.Hide();

        }

        private void panelTwoBtn_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();

            userControl11.Hide();
        }

        private void inputOneData_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputTwoData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
