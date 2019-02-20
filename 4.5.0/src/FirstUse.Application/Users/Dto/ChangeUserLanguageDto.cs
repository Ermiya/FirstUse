using System.ComponentModel.DataAnnotations;

namespace FirstUse.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}