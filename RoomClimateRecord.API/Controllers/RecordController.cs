using Microsoft.AspNetCore.Mvc;
using RoomClimateRecord.API.Models;

namespace RoomClimateRecord.API.Controllers;

[ApiController]
[Route("[controller]")]
public class RecordController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Record> Get()
    {
        return new Record[] {
            new Record {Id = new Guid(), Temperature = 50f, Motion = false },
            new Record {Id = new Guid(), Temperature = 51f, Motion = false }
        };
    }
}
