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
        private readonly ILogger logger;
        private readonly I18nService i18n;
        public DaysDayWeekTrackerControl(ILogger logger,
                                         I18nService i18n, 
                                         List<TrackingEntry> trackingEntries) : base(trackingEntries)
        {
            this.logger = logger;
            this.i18n = i18n;
            InitializeComponent();
            if (trackingEntries.Count == 7)
                loadTrackingEntries();
            else
                throw new ArgumentException("Must send exactly 7 tracking entries");
        }

        private void loadTrackingEntries()
        {
            trackingEntries.Sort((e1, e2) => e1.Date.CompareTo(e2.Date));
            day1Label.Text = trackingEntries[0].Date.ToString("dddd MMMM dd");
            day2Label.Text = trackingEntries[1].Date.ToString("dddd MMMM dd");
            day3Label.Text = trackingEntries[2].Date.ToString("dddd MMMM dd");
            day4Label.Text = trackingEntries[3].Date.ToString("dddd MMMM dd");
            day5Label.Text = trackingEntries[4].Date.ToString("dddd MMMM dd");
            day6Label.Text = trackingEntries[5].Date.ToString("dddd MMMM dd");
            day7Label.Text = trackingEntries[6].Date.ToString("dddd MMMM dd");
            applyValue(day1CheckBox, trackingEntries[0].TrackingValue);
            applyValue(day2CheckBox, trackingEntries[1].TrackingValue);
            applyValue(day3CheckBox, trackingEntries[2].TrackingValue);
            applyValue(day4CheckBox, trackingEntries[3].TrackingValue);
            applyValue(day5CheckBox, trackingEntries[4].TrackingValue);
            applyValue(day6CheckBox, trackingEntries[5].TrackingValue);
            applyValue(day7CheckBox, trackingEntries[6].TrackingValue);
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
                    trackingEntries[0].TrackingValue = 0.5M;
                else
                    trackingEntries[0].TrackingValue = 1;
            else
                trackingEntries[0].TrackingValue = 0;
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
