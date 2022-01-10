using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.Extensions.Logging;
using simple_payroll_desktop.entities;
using simple_payroll_desktop.business;
using simple_payroll_desktop.printing;

namespace simple_payroll_desktop.forms
{
    public partial class PaySlipForm : Form
    {

        private readonly ILogger logger;
        private readonly I18nService i18n;

        private readonly PaySlipManager paySlipManager;

        private PaySlip currentPaySlip;
        private Payroll selectedPayroll;
        public PaySlipForm(ILogger<GeneratePayrollForm> logger,
                           I18nService i18n,
                           PaySlipManager paySlipManager)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.paySlipManager = paySlipManager;
            InitializeComponent();
        }

        private void handleException(Exception ex)
        {
            logger.LogError(ex.Message);
            logger.LogTrace(ex, ex.Message);
            MessageBox.Show(ex.Message);
            throw ex;
        }

        public void setPayroll(Payroll payroll)
        {
            selectedPayroll = payroll;
        }

        private void loadPaySlip()
        {
            currentPaySlip = paySlipManager.createNewPaySlip(selectedPayroll);
        }

        private void showPaySlip()
        {
            trackedWorkConceptDataLabel.Text = currentPaySlip.TrackedWorkConcept;
            trackedWorkAmountTextBox.Text = currentPaySlip.TrackedWorkAmount.ToString();
            payrollTotalTextBox.Text = currentPaySlip.PayrollTotal.ToString();
            previouslyPaidTextBox.Text = currentPaySlip.PreviouslyPaid.ToString();
            toBePaidTextBox.Text = currentPaySlip.ToBePaid.ToString();
            workerTextBox.Text = currentPaySlip.WorkerFullName + currentPaySlip.WorkerCI;
        }

        private void savePaySlip()
        {
            paySlipManager.savePaySlip(currentPaySlip);
        }

        private void print()
        {
            PaySlipPrinter printer = new PaySlipPrinter(currentPaySlip);
            PrintDocument document = printer.buildDocument();
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = document;
            if (printDialog.ShowDialog() == DialogResult.OK)
                document.Print();
            else
                MessageBox.Show("Print canceled");
        }

        private void PaySlipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void PaySlipForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadPaySlip();
                showPaySlip();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void saveAndPrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                savePaySlip();
                print();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }
    }
}
