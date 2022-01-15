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

        public event EventHandler TrackingValuesChanged;

        public IList<TrackingEntry> GetTrackingEntries()
        {
            return trackingEntries;
        }

        public virtual void setTrackingEntries(IList<TrackingEntry> trackingEntries)
        {
            this.trackingEntries = trackingEntries;
            loadTrackingEntries();
        }

        public virtual void loadTrackingEntries()
        {
            throw new NotImplementedException("Must implement this method loadTrackingEntries");
        }

        protected void HandleTrackingValuesChanged(object sender, EventArgs e)
        {
            OnTrackingValuesChanged(EventArgs.Empty);
        }

        protected virtual void OnTrackingValuesChanged(EventArgs e)
        {
            EventHandler handler = TrackingValuesChanged;
            if (handler != null)
                handler(this, e);
        }
    }
}
