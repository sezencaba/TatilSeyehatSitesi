using System.ComponentModel.DataAnnotations;

namespace MvcSeyehatSitesi_20._10._2025.Models.Siniflar
{
    public class Blog
    {

        [Key]   
        public int ID { get; set; }

        public string Baslik { get; set; }

        public DateTime Tarih { get; set; }

        public string Aciklama { get; set; }

        public string BlogImage { get; set; }

        public ICollection<Yorumlar> Yorumlars { get; set; }    

    }
}
