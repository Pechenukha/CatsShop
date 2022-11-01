using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatsShop.Models
{
    public class Cat
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Breed { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Gender { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Color { get; set; }
        public int Age { get; set; }
        // Navigation Properties
        // public List<PositionModel> PositionModel { get; set; }
    }
}
