using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_payroll_desktop.entities;
using simple_payroll_desktop.dao;

namespace simple_payroll_desktop.business
{
    public class WorkersManager
    {
        private readonly I18nService i18n;
        private readonly WorkerDAO workerDAO;
        private readonly PayrollDAO payrollDAO;
        private readonly TrackingEntryDAO trackingEntryDAO;

        public WorkersManager(I18nService i18n,
                              WorkerDAO workerDAO,
                              PayrollDAO payrollDAO,
                              TrackingEntryDAO trackingEntryDAO)
        {
            this.i18n = i18n;
            this.workerDAO = workerDAO;
            this.payrollDAO = payrollDAO;
            this.trackingEntryDAO = trackingEntryDAO;
        }

        public IList<Worker> allWorkers()
        {
            return workerDAO.allWorkers();
        }

        public IList<Worker> workersWithPaySchedule(int payScheduleId)
        {
            return workerDAO.workersWithPaySchedule(payScheduleId);
        }

        public void saveWorker(Worker worker)
        {
            if (worker.Id == 0)
            {
                workerDAO.saveWorker(worker);
            }
            else
            {
                workerDAO.updateWorker(worker);
            }
        }

        public void deleteWorker(Worker worker)
        {
            if (canDelete(worker))
            {
                deleteRelatedData(worker);
                workerDAO.deleteWorker(worker);
            }
            else
            {
                throw new InvalidOperationException(i18n.Placeholder("The employee can't be deleted, because it has already closed payrolls"));
            }
        }

        public bool canDelete(Worker worker)
        {
            return payrollDAO.getClosedPayrollCount(worker.Id) == 0;
        }

        private void deleteRelatedData(Worker worker)
        {
            IList<TrackingEntry> trackingEntries = trackingEntryDAO.getTrackingEntries(worker.Id);
            foreach (TrackingEntry trackingEntry in trackingEntries)
                trackingEntryDAO.deleteTrackingEntry(trackingEntry);
            IList<Payroll> payrolls = payrollDAO.getPayrollsByWorker(worker.Id);
            foreach (Payroll payroll in payrolls)
                payrollDAO.deletePayroll(payroll);
        }
    }
}
