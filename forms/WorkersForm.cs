using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using simple_payroll_desktop.business;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.forms
{
    public partial class WorkersForm : Form
    {
        private readonly ILogger logger;
        private readonly I18nService i18n;
        private readonly ControlUtils utils;
        private readonly WorkersManager workersManager;
        private readonly DenominationsManager denominationsManager;
        private readonly PaySchedulesManager paySchedulesManager;
        private readonly DenominationsForm denominationsForm;

        private Worker currentWorker;
        public WorkersForm(ILogger<WorkersForm> logger,
                            I18nService i18n,
                            WorkersManager workersManager,
                            DenominationsManager denominationsManager,
                            PaySchedulesManager paySchedulesManager,
                            DenominationsForm denominationsForm)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.workersManager = workersManager;
            this.denominationsManager = denominationsManager;
            this.paySchedulesManager = paySchedulesManager;
            this.denominationsForm = denominationsForm;
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

        private void loadDenominations()
        {
            denominationComboBox.DataSource = denominationsManager.allDenominations();
            denominationComboBox.DisplayMember = "Name";
            denominationComboBox.ValueMember = "Id";
        }

        private void loadPayRateTypes()
        {
            payRateTypeComboBox.DataSource = new List<PayRateType>((IEnumerable<PayRateType>)Enum.GetValues(typeof(PayRateType)));
            payRateTypeComboBox.FormattingEnabled = true;
            payRateTypeComboBox.Format += utils.comboBoxEnumDelegate;
        }

        private void loadPaySchedules()
        {
            //TODO filter by pay rate
            PayRateType selectedPayRateTyp = (PayRateType)payRateTypeComboBox.SelectedItem;
            payScheduleComboBox.DataSource = paySchedulesManager.allPaySchedules();
            payScheduleComboBox.DisplayMember = "Name";
            payScheduleComboBox.ValueMember = "Id";
        }

        private void updateControlsStates()
        {
            if (workersGrid.SelectedRows.Count == 0)
            {
                deleteWorkerButton.Enabled = false;
                saveWorkerButton.Text = i18n.GeneralFormControls("Save");
            }
            else
            {
                deleteWorkerButton.Enabled = true;
                saveWorkerButton.Text = i18n.GeneralFormControls("Update");
            }
        }

        private void switchToUnselectedState()
        {
            currentWorker = new Worker();
            workersGrid.ClearSelection();
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            lastName2TextBox.Text = "";
            ciTextBox.Text = "";
            //TODO this verifications shouldn't be necessary, add a verification in the beggining to 
            // verify if there are not  pay schedules
            if (denominationComboBox.Items.Count > 0)
                denominationComboBox.SelectedIndex = 0;
            if (payScheduleComboBox.Items.Count > 0)
                payScheduleComboBox.SelectedIndex = 0;
            payRateTypeComboBox.SelectedIndex = 0;
            payRateSpinner.Value = 0;
        }

        private void switchToSelectedState(Worker worker)
        {
            currentWorker = worker;
            if (worker != null)
            {
                showCurrentWorker();
            }
        }

        private void showCurrentWorker()
        {
            firstNameTextBox.Text = currentWorker.FirstName;
            lastNameTextBox.Text = currentWorker.LastName1;
            lastName2TextBox.Text = currentWorker.LastName2;
            ciTextBox.Text = currentWorker.CI;
            payRateSpinner.Value = currentWorker.PayRate;
            denominationComboBox.SelectedItem = currentWorker.Denomination;
            payRateTypeComboBox.SelectedItem = currentWorker.PayRateType;
            payScheduleComboBox.SelectedItem = currentWorker.PaySchedule;
        }

        private void captureCurrentWorker()
        {
            currentWorker.FirstName = firstNameTextBox.Text;
            currentWorker.LastName1 = lastNameTextBox.Text;
            currentWorker.LastName2 = lastName2TextBox.Text;
            currentWorker.CI = ciTextBox.Text;
            currentWorker.PayRate = payRateSpinner.Value;
            currentWorker.Denomination = (Denomination)denominationComboBox.SelectedItem;
            currentWorker.PayRateType = (PayRateType)payRateTypeComboBox.SelectedItem;
            currentWorker.PaySchedule = (PaySchedule)payScheduleComboBox.SelectedItem;
        }

        private void saveCurrentWorker()
        {
            if (currentWorker != null)
            {
                workersManager.saveWorker(currentWorker);
            }
        }

        private void deleteCurrentWorker()
        {
            workersManager.deleteWorker(currentWorker);
        }

        private void updateWorkersList()
        {
            workersGrid.DataSource = workersManager.allWorkers();
        }

        private void ManageWorkersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void newWorkerButton_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("[WorkersForm] newWorkerButton_Click");
                switchToUnselectedState();
                updateControlsStates();
                showStatus(i18n.Placeholder("Nuevo trabajador"));
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void manageDenominationsButton_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("[WorkersForm] manageDenominationsButton_Click");
                denominationsForm.ShowDialog(this);
                loadDenominations();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("[WorkersForm] WorkersForm_Load");
                loadDenominations();
                loadPayRateTypes();
                loadPaySchedules();
                updateWorkersList();
                switchToUnselectedState();
                updateControlsStates();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void saveWorkerButton_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("[WorkersForm] saveWorkerButton_Click");
                captureCurrentWorker();
                saveCurrentWorker();
                updateWorkersList();
                switchToUnselectedState();
                updateControlsStates();
                showStatus(i18n.Placeholder("Trabajador guardado"));
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void workersGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (workersGrid.Focused)
                {
                    logger.LogInformation("[WorkersForm] workersGrid_SelectionChanged");
                    if (workersGrid.SelectedRows.Count > 0)
                    {
                        switchToSelectedState((Worker)workersGrid.SelectedRows[0].DataBoundItem);
                        updateControlsStates();
                        showStatus(i18n.Placeholder("Trabajador seleccionado"));
                    }
                }
                else
                {
                    workersGrid.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void deleteWorkerButton_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("[WorkersForm] deleteWorkerButton_Click");
                deleteCurrentWorker();
                updateWorkersList();
                switchToUnselectedState();
                updateControlsStates();
                showStatus(i18n.Placeholder("Trabajador eliminado"));
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }
    }
}
