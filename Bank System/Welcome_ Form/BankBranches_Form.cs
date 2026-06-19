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
    public partial class BankBranches_Form : Form
    {
        public BankBranches_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbCities.SelectedIndex == 0)
            {
                IrbidBranches_Form f12 = new IrbidBranches_Form();
                this.Hide();
                f12.ShowDialog();
            }
            if (lbCities.SelectedIndex == 1)
            {
                AmmanBranches_Form f13 = new AmmanBranches_Form();
                this.Hide();
                f13.ShowDialog();
            }
            if (lbCities.SelectedIndex == 2)
            {
                AqabaBranches_Form f14 = new AqabaBranches_Form();
                this.Hide();
                f14.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Form f16 = new User_Form();
            this.Hide();
            f16.ShowDialog();
        }
    }
}
