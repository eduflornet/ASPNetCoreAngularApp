using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreAngularApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}