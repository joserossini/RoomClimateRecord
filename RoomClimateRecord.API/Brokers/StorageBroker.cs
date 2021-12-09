using Microsoft.EntityFrameworkCore;
using RoomClimateRecord.API.Models;

namespace RoomClimateRecord.API.Brokers
{

    public partial class StorageBroker : DbContext, IStorageBroker
    {
        public StorageBroker(DbContextOptions<StorageBroker> dbOptions)
        :base(dbOptions)
        {
            this.Database.Migrate();
        }
    }

}