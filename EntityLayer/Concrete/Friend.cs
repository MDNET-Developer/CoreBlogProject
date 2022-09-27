using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Friend
    {
        [Key]
        public int DostluqID { get; set; }
        public string Gonderen { get; set; }
        public string Alan { get; set; }
        public bool Veziyyet { get; set; }
    }
}
