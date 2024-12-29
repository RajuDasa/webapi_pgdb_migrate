using System.ComponentModel.DataAnnotations;

namespace SampleWebapi.Data
{
    public class AppUser
    {
        [Key]
        public Guid User_Id { get; set; }

        [StringLength(100)]
        public required string Display_Name { get; set; }

        [StringLength(5)]
        public required string Country { get; set; }

        public string? Payload { get; set; }

        public DateTime Created_At { get; set; }
    }
}