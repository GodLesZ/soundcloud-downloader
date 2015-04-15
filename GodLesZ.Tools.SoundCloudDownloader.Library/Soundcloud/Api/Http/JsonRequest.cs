using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GodLesZ.Tools.SoundCloudDownloader.Library.Soundcloud.Api.Http {
    public class JsonRequest {

        public async Task<JsonRequestResult> Search(string text, int limit = 10, int offset = 0) {
            var url = string.Format("https://api-v2.soundcloud.com/search/tracks?q={0}&facet=genre&limit={1}&offset={2}&linked_partitioning=1", text, limit, offset);
            var client = new WebClient();
            string resultString = await client.DownloadStringTaskAsync(url);
            try {
                var jsonResult = JsonConvert.DeserializeObject<JsonRequestResult>(resultString);
                if (jsonResult == null) {
                    throw new SystemException("Failed to parse result string from url: " + url);
                }

                return jsonResult;
            } catch (Exception ex) {
                return null;
            }
        }

    }
}