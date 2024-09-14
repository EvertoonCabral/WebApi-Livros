using System.Text.Json.Serialization;

namespace WebApi_Livros.Models
{
    public class AutorModel
    {

        public int ID { get; set; }
        public string Name { get; set; }    
        public string LastName { get; set; }
        [JsonIgnore]
        public ICollection<LivrosModel> Livros{ get; set; }

    }
}
