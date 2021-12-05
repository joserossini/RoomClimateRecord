namespace RoomClimateRecord.API.Models
{

    public class Record
    {
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }

        public bool Motion { get; set; }

        public float Temperature { get; set; }

        public float Humidity { get; set; }

        public float Iluminance { get; set; }

        public float Noise { get; set; }
        
    }

}