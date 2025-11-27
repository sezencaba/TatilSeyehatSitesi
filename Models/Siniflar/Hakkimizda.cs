using System.ComponentModel.DataAnnotations;

namespace MvcSeyehatSitesi_20._10._2025.Models.Siniflar
{
    public class Hakkimizda
    {

        [Key]
        public int ID { get; set; }

        public string FotoUrl { get; set; }

        public string Aciklama { get; set; }

    }
}
