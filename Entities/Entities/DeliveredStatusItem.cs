using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class DeliveredStatusItem
    {
        public DeliveredStatusItem() { }
        public int Id { get; set; }
        public string CreatedOrder { get; set; }
        public string InProcess { get; set; }
        public string Status { get; set; }
        public string Transit { get; set; }
        public string Delivered { get; set; }
        public DateTime CreatedDate { get; set;}
    }
}
