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
    public partial class Login_Form : Form
    {
        public static string s1 = "";
        public Login_Form()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Form f1 = new Main_Form();
            this.Hide();
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignUp_Form f3 = new SignUp_Form();
            this.Hide();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = txtUserName.Text;
            
            if(string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please Enter a user name");
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter a Password");
                return;
            }
            try
            {
                dbBankSystemDataSetTableAdapters.User_TableTableAdapter user = new dbBankSystemDataSetTableAdapters.User_TableTableAdapter();
                dbBankSystemDataSet.User_TableDataTable dt = user.GetDataByUserNameANDPassword(txtUserName.Text, txtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Succeed");
                    User_Form f5 = new User_Form();
                    this.Hide();
                    f5.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
            
        }
    }
}
