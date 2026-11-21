using Newtonsoft.Json;

namespace MDD4All.Github.DataModels
{
    public class HeadRepository
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("node_id")]
        public string NodeId;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("full_name")]
        public string FullName;

        [JsonProperty("private")]
        public bool Private;

        [JsonProperty("owner")]
        public Owner Owner;

        [JsonProperty("html_url")]
        public string HtmlUrl;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("fork")]
        public bool Fork;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("forks_url")]
        public string ForksUrl;

        [JsonProperty("keys_url")]
        public string KeysUrl;

        [JsonProperty("collaborators_url")]
        public string CollaboratorsUrl;

        [JsonProperty("teams_url")]
        public string TeamsUrl;

        [JsonProperty("hooks_url")]
        public string HooksUrl;

        [JsonProperty("issue_events_url")]
        public string IssueEventsUrl;

        [JsonProperty("events_url")]
        public string EventsUrl;

        [JsonProperty("assignees_url")]
        public string AssigneesUrl;

        [JsonProperty("branches_url")]
        public string BranchesUrl;

        [JsonProperty("tags_url")]
        public string TagsUrl;

        [JsonProperty("blobs_url")]
        public string BlobsUrl;

        [JsonProperty("git_tags_url")]
        public string GitTagsUrl;

        [JsonProperty("git_refs_url")]
        public string GitRefsUrl;

        [JsonProperty("trees_url")]
        public string TreesUrl;

        [JsonProperty("statuses_url")]
        public string StatusesUrl;

        [JsonProperty("languages_url")]
        public string LanguagesUrl;

        [JsonProperty("stargazers_url")]
        public string StargazersUrl;

        [JsonProperty("contributors_url")]
        public string ContributorsUrl;

        [JsonProperty("subscribers_url")]
        public string SubscribersUrl;

        [JsonProperty("subscription_url")]
        public string SubscriptionUrl;

        [JsonProperty("commits_url")]
        public string CommitsUrl;

        [JsonProperty("git_commits_url")]
        public string GitCommitsUrl;

        [JsonProperty("comments_url")]
        public string CommentsUrl;

        [JsonProperty("issue_comment_url")]
        public string IssueCommentUrl;

        [JsonProperty("contents_url")]
        public string ContentsUrl;

        [JsonProperty("compare_url")]
        public string CompareUrl;

        [JsonProperty("merges_url")]
        public string MergesUrl;

        [JsonProperty("archive_url")]
        public string ArchiveUrl;

        [JsonProperty("downloads_url")]
        public string DownloadsUrl;

        [JsonProperty("issues_url")]
        public string IssuesUrl;

        [JsonProperty("pulls_url")]
        public string PullsUrl;

        [JsonProperty("milestones_url")]
        public string MilestonesUrl;

        [JsonProperty("notifications_url")]
        public string NotificationsUrl;

        [JsonProperty("labels_url")]
        public string LabelsUrl;

        [JsonProperty("releases_url")]
        public string ReleasesUrl;

        [JsonProperty("deployments_url")]
        public string DeploymentsUrl;
    }


}
