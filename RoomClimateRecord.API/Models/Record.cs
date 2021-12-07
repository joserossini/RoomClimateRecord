namespace RoomClimateRecord.API.Models
{

    public class Record
    {
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }
        public bool Motion { get; set; }
        public short Temperature { get; set; }
        public short Humidity { get; set; }
        
    }

}