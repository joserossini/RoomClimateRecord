using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using RoomClimateRecord.API.Models;
using RoomClimateRecord.API.Services;

namespace RoomClimateRecord.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecordController : ControllerBase
{

    public readonly IRecordService recordService;

    public RecordController(IRecordService recordService)
    {
        this.recordService = recordService;
    }

    [HttpGet]
    [EnableQuery]
    public ActionResult<IQueryable<Record>> GetRecords()
    {
        IQueryable<Record> result = recordService.GetAllRecordData();        
        return Ok(result);
    }

    [HttpPost]
    public async ValueTask<ActionResult<Record>> PostRecord([FromBody]Record record)
    {
        try
        {
            Record processRecord =  await this.recordService.PostRecord(record);
            return Ok(processRecord);
        }
        catch(NotImplementedException ex)
        {
            return Problem(ex.Message);
        }
    }

}
