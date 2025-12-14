using DetyreKursi2.Validime;
using System.ComponentModel.DataAnnotations;

namespace DetyreKursi2.Models
{
    public class Kursi
    {
        [FjaleTePalejueshme(new string[] { "test" })]
        [VazhdonMeShkronjeTeMadhe]
        [Display(Name = "Emri Kursit")]
        [Required(ErrorMessage = "Emri i kursit esht i detyrueshem!")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Vetem shkronjat dhe hapsirat jane te lejuara per emrin e kursit!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Emri kursit duhet te jete 3 shkronja min ose ose 20 max!")]
        public string EmriKrusit { get; set; } = string.Empty;

        [Required(ErrorMessage = "Pershkrimi i kursit eshte i detyrueshem!")]
        [StringLength(500, MinimumLength = 10)]
        [RegularExpression(@"^[a-zA-Z\s?!.']+$", ErrorMessage = "Vetem shkronjat, hapsirat, ?, ., ', dhe ! jane te lejuara per pershkrimin e kursit!")]
        public string Pershkirmi { get; set; } = string.Empty;
    }
}