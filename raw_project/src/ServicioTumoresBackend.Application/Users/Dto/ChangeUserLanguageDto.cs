using System.ComponentModel.DataAnnotations;

namespace ServicioTumoresBackend.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}