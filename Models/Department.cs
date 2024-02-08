using System.ComponentModel.DataAnnotations;

namespace ProiectMediiTry5.Models
{
    public class Department
    {
        public int ID { get; set; }
        [Display(Name = "Department Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
