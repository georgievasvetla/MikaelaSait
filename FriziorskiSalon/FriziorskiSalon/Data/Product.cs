using FriziorskiSalon.Data.hairdressingSalon.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriziorskiSalon.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCategory { get; set; }
        public CategoryType Category { get; set; }
        public string Manifacture { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public DateTime DateOfEntryy { get; set; }

        public virtual ICollection<Order> Orders { get; set; } 
    }
}
