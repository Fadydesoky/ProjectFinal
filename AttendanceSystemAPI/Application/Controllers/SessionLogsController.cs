using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class SessionLogsController(AttendanceContext context) : ControllerBase
{
    private readonly AttendanceContext _context = context;

    [HttpGet]
    public IActionResult GetLogs()
    {
#pragma warning disable CS8604 // Possible null reference argument.
        return Ok(_context.SessionLogs.ToList());
#pragma warning restore CS8604 // Possible null reference argument.
    }

    [HttpPost]
    public IActionResult AddLog([FromBody] SessionLog log)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        _ = _context.SessionLogs.Add(log);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        _ = _context.SaveChanges();
        return CreatedAtAction(nameof(GetLogs), new { id = log.Id }, log);
    }
}
