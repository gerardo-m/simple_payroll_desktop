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
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        private void ManageWorkersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void newWorkerButton_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        private void clearFields()
        {
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.lastName2TextBox.Text = "";
            this.ciTextBox.Text = "";
            this.denominationComboBox.SelectedIndex = 0;
            this.payScheduleComboBox.SelectedIndex = 0;
            this.payRateTypeComboBox.SelectedIndex = 0;
            this.payRateSpinner.Value = 0;
        }

        private void manageDenominationsButton_Click(object sender, EventArgs e)
        {
            DenominationsForm denominationsForm = new DenominationsForm();
            denominationsForm.ShowDialog(this);
        }
    }
}
