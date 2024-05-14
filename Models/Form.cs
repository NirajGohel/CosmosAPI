using Newtonsoft.Json;

namespace CosmosAPI.Models
{
    public class Form
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        public List<Paragraph> Paragraphs { get; set; }

        public List<YesNo> YesNoes { get; set; }

        public List<Date> Dates { get; set; }
        
        public List<Number> Numbers { get; set; }

        public List<DropDown> DropDowns { get; set; }

        public List<MultipleChoice> MultipleChoices { get; set; }
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

    public class Date
    {
        public string id { get; set; }

        public string type { get; set; }

        public string question { get; set; }

        public string answer { get; set; }
    }

    public class Number
    {
        public string id { get; set; }

        public string type { get; set; }

        public string question { get; set; }

        public string answer { get; set; }
    }

    public class DropDown
    {
        public string id { get; set; }

        public string type { get; set; }

        public string question { get; set; }

        public string[] option { get; set; }

        public string answer { get; set; }
    }

    public class MultipleChoice
    {
        public string id { get; set; }

        public string type { get; set; }

        public string question { get; set; }

        public string[] option { get; set; }

        public string[] answer { get; set; }
    }

}
