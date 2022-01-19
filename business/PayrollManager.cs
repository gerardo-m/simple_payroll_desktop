using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;
using simple_payroll_desktop.dao;
using simple_payroll_desktop.business.payrolls;

namespace simple_payroll_desktop.business
{
    public class PayrollManager
    {

        private readonly I18nService i18n;
        private PayrollDAO payrollDAO;
        private TrackingEntryDAO trackingEntryDAO;
        private ExtraDAO extraDAO;

        private PayrollCalculator payrollCalculator;

        public PayrollManager(I18nService i18n, PayrollDAO payrollDAO, TrackingEntryDAO trackingEntryDAO, ExtraDAO extraDAO)
        {
            this.i18n = i18n;
            this.payrollDAO = payrollDAO;
            this.trackingEntryDAO = trackingEntryDAO;
            this.extraDAO = extraDAO;
            this.payrollCalculator = new PayrollCalculator();
        }

        public Payroll getPayroll(Worker worker, PayPeriod period)
        {
            Payroll payroll = payrollDAO.getPayrollByPeriod(worker.Id, period);
            if (payroll == null)
                payroll = buildPayroll(worker, period);
            if (payroll.Status == PayrollStatus.Open)
                payroll = payrollCalculator.calculate(payroll);
            IList<Extra> extras = extraDAO.getExtras(payroll.Id);
            payroll.Extras = extras;
            return payroll;
        }

        private Payroll buildPayroll(Worker worker, PayPeriod period)
        {
            Payroll payroll = new Payroll();
            payroll.Id = 0;
            payroll.Extras = new List<Extra>();
            payroll.Date = DateTime.Today.Date;
            payroll.PayRate = worker.PayRate;
            payroll.PayRateType = worker.PayRateType;
            payroll.PaySchedule = worker.PaySchedule;
            payroll.PayScheduleType = worker.PaySchedule.Type;
            payroll.PeriodStart = period.PeriodStart;
            payroll.PeriodEnd = period.PeriodEnd;
            payroll.Status = PayrollStatus.Open;
            payroll.Worker = worker;
            payroll.TrackingEntries = trackingEntryDAO.getTrackingEntries(worker.Id, period.PeriodStart, period.PeriodEnd);
            return payroll;
        }

        public void savePayroll(Payroll payroll)
        {
            if (payroll.Id == 0)
                payrollDAO.savePayroll(payroll);
            else
                payrollDAO.updatePayroll(payroll);
            saveExtras(payroll);
        }

        public string getTrackedTimeLocalizedDetails(Payroll payroll)
        {
            // TODO get the actual localized strings
            decimal time = payroll.TrackedTime;
            string payRateType = payRateTypeString(payroll.PayRateType);
            return  $"{time} {payRateType}";
        }

        private void saveExtras(Payroll payroll)
        {
            foreach (Extra extra in payroll.Extras)
                if (extra.Id == 0)
                    extraDAO.saveExtra(extra);
                else
                    extraDAO.updateExtra(extra);
        }

        private string payRateTypeString(PayRateType payRateType)
        {
            switch (payRateType)
            {
                case PayRateType.Hourly:
                    return "Horas trabajadas";
                case PayRateType.Daily:
                    return "Días trabajados";
                case PayRateType.Weekly:
                    return "Semanas trabajadas";
                case PayRateType.Monthly:
                    return "Meses trabajados";
                case PayRateType.FixedPay:
                    return "Contrato completado";
                default:
                    return "";
            }
        }
    }
}
