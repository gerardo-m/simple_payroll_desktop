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
using simple_payroll_desktop.entities;
using simple_payroll_desktop.business;

namespace simple_payroll_desktop.forms
{
    public partial class PaySchedulesForm : Form
    {

        private readonly ILogger logger;
        private readonly I18nService i18n;
        private readonly PaySchedulesManager paySchedulesManager;

        private PaySchedule currentPaySchedule;
        public PaySchedulesForm(ILogger<PaySchedulesForm> logger,
                                I18nService i18n,
                                PaySchedulesManager paySchedulesManager)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.paySchedulesManager = paySchedulesManager;
            InitializeComponent();
        }

        private void loadPaySchedulesTypes()
        {
            typeComboBox.DataSource = Enum.GetValues(typeof(PayScheduleType));
        }

        private void loadPayRateTypes()
        {
            //TODO keep selected value when possible
            payRateTypesComboBox.DataSource = paySchedulesManager.payRateTypesForPayScheduleType((PayScheduleType)typeComboBox.SelectedItem);
        }

        private void loadTrackingTypes()
        {
            //TODO keep selected value when possible
            trackingTypesComboBox.DataSource = paySchedulesManager.trackingTypeForPayRateType((PayRateType)payRateTypesComboBox.SelectedItem);
        }

        private void updateControlsStates()
        {
            /*if (denominationsListBox.SelectedIndex == -1)
            {
                deleteDenominationButton.Enabled = false;
                saveDenominationButton.Text = i18n.DenominationsForm_Controls(saveDenominationButton.Name, "Save"); ;
            }
            else
            {
                deleteDenominationButton.Enabled = true;
                saveDenominationButton.Text = i18n.DenominationsForm_Controls(saveDenominationButton.Name, "Update"); ;
            }*/
        }

        private void updatePayScheduleList()
        {
            paySchedulesGrid.DataSource = paySchedulesManager.allPaySchedules();
        }

        private void captureCurrentPaySchedule()
        {
            currentPaySchedule.Name = nameTextBox.Text;
            currentPaySchedule.Type = (PayScheduleType)typeComboBox.SelectedItem;
            currentPaySchedule.PayRateType = (PayRateType)payRateTypesComboBox.SelectedItem;
            currentPaySchedule.TrackingType = (TrackingType)trackingTypesComboBox.SelectedItem;
            currentPaySchedule.BasePeriodStart = basePeriodStartPicker.Value;
            currentPaySchedule.BasePeriodEnd = basePeriodEndPicker.Value;
            currentPaySchedule.BasePayDay = basePayDayPicker.Value;
        }

        private void saveCurrentPaySchedule()
        {
            if (currentPaySchedule != null)
            {
                paySchedulesManager.savePaySchedule(currentPaySchedule);
                updatePayScheduleList();
            }
        }

        private void switchToUnselectedState()
        {
            currentPaySchedule = new PaySchedule();
            //TODO complete
        }

        private void ManagePaySchedulesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void PaySchedulesForm_Load(object sender, EventArgs e)
        {
            loadPaySchedulesTypes();
            loadPayRateTypes();
            loadTrackingTypes();
            updatePayScheduleList();
            switchToUnselectedState();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPayRateTypes();
        }

        private void payRateTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTrackingTypes();
        }

        private void savePayScheduleButton_Click(object sender, EventArgs e)
        {
            captureCurrentPaySchedule();
            saveCurrentPaySchedule();
        }
    }
}
