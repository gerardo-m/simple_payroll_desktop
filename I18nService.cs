using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;

namespace simple_payroll_desktop
{
    public class I18nService
    {

        private readonly IStringLocalizer<I18nService> stringLocalizer;

        public I18nService(IStringLocalizer<I18nService> stringLocalizer)
        {
            this.stringLocalizer = stringLocalizer;
        }

        public string Form1_trackWorkButton()
        {
            return stringLocalizer.GetString("Form1_trackWorkButton");
        }
    }
}
