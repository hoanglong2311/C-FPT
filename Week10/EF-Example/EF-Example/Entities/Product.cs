using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Example.Entities
{
    [Table("Product")]

    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Provider { get; set; }
        public void Info()
        {
            Console.WriteLine($"Product: {Id}, Name: {Name}, Provider: {Provider}");
        }
          
    }
}
