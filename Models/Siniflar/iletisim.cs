using System.ComponentModel.DataAnnotations;

namespace MvcSeyehatSitesi_20._10._2025.Models.Siniflar
{
    public class iletisim
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Ad Soyad zorunludur.")]
        [StringLength(100)]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Mail zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir mail adresi giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Konu zorunludur.")]
        [StringLength(150)]
        public string Konu { get; set; }

        [Required(ErrorMessage = "Mesaj zorunludur.")]
        [StringLength(1000)]
        public string Mesaj { get; set; }

        public bool OkunduMu { get; set; } = false; 

    }
}
