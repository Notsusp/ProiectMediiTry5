using System.Security.Policy;

namespace ProiectMediiTry5.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public int? DepartmentID { get; set; }
        public Department? Department { get; set; }
        public int? ProjectID { get; set; }
        public Project? Project { get; set; }
    }
}
