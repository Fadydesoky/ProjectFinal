using Microsoft.EntityFrameworkCore;

public class AttendanceContext : DbContext
{
    public DbSet<Learner> Learners { get; set; }
    public DbSet<SessionLog> SessionLogs { get; set; }

    public AttendanceContext(DbContextOptions<AttendanceContext> options) : base(options) { }
    public static void Seed(AttendanceContext context)
    {
        if (!context.Learners.Any())
        {
            context.Learners.AddRange(
              new Learner { Name = "Ali", Age = 25, DateOfBirth = DateTime.Now.AddYears(-25) },
              new Learner { Name = "Sara", Age = 22, DateOfBirth = DateTime.Now.AddYears(-22) }
            );
            context.SaveChanges();
        }
    }
}
