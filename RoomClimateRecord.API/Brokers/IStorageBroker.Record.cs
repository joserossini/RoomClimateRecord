using RoomClimateRecord.API.Models;

namespace RoomClimateRecord.API.Brokers
{
    public partial interface IStorageBroker
    {
        IQueryable<Record> GetAllRecords();
        ValueTask<Record> GetRecordAsync(Guid Id);
        ValueTask<Record> InsertRecordAsync(Record device);

    }
}