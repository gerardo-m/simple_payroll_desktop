using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using simple_payroll_desktop.forms;
using Microsoft.Extensions.Logging;

namespace simple_payroll_desktop
{
    public partial class Form1 : Form
    {

        private readonly ILogger logger;
        private readonly I18nService i18n;

        private readonly WorkersForm workersForm;
        public Form1(ILogger<Form1> logger,
                     I18nService i18n,
                     WorkersForm workersForm)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.workersForm = workersForm;
            InitializeComponent();
        }

        private void manageWorkersButton_Click(object sender, EventArgs e)
        {
            logger.LogInformation("[Form1] Manage Workers clicked");
            this.Visible = false;
            workersForm.ShowDialog(this);
        }

        private void trackWorkButton_Click(object sender, EventArgs e)
        {
            logger.LogInformation("[Form1] Track Work clicked");
            TrackWorkForm trackWorkForm = new TrackWorkForm();
            this.Visible = false;
            trackWorkForm.ShowDialog(this);
        }

        private void generatePayrollButton_Click(object sender, EventArgs e)
        {
            logger.LogInformation("[Form1] Generate Payroll clicked");
            GeneratePayrollForm generatePayrollForm = new GeneratePayrollForm();
            this.Visible = false;
            generatePayrollForm.ShowDialog(this);
        }

        private void managePaySchedulesButton_Click(object sender, EventArgs e)
        {
            logger.LogInformation("[Form1] Manage Pay Schedules clicked");
            PaySchedulesForm managePaySchedulesForm = new PaySchedulesForm();
            this.Visible = false;
            managePaySchedulesForm.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackWorkButton.Text = i18n.Form1_trackWorkButton();
        }
    }
}
