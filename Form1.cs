using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using simple_payroll_desktop.forms;

namespace simple_payroll_desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manageWorkersButton_Click(object sender, EventArgs e)
        {
            ManageWorkersForm manageWorkersForm = new ManageWorkersForm();
            this.Visible = false;
            manageWorkersForm.ShowDialog(this);
        }

        private void trackWorkButton_Click(object sender, EventArgs e)
        {
            TrackWorkForm trackWorkForm = new TrackWorkForm();
            this.Visible = false;
            trackWorkForm.ShowDialog(this);
        }

        private void generatePayrollButton_Click(object sender, EventArgs e)
        {
            GeneratePayrollForm generatePayrollForm = new GeneratePayrollForm();
            this.Visible = false;
            generatePayrollForm.ShowDialog(this);
        }

        private void managePaySchedulesButton_Click(object sender, EventArgs e)
        {
            ManagePaySchedulesForm managePaySchedulesForm = new ManagePaySchedulesForm();
            this.Visible = false;
            managePaySchedulesForm.ShowDialog(this);
        }
    }
}
