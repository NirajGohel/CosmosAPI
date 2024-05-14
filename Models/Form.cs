using Newtonsoft.Json;

namespace CosmosAPI.Models
{
    public class Form
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        public string Name { get; set; }

        public List<Paragraph> Paragraphs { get; set; }

        public List<YesNo> YesNoes { get; set; }
    }

    public class Paragraph
    {
        public string id { get; set; }

        public string type { get; set; }

        public string question { get; set; } 

        public string answer { get; set; }
    }

    public class YesNo
    {
        public string id { get; set; }
        
        public string type { get; set; }

        public string question { get; set; }

        public string answer { get; set; }
    }
}
