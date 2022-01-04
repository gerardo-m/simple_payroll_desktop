﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_payroll_desktop.entities
{
    public class PaySlip
    {
        public int Id { get; set; }
        public string WorkerCI { get; set; }
        public string WorkerFullName { get; set; }
        public string TrackedWorkConcept { get; set; }
        public decimal TrackedWorkAmount { get; set; }
        public decimal PayrollTotal { get; set; }
        public decimal PreviouslyPaid { get; set; }
        public decimal Amount { get; set; }
        public decimal ToBePaid { 
            get
            {
                return PayrollTotal - PreviouslyPaid - Amount;
            }
        }

        public IList<Additional> Additionals { get; set; }
        public Payroll Payroll { get; set; }
    }
}