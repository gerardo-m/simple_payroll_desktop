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
        private DaysDayWeekTrackerControl trackerControl;
        public TrackWorkForm(ILogger<TrackWorkForm> logger,
                             I18nService i18n,
                             PaySchedulesManager paySchedulesManager,
                             WorkersManager workersManager)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.paySchedulesManager = paySchedulesManager;
            this.workersManager = workersManager;
            InitializeComponent();
            trackerControl = new DaysDayWeekTrackerControl();
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
        }

        private void loadWorkers()
        {
            PaySchedule selectedPaySchedule = (PaySchedule)paySchedulesComboBox.SelectedItem;
            workersComboBox.DataSource = workersManager.workersWithPaySchedule(selectedPaySchedule.Id);
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
                loadWorkers();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
            
        }
    }
}
