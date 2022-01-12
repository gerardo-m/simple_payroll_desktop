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
            loadStrings();
        }

        private void loadStrings()
        {
            // TODO
        }

        private void handleException(Exception ex)
        {
            logger.LogError(ex.Message);
            logger.LogTrace(ex, ex.Message);
            MessageBox.Show(ex.Message);
        }

        private void showStatus(string status)
        {
            statusLabel.Text = status;
        }

        private void loadPaySchedulesTypes()
        {
            typeComboBox.DataSource = Enum.GetValues(typeof(PayScheduleType));
        }

        private void loadPayRateTypes()
        {
            object selectedItem = payRateTypesComboBox.SelectedItem;
            payRateTypesComboBox.DataSource = paySchedulesManager.payRateTypesForPayScheduleType((PayScheduleType)typeComboBox.SelectedItem);
            if (selectedItem != null)
            {
                if (payRateTypesComboBox.Items.Contains(selectedItem))
                {
                    payRateTypesComboBox.SelectedItem = selectedItem;
                }
            }
        }

        private void loadTrackingTypes()
        {
            //TODO keep selected value when possible
            trackingTypesComboBox.DataSource = paySchedulesManager.trackingTypeForPayRateType((PayRateType)payRateTypesComboBox.SelectedItem);
        }

        private void updateControlsStates()
        {
            if (paySchedulesGrid.SelectedRows.Count == 0)
            {
                deletePayScheduleButton.Enabled = false;
                savePayScheduleButton.Text = i18n.GeneralFormControls("Save"); 
            }
            else
            {
                deletePayScheduleButton.Enabled = true;
                savePayScheduleButton.Text = i18n.GeneralFormControls("Update");
            }
        }

        private void updatePayScheduleList()
        {
            paySchedulesGrid.SelectionChanged -= paySchedulesGrid_SelectionChanged;
            paySchedulesGrid.DataSource = paySchedulesManager.allPaySchedules();
            paySchedulesGrid.SelectionChanged += paySchedulesGrid_SelectionChanged;
        }

        private void showCurrentPaySchedule()
        {
            // TODO
        }

        private void captureCurrentPaySchedule()
        {
            currentPaySchedule.Name = nameTextBox.Text;
            currentPaySchedule.Type = (PayScheduleType)typeComboBox.SelectedItem;
            currentPaySchedule.PayRateType = (PayRateType)payRateTypesComboBox.SelectedItem;
            currentPaySchedule.TrackingType = (TrackingType)trackingTypesComboBox.SelectedItem;
            currentPaySchedule.BasePeriodStart = basePeriodStartPicker.Value.Date;
            currentPaySchedule.BasePeriodEnd = basePeriodEndPicker.Value.Date;
            currentPaySchedule.BasePayDay = basePayDayPicker.Value.Date;
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
            paySchedulesGrid.ClearSelection();
            nameTextBox.Text = "";
            typeComboBox.SelectedIndex = 0;
            basePeriodStartPicker.Value = DateTime.Today;
            basePeriodEndPicker.Value = DateTime.Today;
            basePayDayPicker.Value = DateTime.Today;
            payRateTypesComboBox.SelectedIndex = 0;
            trackingTypesComboBox.SelectedIndex = 0;
        }

        private void switchToSelectedState(PaySchedule selectedPaySchedule)
        {
            currentPaySchedule = selectedPaySchedule;
            if (currentPaySchedule != null)
            {
                nameTextBox.Text = currentPaySchedule.Name;
                typeComboBox.SelectedItem = currentPaySchedule.Type;
                basePeriodStartPicker.Value = currentPaySchedule.BasePeriodStart;
                basePeriodEndPicker.Value = currentPaySchedule.BasePeriodEnd;
                basePayDayPicker.Value = currentPaySchedule.BasePayDay;
                payRateTypesComboBox.SelectedItem = currentPaySchedule.PayRateType;
                trackingTypesComboBox.SelectedItem = currentPaySchedule.TrackingType;
            }
        }

        private void ManagePaySchedulesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void PaySchedulesForm_Load(object sender, EventArgs e)
        {
            loadPaySchedulesTypes();
            updatePayScheduleList();
            switchToUnselectedState();
            updateControlsStates();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("[PaySchedulesForm] typeComboBox_SelectedIndexChanged");
                loadPayRateTypes();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void payRateTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("[PaySchedulesForm] payRateTypesComboBox_SelectedIndexChanged");
                loadTrackingTypes();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void savePayScheduleButton_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("[PaySchedulesForm] savePayScheduleButton_Click");
                captureCurrentPaySchedule();
                saveCurrentPaySchedule();
                switchToUnselectedState();
                updateControlsStates();
                showStatus(i18n.Placeholder("Calendario guardado"));
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void newPayScheduleButton_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogInformation("[PaySchedulesForm] newPayScheduleButton_Click");
                switchToUnselectedState();
                updateControlsStates();
                showStatus(i18n.Placeholder("Nuevo calendario de pagos"));
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void paySchedulesGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (paySchedulesGrid.Focused)
                {
                    logger.LogInformation("[PaySchedulesForm] paySchedulesGrid_SelectionChanged");
                    if (paySchedulesGrid.SelectedRows.Count > 0)
                    {
                        switchToSelectedState((PaySchedule)paySchedulesGrid.SelectedRows[0].DataBoundItem);
                        updateControlsStates();
                        showStatus(i18n.Placeholder("Calendario seleccionado"));
                    }
                }
                else
                {
                    paySchedulesGrid.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }
    }
}
