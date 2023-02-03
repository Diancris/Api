using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class RolesItem : UserItem
    {
        public RolesItem() { }
        public int Id { get; set; }
        public string Admin { get; set; }
        public string Comprador { get; set; }
        public string Support { get; set; }
        
    }
}
