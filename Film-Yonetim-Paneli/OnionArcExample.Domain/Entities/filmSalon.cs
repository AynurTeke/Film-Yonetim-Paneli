using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Domain.Entities
{
    public class filmSalon
    {
        public int filmSalonID { get; set; }
        public int filmID { get; set; }
        public int salonID { get; set; }
        public film? film { get; set; }
        public salon? salon { get; set; }

    }
}
