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
        private readonly PaySchedulesForm paySchedulesForm;
        private readonly TrackWorkForm trackWorkForm;
        public Form1(ILogger<Form1> logger,
                     I18nService i18n,
                     WorkersForm workersForm,
                     PaySchedulesForm paySchedulesForm,
                     TrackWorkForm trackWorkForm)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.workersForm = workersForm;
            this.paySchedulesForm = paySchedulesForm;
            this.trackWorkForm = trackWorkForm;
            InitializeComponent();
        }

        private void loadStrings()
        {
            trackWorkButton.Text = i18n.Form1_Controls(trackWorkButton.Name);
            generatePayrollButton.Text = i18n.Form1_Controls(generatePayrollButton.Name);
            manageWorkersButton.Text = i18n.Form1_Controls(manageWorkersButton.Name);
            managePaySchedulesButton.Text = i18n.Form1_Controls(managePaySchedulesButton.Name);
            exitButton.Text = i18n.Form1_Controls(exitButton.Name);
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
            this.Visible = false;
            paySchedulesForm.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadStrings();
        }
    }
}
