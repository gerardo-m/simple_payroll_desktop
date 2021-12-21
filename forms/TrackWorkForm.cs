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
            InitializeComponent();
        }

        private void changeTrackerControl()
        {
            if (trackerControl != null)
                trackingBoxPanel.Controls.Remove(trackerControl);
            TrackerControlSelector controlSelector = new TrackerControlSelector();
            trackerControl =  controlSelector.getTrackerControl(selectedPaySchedule.TrackingType, logger, i18n);
            trackingBoxPanel.Controls.Add(trackerControl);
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
            paySchedulesComboBox.DataSource = paySchedulesManager.allPaySchedules();
            selectPaySchedule();
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
        }

        private void TrackWorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void TrackWorkForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadPaySchedules();
                changeTrackerControl();
                setPeriod(DateTime.Today);
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
                selectPaySchedule();
                //setPeriod(DateTime.Today);
                //changeTrackerControl();
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
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }
    }
}
