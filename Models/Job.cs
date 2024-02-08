using System.Security.Policy;

namespace ProiectMediiTry5.Models
{
    public class Job
    {
        public int ID { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public DateTime TermenLimita { get; set; }
        public bool Finalizat { get; set; }
        public int? ProjectID { get; set; }
        public Project? Project { get; set; }
    }
}
