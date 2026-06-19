using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Welcome__Form
{
    
    public partial class SignUp_Form : Form
    {
        Bankingsys user = new Bankingsys();
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cbGender.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Form f4 = new Login_Form();
            this.Hide();
            f4.ShowDialog();
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please enter UserName!");
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter Password!");
            }
            if (String.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Please enter your full name!");
                return;
            }
            bool result = user.AddUser(txtUserName.Text, txtPassword.Text, txtFullName.Text, txtContact.Text, txtAddress.Text, cbGender.Text);

            if (result)
            {
                MessageBox.Show("User has been added");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtFullName.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                cbGender.Text = "";
            }
            else
            {
                MessageBox.Show("User has NOT been added");
            }
        }
    }
}
