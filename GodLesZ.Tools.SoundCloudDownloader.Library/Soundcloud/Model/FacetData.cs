using Newtonsoft.Json;

namespace GodLesZ.Tools.SoundCloudDownloader.Library.Soundcloud.Model
{
    public class FacetData {

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}