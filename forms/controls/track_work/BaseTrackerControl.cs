﻿using System;
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
        protected List<TrackingEntry> trackingEntries;
        public BaseTrackerControl(List<TrackingEntry> trackingEntries)
        {
            this.trackingEntries = trackingEntries;
            InitializeComponent();
        }

        public List<TrackingEntry> GetTrackingEntries()
        {
            return trackingEntries;
        }
    }
}