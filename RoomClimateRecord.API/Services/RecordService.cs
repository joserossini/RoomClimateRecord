using RoomClimateRecord.API.Brokers;
using RoomClimateRecord.API.Models;

namespace RoomClimateRecord.API.Services
{
    public class RecordService : IRecordService
    {
        private readonly IStorageBroker storageBroker;
        
        public RecordService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public IEnumerable<Record> GetAllRecordData()
        {
            throw new NotImplementedException();
        }
    }
}