using System.ComponentModel.DataAnnotations;

namespace Cafe2.Models
{
    public class Galeri
    {
        [Key]
        public  int Id { get; set; }

        public string Image { get; set; }



    }
}
