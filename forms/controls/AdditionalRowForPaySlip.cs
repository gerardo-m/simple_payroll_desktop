using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.forms.controls
{
    public partial class AdditionalRowForPaySlip : UserControl
    {
        public AdditionalRowForPaySlip(Extra extra)
        {
            InitializeComponent();
            conceptLabel.Text = extra.Concept;
            amountTextBox.Text = extra.Amount.ToString("#0.00");
        }
    }
}
