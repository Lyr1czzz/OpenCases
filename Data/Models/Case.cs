using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OpenCases.Data.Models
{
    public class Case
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Item>? Items { get; set; }

        public string? CloseImage { get; set; }

        public string? OpenImage { get; set; }
    }
}