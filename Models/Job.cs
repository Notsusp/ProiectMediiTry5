namespace ProiectMediiTry5.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public DateTime TermenLimita { get; set; }
        public bool Finalizat { get; set; }
    }
}
