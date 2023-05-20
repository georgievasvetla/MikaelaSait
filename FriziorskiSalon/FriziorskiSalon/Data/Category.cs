using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FriziorskiSalon.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Service> Services { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
