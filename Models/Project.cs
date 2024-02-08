namespace ProiectMediiTry5.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<Job>? Jobs { get; set; }

    }
}
