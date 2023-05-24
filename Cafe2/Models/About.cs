using System.ComponentModel.DataAnnotations;

namespace Cafe2.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
    }

}
