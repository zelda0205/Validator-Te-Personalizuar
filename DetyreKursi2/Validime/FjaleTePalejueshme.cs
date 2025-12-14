using System.ComponentModel.DataAnnotations;

namespace DetyreKursi2.Validime
{
    public class FjaleTePalejueshme : ValidationAttribute
    {
        private string[] _forbiddenWords { get; set; }

        public FjaleTePalejueshme(string[] forbiddenWords)
        {
            _forbiddenWords = forbiddenWords;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                foreach (var forbiddenWord in _forbiddenWords)
                {
                    if (forbiddenWord == value.ToString())
                    {
                        return new ValidationResult("Fjala " + forbiddenWord + " nuk eshte e lejueshme!");
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}
