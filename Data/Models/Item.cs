using System.ComponentModel.DataAnnotations;

namespace OpenCases.Data.Models
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public Guid TypeId { get; set; }

        public Guid WeaponId { get; set; }
    }
}
