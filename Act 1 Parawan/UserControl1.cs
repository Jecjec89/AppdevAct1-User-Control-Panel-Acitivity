using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevActOnePar
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var inputOne = this.inputOne.Text;
            var inputTwo = this.inputTwo.Text;

            var parent = this.Parent as Form1;
            parent.panelDataOutput = inputOne;
            parent.panelDataOutput2 = inputTwo;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void inputTwo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void inputOne_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
