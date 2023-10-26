using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApi.Model
{
    public class ApiCepModel
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("ibge")]
        public string Ibge { get; set; }

        [JsonPropertyName("gia")]
        public string Gia { get; set; }

        [JsonPropertyName("ddd")]
        public string Ddd { get; set; }
        [JsonPropertyName("diafi")]
        public string Diafi { get; set; }
    }
}
