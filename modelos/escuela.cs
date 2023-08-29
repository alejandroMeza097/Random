using Newtonsoft.Json;

namespace RandomAPI.modelos
{
    public class escuela
    {
        
      
            public string country { get; set; }
            public List<string> domains { get; set; }
            public string alpha_two_code { get; set; }

            [JsonProperty("state-province")]
            public object stateprovince { get; set; }
            public List<string> web_pages { get; set; }
            public string name { get; set; }
        

    }
}
