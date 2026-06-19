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
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
            labelUserName.Text = Login_Form.s1;
            labelBalance.Text = Balance_Form.bal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditUser_Form f7 = new EditUser_Form();
            this.Hide();
            f7.ShowDialog();
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Balance_Form f9 = new Balance_Form();
            this.Hide();
            f9.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BankBranches_Form f15 = new BankBranches_Form();
            this.Hide();
            f15.ShowDialog();
        }
    }
}
