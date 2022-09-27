using System.ComponentModel.DataAnnotations;

namespace Core_Api_Demo.DataAccsessLayer
{
    public class Isciler
    {
        [Key]
        public int IsciID { get; set; }
        public string IsciAd { get; set; }
        public string IsciSoyad { get; set; }
    }
}
