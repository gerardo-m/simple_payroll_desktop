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
            InitializeComponent();
        }

        private void handleException(Exception ex)
        {
            logger.LogError(ex.Message);
            logger.LogTrace(ex, ex.Message);
            MessageBox.Show(ex.Message);
            throw ex;
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
        }

        private void loadPaySchedules()
        {
            //TODO filter by pay rate
            payScheduleComboBox.DataSource = paySchedulesManager.allPaySchedules();
            payScheduleComboBox.DisplayMember = "Name";
            payScheduleComboBox.ValueMember = "Id";
        }

        private void switchToUnselectedState()
        {
            currentWorker = new Worker();
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            lastName2TextBox.Text = "";
            ciTextBox.Text = "";
            //TODO handle when options are empty
            /*denominationComboBox.SelectedIndex = 0;
            payScheduleComboBox.SelectedIndex = 0;
            payRateTypeComboBox.SelectedIndex = 0;*/
            payRateSpinner.Value = 0;
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
                updateWorkersList();
            }
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
            switchToUnselectedState();
        }

        private void manageDenominationsButton_Click(object sender, EventArgs e)
        {
            denominationsForm.ShowDialog(this);
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            loadDenominations();
            loadPayRateTypes();
            loadPaySchedules();
            updateWorkersList();
            switchToUnselectedState();
        }

        private void saveWorkerButton_Click(object sender, EventArgs e)
        {
            try
            {
                captureCurrentWorker();
                saveCurrentWorker();
                switchToUnselectedState();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }
    }
}
