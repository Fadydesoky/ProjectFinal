public class SessionLog
{
    public int Id { get; set; }
    public int LearnerId { get; set; }
    public DateTime SessionDate { get; set; }
    public string ?SessionDetails { get; set; }

    public Learner ?Learner { get; set; }
}
