using Newtonsoft.Json;
using System;

namespace MDD4All.Github.DataModels
{

    public class HeadCommit
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("tree_id")]
        public string TreeId;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("timestamp")]
        public DateTime Timestamp;

        [JsonProperty("author")]
        public Author Author;

        [JsonProperty("committer")]
        public Committer Committer;
    }


}
