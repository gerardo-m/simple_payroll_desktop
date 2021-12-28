using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using simple_payroll_desktop.forms;
using simple_payroll_desktop.business;
using simple_payroll_desktop.dao;
using simple_payroll_desktop.local_dao;
using simple_payroll_desktop.entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Localization;


namespace simple_payroll_desktop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DbContext.up();
            CultureInfo.CurrentCulture = CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("es");
            var services = new ServiceCollection();
            configureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form);
            }
        }

        private static void configureServices(ServiceCollection services)
        {
            services.AddSingleton<Form1>()
                    .AddLogging((configure) => configure.AddDebug())
                    .AddLocalization(options =>
                    {
                        options.ResourcesPath = "resources";
                    })
                    .AddSingleton<I18nService>()
                    //FORMS
                    .AddSingleton<WorkersForm>()
                    .AddSingleton<PaySchedulesForm>()
                    .AddSingleton<DenominationsForm>()
                    .AddSingleton<TrackWorkForm>()
                    .AddSingleton<GeneratePayrollForm>()
                    //BUSINESS
                    .AddSingleton<DenominationsManager>()
                    .AddSingleton<PaySchedulesManager>()
                    .AddSingleton<WorkersManager>()
                    .AddSingleton<TrackingEntriesManager>()
                    .AddSingleton<PayrollManager>()
                    //DAO
                    .AddSingleton<DenominationDAO, DenominationDAOLocal>()
                    .AddSingleton<PayScheduleDAO, PayScheduleDAOLocal>()
                    .AddSingleton<WorkerDAO, WorkerDAOLocal>()
                    .AddSingleton<TrackingEntryDAO, TrackingEntryDAOLocal>()
                    .AddSingleton<PayrollDAO, PayrollDAOLocal>();
        }
    }
}
