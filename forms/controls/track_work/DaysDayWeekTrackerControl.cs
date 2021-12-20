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

namespace simple_payroll_desktop.forms.controls.track_work
{
    public partial class DaysDayWeekTrackerControl : BaseTrackerControl
    {

        private const string dateFormat = "ddd MMMM dd";
        private readonly ILogger logger;
        private readonly I18nService i18n;

        private List<Label> labels = new List<Label>();
        private List<CheckedListBox> checkedListBoxes = new List<CheckedListBox>();

        public DaysDayWeekTrackerControl(ILogger logger,
                                         I18nService i18n, 
                                         IList<TrackingEntry> trackingEntries)
        {
            this.logger = logger;
            this.i18n = i18n;
            this.trackingEntries = trackingEntries;
            InitializeComponent();
            initializeControlLists();
            if (trackingEntries.Count > 0)
                loadTrackingEntries();
            else
                throw new ArgumentException("Must send at least 1 entry");
        }

        private void initializeControlLists()
        {
            labels.Add(day1Label);
            labels.Add(day2Label);
            labels.Add(day3Label);
            labels.Add(day4Label);
            labels.Add(day5Label);
            labels.Add(day6Label);
            labels.Add(day7Label);
            checkedListBoxes.Add(day1CheckBox);
            checkedListBoxes.Add(day2CheckBox);
            checkedListBoxes.Add(day3CheckBox);
            checkedListBoxes.Add(day4CheckBox);
            checkedListBoxes.Add(day5CheckBox);
            checkedListBoxes.Add(day6CheckBox);
            checkedListBoxes.Add(day7CheckBox);
        }

        private void loadTrackingEntries()
        {
            trackingEntries = new List<TrackingEntry>(trackingEntries);
            ((List<TrackingEntry>)trackingEntries).Sort((e1, e2) => e1.Date.CompareTo(e2.Date));
            for (int i = 0; i < 7; i++)
                if (i < trackingEntries.Count)
                    loadTrackingEntry(i);
                else
                    disableTrackingEntryControl(i);
        }

        private void disableTrackingEntryControl(int index)
        {
            labels[index].Text = "";
            checkedListBoxes[index].SetItemChecked(0, false);
            checkedListBoxes[index].SetItemChecked(1, false);
            checkedListBoxes[index].Enabled = false;
        }

        private void loadTrackingEntry(int index)
        {
            labels[index].Text = trackingEntries[index].Date.ToString(dateFormat);
            checkedListBoxes[index].Enabled = true;
            applyValue(checkedListBoxes[index], trackingEntries[index].TrackingValue);
        }

        private void applyValue(CheckedListBox checkBox, decimal value)
        {
            if (value == 0)
            {
                checkBox.SetItemChecked(0, false);
                checkBox.SetItemChecked(1, false);
            }else if (value == 0.5M)
            {
                checkBox.SetItemChecked(0, true);
                checkBox.SetItemChecked(1, false);
            }else if (value == 1)
            {
                checkBox.SetItemChecked(0, false);
                checkBox.SetItemChecked(1, true);
            }
        }

        private void uniqueSelectionForCheckBox(CheckedListBox checkedListBox, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < checkedListBox.Items.Count; ++ix)
                    if (ix != e.Index) checkedListBox.SetItemChecked(ix, false);
        }

        private void changeTrackingEntryValue(int index, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                if (e.Index == 0)
                    trackingEntries[index].TrackingValue = 0.5M;
                else
                    trackingEntries[index].TrackingValue = 1;
            else
                trackingEntries[index].TrackingValue = 0;
        }

        private void day1CheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            uniqueSelectionForCheckBox(day1CheckBox, e);
            changeTrackingEntryValue(0, e);
        }

        private void day2CheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            uniqueSelectionForCheckBox(day2CheckBox, e);
            changeTrackingEntryValue(1, e);
        }

        private void day3CheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            uniqueSelectionForCheckBox(day3CheckBox, e);
            changeTrackingEntryValue(2, e);
        }

        private void day4CheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            uniqueSelectionForCheckBox(day4CheckBox, e);
            changeTrackingEntryValue(3, e);
        }

        private void day5CheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            uniqueSelectionForCheckBox(day5CheckBox, e);
            changeTrackingEntryValue(4, e);
        }

        private void day6CheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            uniqueSelectionForCheckBox(day6CheckBox, e);
            changeTrackingEntryValue(5, e);
        }

        private void day7CheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            uniqueSelectionForCheckBox(day7CheckBox, e);
            changeTrackingEntryValue(6, e);
        }
    }
}
