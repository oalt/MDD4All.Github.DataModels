using Newtonsoft.Json;

namespace MDD4All.Github.DataModels
{
    public class Committer
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("email")]
        public string Email;
    }


}
