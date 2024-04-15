using System.ComponentModel.DataAnnotations;

namespace Hotellerie_RahmaBrahem.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Nom Personne")]
        public string NomPers { get; set; } = null!;
        [Required]
        [DataType(DataType.MultilineText)]
        public string  Commentaire { get; set; }= null!;
        public int HotelId { get; set; }
        public virtual Hotel? Hotel { get; set; }


    }
}
