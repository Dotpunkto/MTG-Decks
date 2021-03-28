using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace MTG_Decks.Entities
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }

        [JsonIgnore]
        public string Role { get; set; }

        [JsonIgnore]
        public string Token { get; set; }

    }
}
