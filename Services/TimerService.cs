using Automatic_Shutdown.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Shutdown.Services
{
    public class TimerService : ITimerService
    {
        public ValidationModel CheckTimerVariables(string hour, string minute, string second)
        {
            // saat en fazla 24 , en az 0 olabilir
            // diğerleri en fazla 60, en az 0 olabilir.
            // is not or empty olamaz.
            // is numericler mi?

            ValidationModel model = new ValidationModel();

            if (string.IsNullOrEmpty(hour))
            {
                model.ErrorMessage = "Saat boş bırakılamaz";
                return model;
            }
            else if (string.IsNullOrEmpty(minute))
            {
                model.ErrorMessage = "Dakika boş bırakılamaz";
                return model;
            }
            else if (string.IsNullOrEmpty(second))
            {
                model.ErrorMessage = "Saniye boş bırakılamaz";
                return model;
            }
            else if (!int.TryParse(hour, out int inthour))
            {
                model.ErrorMessage = "Saat bir sayı olmalı";
                return model;
            }
            else if (!int.TryParse(minute, out int intminute))
            {
                model.ErrorMessage = "Dakika bir sayı olmalı";
                return model;
            }
            else if (!int.TryParse(second, out int intsecond))
            {
                model.ErrorMessage = "Saniye bir sayı olmalı";
                return model;
            }

            else if (inthour > 24 || inthour < 0)
            {
                model.ErrorMessage = "Saat 0 ile 24 arasında bir değer olmalı";
                return model;
            }
            else if (intminute > 60 || intminute < 0)
            {
                model.ErrorMessage = "Dakika 0 ile 60 arasında bir değer olmalı";
                return model;
            }
            else if (intsecond > 60 || intsecond < 0)
            {
                model.ErrorMessage = "Saniye 0 ile 60 arasında bir değer olmalı";
                return model;
            }
            model.Status = true;
            return model;
        }

        public void Hibernate()
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
            Application.Exit();
        }
        public void Shutdown()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);

            Application.Exit();
        }

        public void Suspend()
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
            Application.Exit();
        }

        public void SelectProcess(string processName)
        {
            if (processName == "Shutdown")
            {
                Shutdown();
                Application.Exit();
            }
            else if (processName == "Hibernate")
            {
                Hibernate();
                Application.Exit();

            }
            else if (processName == "Suspend")
            {
                Suspend();
                Application.Exit();
            }

        }
    }
}
