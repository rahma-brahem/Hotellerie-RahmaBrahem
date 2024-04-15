using System.ComponentModel.DataAnnotations;

namespace Hotellerie_RahmaBrahem.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        [StringLength(20, MinimumLength =3, ErrorMessage = "valeur entre 3 et 20 ")]
        public string Nom { get; set; } = null!;

        [Range(1, 5, ErrorMessage = "valeur entre 1 et 5 ")]
        public int Etoiles { get; set; }

        [Required(ErrorMessage = "ville obligatoire")]
        public string Ville { get; set; } = null!;

        [Required]
        [Url]
        [Display(Name = "Site web")]
        public string SiteWeb { get; set; }
        public string Tel { get; set; }
        
        //public int Id { get; set; }
        //public string UrlSiteWeb { get; set; } // Ajouté une propriété pour l'URL du site web
    }
}
