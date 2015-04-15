using Newtonsoft.Json;

namespace GodLesZ.Tools.SoundCloudDownloader.Library.Soundcloud.Model
{
    public class Facet {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("facets")]
        public FacetData[] Facets { get; set; }
    }
}