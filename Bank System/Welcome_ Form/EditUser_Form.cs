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
    public partial class EditUser_Form : Form
    {
        Bankingsys user = new Bankingsys();
        public EditUser_Form()
        {
            InitializeComponent();
        }

        private void EditUser_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBankSystemDataSet.User_Table' table. You can move, or remove it, as needed.
            //this.user_TableTableAdapter.Fill(this.dbBankSystemDataSet.User_Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Form f6 = new User_Form();
            this.Hide();
            f6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEditUserName.Enabled = true;
            txtEditPassword.Enabled = true;
            txtEditFullName.Enabled = true;
            txtEditContact.Enabled = true;
            txtEditAddress.Enabled = true;
            cbEditGender.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEditUserName.Text))
            {
                MessageBox.Show("UserName Must be enterd!");
            }
            if (String.IsNullOrEmpty(txtEditPassword.Text))
            {
                MessageBox.Show("Password MUST be enterd! ");
                return;
            }
          
            bool result = user.UpdateUser(txtEditUserName.Text, txtEditPassword.Text, txtEditFullName.Text, txtEditContact.Text, txtEditAddress.Text, cbEditGender.Text);

            if (result)
            {
                MessageBox.Show("User has been Updated");
                
            }
            else
            {
                MessageBox.Show("User has NOT been Updated");
            }
        }
    }
}
