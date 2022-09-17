using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notifcation
    {
        [Key]
        public int NotifcationID { get; set; }
        public string NotifcationType { get; set; }
        public string NotifcationTypeSymbol { get; set; }
        public string NotifcationDetails { get; set; }
        public DateTime NotifcationDateTime{ get; set; }
        public bool NotifcationStatus { get; set; }
    }
}
