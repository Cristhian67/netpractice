using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P2.Models
{
    public class Beer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public int BrandId { get; set; }

        [Column(TypeName = "decimal(18,2")]

        public decimal Alcohol { get; set; }

        [ForeignKey ("BrandId")]

        public Brand Brand { get; set; }

    }
}
