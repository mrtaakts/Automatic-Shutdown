using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Shutdown.Models
{
    public class ValidationModel
    {
        public bool Status { get; set; } = false;
        public string ErrorMessage { get; set; }
    }
}
