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
        private readonly DenominationsManager denominationsManager;


        private Denomination currentDenomination;
        public DenominationsForm(ILogger<DenominationsForm> logger, DenominationsManager denominationsManager)
        {
            this.logger = logger;
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
                saveDenominationButton.Text = "Guardar";
            }
            else
            {
                deleteDenominationButton.Enabled = true;
                saveDenominationButton.Text = "Actualizar";
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
                //denominationsManager = DenominationsManager.getInstance();
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
