using System.ComponentModel.DataAnnotations;

namespace CoreApiDemo.DataAccsessLayer
{
    public class Employer
    {
        [Key]
        public int EmployerID { get; set; }
        public int EmployerName { get; set; }
        public int EmoloyerSurname { get; set; }
    }
}
