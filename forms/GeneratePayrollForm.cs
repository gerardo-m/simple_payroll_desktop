using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_payroll_desktop.forms
{
    public partial class GeneratePayrollForm : Form
    {
        public GeneratePayrollForm()
        {
            InitializeComponent();
        }

        private void GeneratePayrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void generatePaySlipButton_Click(object sender, EventArgs e)
        {
            PaySlipForm paySlipForm = new PaySlipForm();
            this.Visible = false;
            paySlipForm.ShowDialog(this);
        }
    }
}
