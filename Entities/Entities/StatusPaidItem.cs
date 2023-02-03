using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class StatusPaidItem

       
    {
        public StatusPaidItem() { }
        public int Id { get; set; }
        public string Slope { get; set; }
        public string InProcess { get; set; }
        public string Paid { get; set; }
    }
}
