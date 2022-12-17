using System.ComponentModel.DataAnnotations;

namespace BETarjetaCredito.Models
{
    public class TarjetaModel
    {
        public int Id { get; set; }
        [Required]
        public string titular { get; set; }
        [Required]
        public string nroTarjeta { get; set; }
        [Required]
        public string fechaExp { get; set; }
        [Required]
        public string cvv { get; set; }
    }
}
