using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatsShop.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime AddDate { get; set; }
        [Required]
        public DateTime EditDate { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Price { get; set; }
        //Navigation Properties
        
        [ForeignKey("Cats")]
        public int? IdCat { get; set; }
        public virtual Cat Cats { get; set; }
    }
}
