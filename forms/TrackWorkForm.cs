﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_payroll_desktop.forms
{
    public partial class TrackWorkForm : Form
    {
        public TrackWorkForm()
        {
            InitializeComponent();
        }

        private void TrackWorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
