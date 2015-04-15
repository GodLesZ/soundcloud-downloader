using Newtonsoft.Json;

namespace GodLesZ.Tools.SoundCloudDownloader.Library.Soundcloud.Model
{
    public class User {

        [JsonProperty("full_name")]
        public string FullName;

        [JsonProperty("country")]
        public string Country;

        [JsonProperty("city")]
        public string City;

        [JsonProperty("tracks_count")]
        public int TracksCount;

        [JsonProperty("followers_count")]
        public int FollowersCount;

        [JsonProperty("followings_count")]
        public int FollowingsCount;

        [JsonProperty("public_favorites_count")]
        public int PublicFavoritesCount;

        [JsonProperty("groups_count")]
        public int GroupsCount;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("plan")]
        public string Plan;

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("username")]
        public string Username;

        [JsonProperty("kind")]
        public string Kind;

        [JsonProperty("permalink")]
        public string Permalink;

        [JsonProperty("permalink_url")]
        public string PermalinkUrl;

        [JsonProperty("first_name")]
        public string FirstName;

        [JsonProperty("avatar_url")]
        public string AvatarUrl;

        [JsonProperty("last_modified")]
        public string LastModified;
    }
}