namespace Les2EFMVC.Models
{
    public class Team
    {

        public int Id { get; set; }
        public string Group { get; set; } = null!;
        public string Title { get; set; } = null!;

        public ICollection<Member> Enrolled { get; } = new List<Member>();
    }
}
