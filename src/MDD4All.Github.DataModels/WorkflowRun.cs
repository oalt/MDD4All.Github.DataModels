using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MDD4All.Github.DataModels
{
    public class WorkflowRun
    {
        [JsonProperty("id")]
        public object Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("node_id")]
        public string NodeId;

        [JsonProperty("head_branch")]
        public string HeadBranch;

        [JsonProperty("head_sha")]
        public string HeadSha;

        [JsonProperty("path")]
        public string Path;

        [JsonProperty("display_title")]
        public string DisplayTitle;

        [JsonProperty("run_number")]
        public int RunNumber;

        [JsonProperty("event")]
        public string Event;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("conclusion")]
        public string Conclusion;

        [JsonProperty("workflow_id")]
        public int WorkflowId;

        [JsonProperty("check_suite_id")]
        public object CheckSuiteId;

        [JsonProperty("check_suite_node_id")]
        public string CheckSuiteNodeId;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("html_url")]
        public string HtmlUrl;

        [JsonProperty("pull_requests")]
        public List<object> PullRequests;

        [JsonProperty("created_at")]
        public DateTime CreatedAt;

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt;

        [JsonProperty("actor")]
        public Actor Actor;

        [JsonProperty("run_attempt")]
        public int RunAttempt;

        [JsonProperty("referenced_workflows")]
        public List<object> ReferencedWorkflows;

        [JsonProperty("run_started_at")]
        public DateTime RunStartedAt;

        [JsonProperty("triggering_actor")]
        public TriggeringActor TriggeringActor;

        [JsonProperty("jobs_url")]
        public string JobsUrl;

        [JsonProperty("logs_url")]
        public string LogsUrl;

        [JsonProperty("check_suite_url")]
        public string CheckSuiteUrl;

        [JsonProperty("artifacts_url")]
        public string ArtifactsUrl;

        [JsonProperty("cancel_url")]
        public string CancelUrl;

        [JsonProperty("rerun_url")]
        public string RerunUrl;

        [JsonProperty("previous_attempt_url")]
        public object PreviousAttemptUrl;

        [JsonProperty("workflow_url")]
        public string WorkflowUrl;

        [JsonProperty("head_commit")]
        public HeadCommit HeadCommit;

        [JsonProperty("repository")]
        public Repository Repository;

        [JsonProperty("head_repository")]
        public HeadRepository HeadRepository;
    }


}
