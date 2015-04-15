using Newtonsoft.Json;

namespace GodLesZ.Tools.SoundCloudDownloader.Library.Soundcloud.Model
{
    public class Track {

        [JsonProperty("user")]
        public User User;

        [JsonProperty("user_id")]
        public int UserId;

        [JsonProperty("genre")]
        public string Genre;

        [JsonProperty("tag_list")]
        public string TagList;

        [JsonProperty("duration")]
        public int Duration;

        [JsonProperty("downloadable")]
        public bool Downloadable;

        [JsonProperty("download_url")]
        public string DownloadUrl;

        [JsonProperty("original_content_size")]
        public int OriginalContentSize;

        [JsonProperty("commentable")]
        public bool Commentable;

        [JsonProperty("sharing")]
        public string Sharing;

        [JsonProperty("created_at")]
        public string CreatedAt;

        [JsonProperty("updated_at")]
        public string UpdatedAt;

        [JsonProperty("isrc")]
        public string Isrc;

        [JsonProperty("state")]
        public string State;

        [JsonProperty("embeddable")]
        public bool Embeddable;

        [JsonProperty("embeddable_by")]
        public string EmbeddableBy;

        [JsonProperty("license")]
        public string License;

        [JsonProperty("artwork_url")]
        public string ArtworkUrl;

        [JsonProperty("waveform_url")]
        public string WaveformUrl;

        [JsonProperty("feedable")]
        public bool Feedable;

        [JsonProperty("label_name")]
        public string LabelName;

        [JsonProperty("release_date")]
        public string ReleaseDate;

        [JsonProperty("purchase_title")]
        public object PurchaseTitle;

        [JsonProperty("purchase_url")]
        public string PurchaseUrl;

        [JsonProperty("policy")]
        public string Policy;

        [JsonProperty("visuals")]
        public object Visuals;

        [JsonProperty("comment_count")]
        public int CommentCount;

        [JsonProperty("likes_count")]
        public int LikesCount;

        [JsonProperty("playback_count")]
        public int PlaybackCount;

        [JsonProperty("reposts_count")]
        public int RepostsCount;

        [JsonProperty("download_count")]
        public int DownloadCount;

        [JsonProperty("secret_token")]
        public object SecretToken;

        [JsonProperty("secret_uri")]
        public object SecretUri;

        [JsonProperty("stream_url")]
        public string StreamUrl;

        [JsonProperty("streamable")]
        public bool Streamable;

        [JsonProperty("permalink")]
        public string Permalink;

        [JsonProperty("permalink_url")]
        public string PermalinkUrl;

        [JsonProperty("title")]
        public string Title;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("track_type")]
        public string TrackType;

        [JsonProperty("last_modified")]
        public string LastModified;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("kind")]
        public string Kind;

    }

}