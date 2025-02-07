using System.ComponentModel.DataAnnotations;

namespace BSD2_24.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string? Nom { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateDeSortie { get; set; }

        public decimal Prix { get; set; }
    }
}
