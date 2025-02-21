using System.ComponentModel.DataAnnotations;

namespace S2_L5_PW.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il nome è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il nome non può superare i 50 caratteri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il prezzo è obbligatorio")]
        [Range(0.01, 10000, ErrorMessage = "Il prezzo deve essere positivo")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "La descrizione è obbligatoria")]
        public string Description { get; set; }

        [Required(ErrorMessage = "L'immagine di copertina è obbligatoria")]
        public string CoverImage { get; set; }

        [Required(ErrorMessage = "L'immagine aggiuntiva è obbligatoria")]
        public string AdditionalImage1 { get; set; }

        [Required(ErrorMessage = "L'immagine aggiuntiva è obbligatoria")]
        public string AdditionalImage2 { get; set; }
    }
}
