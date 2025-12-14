using System.ComponentModel.DataAnnotations;

namespace DetyreKursi2.Validime
{
    public class VazhdonMeShkronjeTeMadhe : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null && value.ToString()[0] != value.ToString().ToUpper()[0])
            {
                return new ValidationResult("Shkronja e pare duhet te jete e madhe!");
            }

            return ValidationResult.Success;
        }
    }
}
