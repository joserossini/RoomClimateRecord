using System.ComponentModel.DataAnnotations;

namespace RoomClimateRecord.API.Models
{

    public class Record
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime Stamp { get; set; }
        public Nullable<bool> Motion { get; set; }
        public Nullable<short> Temperature { get; set; }
        public Nullable<short> Humidity { get; set; }
        
    }

}