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
    public partial class Balance_Form : Form
    {
        private double a;
        public static string bal= "";

        public Balance_Form()
        {
            InitializeComponent();
        }

        private void Balance_Form_Load(object sender, EventArgs e)
        {

            //double a = 0;
            labelBValue.Text = a.ToString() + "  JOD";
            //bal = labelBValue.Text;

            if (bal != "")
            {
                bal = labelBValue.Text + "  JOD";
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = double.Parse(txtDopist.Text);
            a += b;
            MessageBox.Show("Money has been deposited successfully!");
            labelBValue.Text = a.ToString() + "  JOD";
            bal = a.ToString() + "  JOD";
            txtDopist.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double c = double.Parse(txtWithdraw.Text);
            a -= c;
            MessageBox.Show("Money has been withdrawal succesfully!");
            labelBValue.Text = a.ToString() + "  JOD";
            bal = a.ToString() + "  JOD";
            txtWithdraw.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_Form f16 = new User_Form();
            this.Hide();
            f16.ShowDialog();
        }
    }
}
