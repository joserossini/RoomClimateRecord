using RoomClimateRecord.API.Models;

namespace RoomClimateRecord.API.Services
{
    public interface IRecordService
    {
        public IQueryable<Record> GetAllRecordData ();
        public ValueTask<Record> PostRecord (Record record);
        
    }
}