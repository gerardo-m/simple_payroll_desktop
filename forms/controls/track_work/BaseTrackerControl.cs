using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using simple_payroll_desktop.entities;

namespace simple_payroll_desktop.forms.controls.track_work
{
    public partial class BaseTrackerControl : UserControl
    {
        protected IList<TrackingEntry> trackingEntries;
        public BaseTrackerControl()
        {
            InitializeComponent();
        }

        public IList<TrackingEntry> GetTrackingEntries()
        {
            return trackingEntries;
        }
    }
}
