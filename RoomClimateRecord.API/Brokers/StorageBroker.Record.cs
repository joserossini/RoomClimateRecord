using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RoomClimateRecord.API.Models;

namespace RoomClimateRecord.API.Brokers
{

    public partial class StorageBroker
    {
        public DbSet<Record> records { get; set; }

        public IQueryable<Record> GetAllRecords() =>
            this.records.AsQueryable();

        public async ValueTask<Record> GetRecordAsync(Guid Id) =>
           await this.records.FindAsync(Id);

        public async ValueTask<Record> InsertRecordAsync(Record record)
        {
            EntityEntry<Record> insertedRecord = await this.records.AddAsync(record);
            await this.SaveChangesAsync();
            return insertedRecord.Entity;
        }

    }

}