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
    public partial class DenominationsForm : Form
    {

        private readonly ILogger logger;
        private readonly I18nService i18n;
        private readonly DenominationsManager denominationsManager;


        private Denomination currentDenomination;
        public DenominationsForm(ILogger<DenominationsForm> logger, 
                                 I18nService i18n,
                                 DenominationsManager denominationsManager)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.denominationsManager = denominationsManager;
            InitializeComponent();
        }

        private void handleException(Exception ex)
        {
            logger.LogError(ex.Message);
            logger.LogTrace(ex, ex.Message);
            MessageBox.Show(ex.Message);
            throw ex;
        }

        private void loadStrings()
        {
            nameLabel.Text = i18n.DenominationsForm_Controls(nameLabel.Name);
            newDenominationButton.Text = i18n.DenominationsForm_Controls(newDenominationButton.Name);
            saveDenominationButton.Text = i18n.DenominationsForm_Controls(saveDenominationButton.Name, "Save");
            deleteDenominationButton.Text = i18n.DenominationsForm_Controls(deleteDenominationButton.Name);
            Text = i18n.DenominationsForm_Controls("title");
        }

        private void initializeListBox() 
        {
            denominationsListBox.DisplayMember = "Name";
            denominationsListBox.ValueMember = "Id";
            updateDenominationsListBox();
        }

        private void saveCurrentDenomination()
        {
            if (currentDenomination != null)
            {
                denominationsManager.saveDenomination(currentDenomination);
                updateDenominationsListBox();
            }
        }

        private void updateDenominationsListBox()
        {
            denominationsListBox.DataSource = denominationsManager.allDenominations();
        }

        private void captureCurrentDenomination()
        {
            currentDenomination.Name = nameTextBox.Text;
        }


        private void deleteCurrentDenomination()
        {
            if (currentDenomination != null)
            {
                denominationsManager.deleteDenomination(currentDenomination);
                updateDenominationsListBox();
            }
        }

        private void updateControlsStates()
        {
            if (denominationsListBox.SelectedIndex == -1)
            {
                deleteDenominationButton.Enabled = false;
                saveDenominationButton.Text = i18n.DenominationsForm_Controls(saveDenominationButton.Name, "Save"); ;
            }
            else
            {
                deleteDenominationButton.Enabled = true;
                saveDenominationButton.Text = i18n.DenominationsForm_Controls(saveDenominationButton.Name, "Update"); ;
            }
        }

        private void switchToUnselectedState()
        {
            currentDenomination = new Denomination();
            denominationsListBox.SelectedIndex = -1;
            nameTextBox.Text = "";
        }

        private void switchToSelectedState(Denomination selectedDenomination)
        {
            currentDenomination = selectedDenomination;
            if (currentDenomination != null)
            {
                nameTextBox.Text = currentDenomination.Name;
            }
        }


        private void newDenominationButton_Click(object sender, EventArgs e)
        {
            try
            {
                switchToUnselectedState();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void DenominationsForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadStrings();
                initializeListBox();
                switchToUnselectedState();
                updateControlsStates();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void saveDenominationButton_Click(object sender, EventArgs e)
        {
            try
            {
                captureCurrentDenomination();
                saveCurrentDenomination();
                switchToUnselectedState();
                updateControlsStates();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void deleteDenominationButton_Click(object sender, EventArgs e)
        {
            try
            {
                deleteCurrentDenomination();
                switchToUnselectedState();
                updateControlsStates();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void denominationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (denominationsListBox.SelectedIndex != -1)
            {
                switchToSelectedState((Denomination)denominationsListBox.SelectedItem);
                updateControlsStates();
            }
        }
    }
}
