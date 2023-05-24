using System;
using System.ComponentModel.DataAnnotations;

namespace Cafe2.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }
    }
}
