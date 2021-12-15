using RoomClimateRecord.API.Brokers;
using RoomClimateRecord.API.Models;

namespace RoomClimateRecord.API.Services
{
    public partial class RecordService : IRecordService
    {
        private readonly IStorageBroker storageBroker;
        private readonly RecordValidator recordValidator;
        
        public RecordService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
            this.recordValidator = new RecordValidator();
        }

        public IQueryable<Record> GetAllRecordData()
        {
            return this.storageBroker.GetAllRecords().AsQueryable();
        }
        public ValueTask<Record> PostRecord(Record record)
        {
            if(this.recordValidator.Validate(record).IsValid)
            {
                var returnRecord = this.storageBroker.InsertRecordAsync(record);
                return returnRecord;
            }
            else
                throw new NotImplementedException("Not Implemmender Exception");
        }
    }
}