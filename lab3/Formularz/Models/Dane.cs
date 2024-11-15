using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2, ErrorMessage = "Imie musi miec przynajmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi miec przynajmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [EmailAddress(ErrorMessage = "Niepoprawny format Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Haslo")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Haslo musi miec min 8 znakow, zawierac min jedna duza litere, jedna mala litere i jedna cyfre")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Prosze potwierdz Haslo")]
        [Compare("Haslo", ErrorMessage = "Hasla musza byc takie same")]
        public string PotwierdzHaslo { get; set; }

        [Phone(ErrorMessage = "Niepoprawny format Nr Telefonu")]
        public string? NrTelefonu { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi byc pomiedzy 10 a 80")]
        public int? Wiek { get; set; }

        public string? Miasto { get; set; }

    }

    public enum Miasta
    {
        Tarnow = 1,
        Krakow = 2,
        Rzeszow = 3,
        Bochnia = 4,
        Brzesko = 5
    }
}
