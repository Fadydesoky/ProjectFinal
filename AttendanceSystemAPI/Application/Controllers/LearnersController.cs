using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class LearnersController(AttendanceContext context) : ControllerBase
{
    private readonly AttendanceContext _context = context;

    [HttpGet]
    public IActionResult GetLearners()
    {
#pragma warning disable CS8604 // Possible null reference argument.
        return Ok(_context.Learners.ToList());
#pragma warning restore CS8604 // Possible null reference argument.
    }

    [HttpPost]
    public IActionResult AddLearner([FromBody] Learner learner)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        _ = _context.Learners.Add(learner);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        _ = _context.SaveChanges();
        return CreatedAtAction(nameof(GetLearners), new { id = learner.Id }, learner);
    }
}
