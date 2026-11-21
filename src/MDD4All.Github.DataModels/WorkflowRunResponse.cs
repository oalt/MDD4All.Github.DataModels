using Newtonsoft.Json;
using System.Collections.Generic;

namespace MDD4All.Github.DataModels
{
    public class WorkflowRunResponse
    {
        [JsonProperty("total_count")]
        public int TotalCount;

        [JsonProperty("workflow_runs")]
        public List<WorkflowRun> WorkflowRuns;
    }


}
