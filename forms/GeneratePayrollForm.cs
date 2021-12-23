using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Windows.Forms;
using simple_payroll_desktop.business;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.forms
{
    public partial class GeneratePayrollForm : Form
    {

        private readonly ILogger logger;
        private readonly I18nService i18n;
        private readonly PayrollManager payrollManager;
        private readonly PaySchedulesManager paySchedulesManager;
        private readonly WorkersManager workersManager;

        private PaySchedule selectedPaySchedule;
        private Worker selectedWorker;
        private PayPeriod selectedPeriod;
        public GeneratePayrollForm(ILogger<GeneratePayrollForm> logger,
                                   I18nService i18n,
                                   PayrollManager payrollManager,
                                   PaySchedulesManager paySchedulesManager,
                                   WorkersManager workersManager)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.payrollManager = payrollManager;
            this.paySchedulesManager = paySchedulesManager;
            this.workersManager = workersManager;
            InitializeComponent();
        }

        private void handleException(Exception ex)
        {
            logger.LogError(ex.Message);
            logger.LogTrace(ex, ex.Message);
            MessageBox.Show(ex.Message);
            throw ex;
        }

        private void loadPaySchedules()
        {
            payScheduleComboBox.DataSource = paySchedulesManager.allPaySchedules();
            selectPaySchedule();
        }

        private void loadWorkers()
        {
            workerComboBox.DataSource = workersManager.workersWithPaySchedule(selectedPaySchedule.Id);
            selectWorker();
        }

        private void selectPaySchedule()
        {
            selectedPaySchedule = (PaySchedule)payScheduleComboBox.SelectedItem;
            loadWorkers();
        }

        private void selectWorker()
        {
            selectedWorker = (Worker)workerComboBox.SelectedItem;
        }

        private void setPeriod(DateTime date)
        {
            selectedPeriod = paySchedulesManager.getPayPeriod(selectedPaySchedule, date);
            showSelectedPeriod();
        }

        private void previousPeriod()
        {
            selectedPeriod = paySchedulesManager.previousPayPeriod(selectedPaySchedule, selectedPeriod);
            showSelectedPeriod();
        }

        private void nextPeriod()
        {
            selectedPeriod = paySchedulesManager.nextPayPeriod(selectedPaySchedule, selectedPeriod);
            showSelectedPeriod();
        }

        private void showSelectedPeriod()
        {
            string periodStart = selectedPeriod.PeriodStart.ToString("d");
            string periodEnd = selectedPeriod.PeriodEnd.ToString("d");
            string periodString = $"{periodStart} - {periodEnd}";
            selectedPeriodLabel.Text = periodString;
            loadPayroll();
        }

        private void loadPayroll()
        {
            //TODO
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

        private void GeneratePayrollForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadPaySchedules();
                setPeriod(DateTime.Today);
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void payScheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectPaySchedule();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void workerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectWorker();
                setPeriod(DateTime.Today);
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void nextPayPeriodButton_Click(object sender, EventArgs e)
        {
            try
            {
                nextPeriod();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void previosPayPeriodButton_Click(object sender, EventArgs e)
        {
            try
            {
                previousPeriod();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }
    }
}
