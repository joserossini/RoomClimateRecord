using RoomClimateRecord.API.Models;

namespace RoomClimateRecord.API.Services
{
    public interface IRecordService
    {
        public IEnumerable<Record> GetAllRecordData ();
        
    }
}