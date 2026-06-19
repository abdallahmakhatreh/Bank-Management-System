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
    public partial class AqabaBranches_Form : Form
    {
        public AqabaBranches_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankBranches_Form f11 = new BankBranches_Form();
            this.Hide();
            f11.ShowDialog();
        }
    }
}
