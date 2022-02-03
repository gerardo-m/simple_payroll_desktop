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
        private readonly ControlUtils utils;

        private readonly PaySlipForm paySlipForm;

        private readonly PayrollManager payrollManager;
        private readonly PaySchedulesManager paySchedulesManager;
        private readonly WorkersManager workersManager;

        private PaySchedule selectedPaySchedule;
        private Worker selectedWorker;
        private PayPeriod selectedPeriod;
        private Payroll currentPayroll;
        private Extra selectedExtra;
        public GeneratePayrollForm(ILogger<GeneratePayrollForm> logger,
                                   I18nService i18n,
                                   PaySlipForm paySlipForm,
                                   PayrollManager payrollManager,
                                   PaySchedulesManager paySchedulesManager,
                                   WorkersManager workersManager)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.paySlipForm = paySlipForm;
            this.payrollManager = payrollManager;
            this.paySchedulesManager = paySchedulesManager;
            this.workersManager = workersManager;
            utils = new ControlUtils(i18n);
            InitializeComponent();
        }

        private void handleException(Exception ex)
        {
            logger.LogError(ex.Message);
            logger.LogTrace(ex, ex.Message);
            MessageBox.Show(ex.Message);
            throw ex;
        }

        private void showStatus(string status)
        {
            statusLabel.Text = status;
        }

        private void setToOpenStatus()
        {
            newExtraButton.Enabled = true;
            saveExtraButton.Enabled = true;
            deleteExtraButton.Enabled = true;
            saveButton.Enabled = true;
            saveAndCloseButton.Enabled = true;
            generatePaySlipButton.Enabled = false;
        }

        private void setToClosedStatus()
        {
            newExtraButton.Enabled = false;
            saveExtraButton.Enabled = false;
            deleteExtraButton.Enabled = false;
            saveButton.Enabled = false;
            saveAndCloseButton.Enabled = false;
            generatePaySlipButton.Enabled = true;
        }

        private void setFormStatus()
        {
            if (currentPayroll.Status == PayrollStatus.Open)
                setToOpenStatus();
            else
                setToClosedStatus();
        }

        private void updateControlsStates()
        {
            if (extrasGridView.SelectedRows.Count == 0)
            {
                deleteExtraButton.Enabled = false;
                saveExtraButton.Text = i18n.GeneralFormControls("Save");
            }
            else
            {
                deleteExtraButton.Enabled = true;
                saveExtraButton.Text = i18n.GeneralFormControls("Update");
            }
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

        private void loadExtrasTypes()
        {
            extraTypeComboBox.DataSource = Enum.GetValues(typeof(ExtraType));
            extraTypeComboBox.FormattingEnabled = true;
            extraTypeComboBox.Format += utils.comboBoxEnumDelegate;
        }

        private void loadPayroll()
        {
            currentPayroll = payrollManager.getPayroll(selectedWorker, selectedPeriod);
            showTrackedWork();
            showExtras();
            showTotals();
        }

        private void showTrackedWork()
        {
            payRateDataLabel.Text = currentPayroll.PayRate.ToString("#0.00");
            trackedAmountDataLabel.Text = currentPayroll.TrackedAmount.ToString("#0.00");
            trackedDetailsDataLabel.Text = payrollManager.getTrackedTimeLocalizedDetails(currentPayroll);
        }

        private void showTotals()
        {
            trackedAmountTextBox.Text = currentPayroll.TrackedAmount.ToString("#0.00");
            additionalsAmountTextBox.Text = currentPayroll.ExtrasAmount.ToString("#0.00");
            totalAmountTextBox.Text = currentPayroll.TotalAmount.ToString("#0.00");
            balanceDueTextBox.Text = currentPayroll.BalanceDue.ToString("#0.00");
        }

        private void savePayroll()
        {
            payrollManager.savePayroll(currentPayroll);
        }

        private void newExtra()
        {
            selectedExtra = new Extra();
            extrasGridView.ClearSelection();
            extraConceptTextBox.Text = "";
            extraTypeComboBox.SelectedIndex = 0;
            extraAmountSpinner.Value = 0;
        }

        private void saveSelectedExtra()
        {
            
            selectedExtra.Concept = extraConceptTextBox.Text;
            selectedExtra.Type = (ExtraType)extraTypeComboBox.SelectedItem;
            selectedExtra.Amount = extraAmountSpinner.Value;
            selectedExtra.Payroll = currentPayroll;
            if (!currentPayroll.Extras.Contains(selectedExtra))
                currentPayroll.Extras.Add(selectedExtra);
        }

        private void showSelectedExtra()
        {
            extraConceptTextBox.Text = selectedExtra.Concept;
            extraTypeComboBox.SelectedItem = selectedExtra.Type;
            extraAmountSpinner.Value = selectedExtra.Amount;
        }

        private void deleteSelectedExtra()
        {
            currentPayroll.Extras.Remove(selectedExtra);
        }

        private void showExtras()
        {
            extrasGridView.DataSource = currentPayroll.Extras.ToList();
            extrasGridView.Columns["Id"].Visible = false;
            extrasGridView.Columns["Payroll"].Visible = false;
        }

        private void GeneratePayrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void generatePaySlipButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            paySlipForm.setPayroll(currentPayroll);
            paySlipForm.ShowDialog(this);
        }

        private void GeneratePayrollForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadPaySchedules();
                setPeriod(DateTime.Today);
                loadExtrasTypes();
                selectedExtra = new Extra();
                setFormStatus();
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
                setFormStatus();
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
                setFormStatus();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                savePayroll();
                loadPayroll();
                setFormStatus();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void newExtraButton_Click(object sender, EventArgs e)
        {
            try
            {
                newExtra();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void saveExtraButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveSelectedExtra();
                newExtra();
                showExtras();
                updateControlsStates();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void deleteExtraButton_Click(object sender, EventArgs e)
        {
            try
            {
                deleteSelectedExtra();
                newExtra();
                showExtras();
                updateControlsStates();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void extrasGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (extrasGridView.Focused)
                {
                    logger.LogInformation("[GeneratePayrollForm] extrasGridView_SelectionChanged");
                    if (extrasGridView.SelectedRows.Count > 0)
                    {
                        selectedExtra = (Extra)extrasGridView.SelectedRows[0].DataBoundItem;
                        showSelectedExtra();
                        updateControlsStates();
                        showStatus(i18n.Placeholder("Calendario seleccionado"));
                    }
                }
                else
                {
                    extrasGridView.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void GeneratePayrollForm_VisibleChanged(object sender, EventArgs e)
        {
            loadPayroll();
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                savePayroll();
                payrollManager.closePayroll(currentPayroll);
                loadPayroll();
                setFormStatus();
            }catch(Exception ex)
            {
                handleException(ex);
            }
        }
    }
}
