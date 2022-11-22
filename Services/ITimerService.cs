using Automatic_Shutdown.Models;
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
    }
}
