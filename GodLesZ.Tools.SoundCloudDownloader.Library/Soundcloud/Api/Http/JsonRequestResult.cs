using System.Collections.ObjectModel;
using GodLesZ.Tools.SoundCloudDownloader.Library.Soundcloud.Model;
using Newtonsoft.Json;

namespace GodLesZ.Tools.SoundCloudDownloader.Library.Soundcloud.Api.Http
{
    public class JsonRequestResult
    {
        [JsonProperty("collection")]
        public Track[] Collection { get; set; }

        [JsonProperty("facets")]
        public Facet[] Facets { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("qid")]
        public string Qid { get; set; }

        [JsonProperty("query_urn")]
        public string QueryUrn { get; set; }

        [JsonProperty("next_href")]
        public string NextHref { get; set; } 
    }
}