using System.ComponentModel.DataAnnotations;

namespace MvcSeyehatSitesi_20._10._2025.Models.Siniflar
{
    public class AnaSayfa
    {

        [Key]
        public int ID { get; set; }

        public string Baslik { get; set; }

        public string Aciklama { get; set; }

    }
}
