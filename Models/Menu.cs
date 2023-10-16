using System.ComponentModel.DataAnnotations;

namespace DE_WebCambios.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool ConSalsa { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
    }
}
