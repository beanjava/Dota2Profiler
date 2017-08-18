using System.Collections.Generic;
using System.Net.Http;
using Contracts;
using Newtonsoft.Json;

namespace OpenDotaClient
{
    public static class OpenDotaClientHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static T GetObjectInfo<T>(string url, long id)
        {
            var apiFullUrl = OpenDotaApiUrl.GetOpenDotaApiUrl(url, id.ToString());
            var objectJson = client.GetStringAsync(apiFullUrl).Result;
            var objectItem = JsonConvert.DeserializeObject<T>(objectJson);

            return objectItem;
        }

        public static T GetObjectInfo<T>(string url)
        {
            var apiFullUrl = OpenDotaApiUrl.GetOpenDotaApiUrl(url);
            var objectJson = client.GetStringAsync(apiFullUrl).Result;
            var objectItem = JsonConvert.DeserializeObject<T>(objectJson);

            return objectItem;
        }
    }
}