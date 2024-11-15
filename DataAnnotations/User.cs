using System.ComponentModel.DataAnnotations;

namespace DataAnnotations
{
    public class User
    {
        public int Id { get; set; }  // ID alanı
        [Required]  // Email alanı zorunlu olacak
        [EmailAddress]  // Geçerli bir email formatında olmalı
        public string Email { get; set; }

        [Required]  // Password alanı zorunlu olacak
        [StringLength(100, MinimumLength = 6)]  // Şifre uzunluğu en az 6 karakter olmalı
        public string Password { get; set; }
    }
}
