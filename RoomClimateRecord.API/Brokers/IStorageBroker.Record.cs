using RoomClimateRecord.API.Models;

namespace RoomClimateRecord.API.Brokers
{
    public partial interface IStorageBroker
    {
        IQueryable<Record> SelectAllRecords();
        ValueTask<Record> SelectRecordAsync(Guid Id);
        ValueTask<Record> InsertRecordAsync(Record device);

    }
}