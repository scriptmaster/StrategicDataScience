using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategicDataScience.Models
{
    interface ICSVModel
    {
        public string UserId { get; set; }
        public string TestName { get; set; }
    }
}
