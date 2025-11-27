using System.ComponentModel.DataAnnotations;

namespace MvcSeyehatSitesi_20._10._2025.Models.Siniflar
{
    public class Admin
    {

        [Key]
        public int ID { get; set; }

        public string Kullanici { get; set; }

        public string Sifre { get; set; }

    }
}
