using System.Net.Http;
using Contracts;
using Newtonsoft.Json;

namespace OpenDotaClient
{
    public static class OpenDotaClientHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static PlayerInfo GetPlayerInfo(long playerId)
        {
            var openDotaUrl = OpenDotaApiUrl.GetOpenDotaApiUrl(OpenDotaApiUrl.OPENDOTA_PLAYER, playerId.ToString());
            var playerInfoJson = client.GetStringAsync(openDotaUrl).Result;
            var playerInfo = JsonConvert.DeserializeObject<PlayerInfo>(playerInfoJson);

            return playerInfo;
        }
    }
}
