using Automatic_Shutdown.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Shutdown.Services
{
    public interface ITimerService
    {
        public ValidationModel CheckTimerVariables(string hour, string minute, string second);
        public void Shutdown();
        public void Hibernate();
        public void Suspend();
        public void SelectProcess(string processName);
        (TimeSpan, double) CountDown(TimeSpan span, ProgressBar bar, double passingsecond, double closingsecond, MaterialLabel label);
    }
}
