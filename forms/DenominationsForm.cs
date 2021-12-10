using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using simple_payroll_desktop.business;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.forms
{
    public partial class DenominationsForm : Form
    {

        private DenominationsManager denominationsManager;
        private Denomination currentDenomination;
        public DenominationsForm()
        {
            InitializeComponent();
        }

        private void handleException(Exception ex)
        {
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
                changeCurrentDenomination(new Denomination());
            }
        }

        private void changeCurrentDenomination(Denomination denomination)
        {
            currentDenomination = denomination;
            loadCurrentDenomination();
        }

        private void loadCurrentDenomination()
        {
            if (currentDenomination == null)
            {
                nameTextBox.Text = "";
            }
            else
            {
                nameTextBox.Text = currentDenomination.Name;
                if (currentDenomination.Id == 0)
                {
                    denominationsListBox.SelectedIndex = -1;
                }
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
                changeCurrentDenomination(new Denomination());
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


        private void newDenominationButton_Click(object sender, EventArgs e)
        {
            try
            {
                changeCurrentDenomination(new Denomination());
                updateControlsStates();
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
                denominationsManager = DenominationsManager.getInstance();
                initializeListBox();
                changeCurrentDenomination(new Denomination());
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
                changeCurrentDenomination((Denomination)denominationsListBox.SelectedItem);
                updateControlsStates();
            }
        }
    }
}
