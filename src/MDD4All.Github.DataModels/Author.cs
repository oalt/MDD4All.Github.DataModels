using Newtonsoft.Json;

namespace MDD4All.Github.DataModels
{
    public class Author
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("email")]
        public string Email;
    }


}
