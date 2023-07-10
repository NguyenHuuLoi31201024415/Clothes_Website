using System.ComponentModel.DataAnnotations;

namespace Clothes_Website.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        [StringLength(30)]
        public string? ColorName { get; set; }

    }
}
