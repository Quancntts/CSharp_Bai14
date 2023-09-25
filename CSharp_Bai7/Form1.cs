using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSmall_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Click Me", picSmall);
        }

        private void bicBig_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Click Me", picSmall);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = asdas.Text + " : " + asdasd.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMessage.Clear();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    lblMessage.ForeColor = Color.Red;
                    txtMessage.ForeColor = Color.Red;
                    txtName.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    lblMessage.ForeColor = Color.Green;
                    txtMessage.ForeColor = Color.Green;
                    txtName.ForeColor = Color.Green;
                    break;
                case "radBlue":
                    lblMessage.ForeColor = Color.Blue;
                    txtMessage.ForeColor = Color.Blue;
                    txtName.ForeColor = Color.Blue;
                    break;
                case "radBlack":
                    lblMessage.ForeColor = Color.Black;
                    txtMessage.ForeColor = Color.Black;
                    txtName.ForeColor = Color.Black;
                    break;


            }
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            bicBig.Visible = true;
            picSmall.Visible = false;
        }

        private void bicBig_Click(object sender, EventArgs e)
        {
            bicBig.Visible = false;
            picSmall.Visible = true;
        }
    }
}
