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
using simple_payroll_desktop.forms.controls.track_work;

namespace simple_payroll_desktop.forms
{
    public partial class TrackWorkForm : Form
    {

        private readonly ILogger logger;
        private readonly I18nService i18n;
        private readonly PaySchedulesManager paySchedulesManager;
        private readonly WorkersManager workersManager;
        private readonly TrackingEntriesManager trackingEntriesManager;

        private PaySchedule selectedPaySchedule;
        private Worker selectedWorker;
        private PayPeriod selectedPeriod;
        private IList<TrackingEntry> entries;
        private bool unsavedChanges;
        private int previouslySelectedPayScheduleIndex;
        private int previouslySelectedWorkerIndex;
        private bool revertingSelection;

        private BaseTrackerControl trackerControl;
        public TrackWorkForm(ILogger<TrackWorkForm> logger,
                             I18nService i18n,
                             PaySchedulesManager paySchedulesManager,
                             WorkersManager workersManager, 
                             TrackingEntriesManager trackingEntriesManager)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.paySchedulesManager = paySchedulesManager;
            this.workersManager = workersManager;
            this.trackingEntriesManager = trackingEntriesManager;
            unsavedChanges = false;
            revertingSelection = false;
            previouslySelectedPayScheduleIndex = 0;
            previouslySelectedWorkerIndex = 0;
            InitializeComponent();
        }

        private void changeTrackerControl()
        {
            if (trackerControl != null)
                trackingBoxPanel.Controls.Remove(trackerControl);
            TrackerControlSelector controlSelector = new TrackerControlSelector();
            trackerControl =  controlSelector.getTrackerControl(selectedPaySchedule.TrackingType, logger, i18n);
            trackerControl.TrackingValuesChanged += trackingChanged;
            trackingBoxPanel.Controls.Add(trackerControl);
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

        private void loadPaySchedules()
        {
            paySchedulesComboBox.DataSource = paySchedulesManager.allPaySchedules();
        }

        private void loadWorkers()
        {
            workersComboBox.DataSource = workersManager.workersWithPaySchedule(selectedPaySchedule.Id);
            selectWorker();
        }

        private void loadTrackingEntries()
        {
            entries = trackingEntriesManager.getTrackingEntries(selectedPeriod, selectedWorker);
            trackerControl.setTrackingEntries(entries);
            unsavedChanges = false;
        }

        private void selectPaySchedule()
        {
            selectedPaySchedule = (PaySchedule)paySchedulesComboBox.SelectedItem;
            loadWorkers();
        }

        private void selectWorker()
        {
            selectedWorker = (Worker)workersComboBox.SelectedItem;
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
            loadTrackingEntries();
        }

        private void saveTrackingEntries()
        {
            trackingEntriesManager.saveTrackingEntries(trackerControl.GetTrackingEntries());
            unsavedChanges = false;
        }

        private bool confirmIfUnsavedChanges()
        {
            if (unsavedChanges)
            {
                DialogResult result = MessageBox.Show(i18n.Placeholder("?"), i18n.Placeholder("?"), MessageBoxButtons.YesNo);
                return result == DialogResult.Yes;
            }
            return true;
        }

        private void revertComboBoxSelection(ComboBox comboToRevert, int previousIndex)
        {
            revertingSelection = true;
            comboToRevert.SelectedIndex = previousIndex;
            revertingSelection = false;
        }

        private void TrackWorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }

        private void TrackWorkForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadPaySchedules();
                changeTrackerControl();
                setPeriod(DateTime.Today);
                showStatus(i18n.Placeholder("Inicio"));
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
            
        }

        private void paySchedulesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (revertingSelection)
                    return;
                if (!confirmIfUnsavedChanges())
                {
                    revertComboBoxSelection(paySchedulesComboBox, previouslySelectedPayScheduleIndex);
                    return;
                }
                previouslySelectedPayScheduleIndex = paySchedulesComboBox.SelectedIndex;
                selectPaySchedule();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void workersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (revertingSelection)
                    return;
                if (!confirmIfUnsavedChanges())
                {
                    revertComboBoxSelection(workersComboBox, previouslySelectedWorkerIndex);
                    return;
                }
                changeTrackerControl();
                selectWorker();
                setPeriod(DateTime.Today);
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
                if (!confirmIfUnsavedChanges())
                    return;
                previousPeriod();
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
                if (!confirmIfUnsavedChanges())
                    return;
                nextPeriod();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void saveTrackingEntriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveTrackingEntries();
                showSelectedPeriod();
                showStatus(i18n.Placeholder("Seguimiento guardado"));
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void trackingChanged(object sender, EventArgs e)
        {
            try
            {
                unsavedChanges = true;
                showStatus(i18n.Placeholder("Cambios sin guardar"));
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void TrackWorkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            showStatus(i18n.Placeholder("Saliendo"));
            e.Cancel = !confirmIfUnsavedChanges();
            if (e.Cancel)
                showStatus(i18n.Placeholder("Cancelado"));
        }
    }
}
