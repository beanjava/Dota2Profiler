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

        public static MatchInfo GetMatchInfo(long matchId)
        {
            var openDotaUrl = OpenDotaApiUrl.GetOpenDotaApiUrl(OpenDotaApiUrl.OPENDOTA_MATCH, matchId.ToString());
            var matchInfoJson = client.GetStringAsync(openDotaUrl).Result;
            var matchInfo = JsonConvert.DeserializeObject<MatchInfo>(matchInfoJson);

            return matchInfo;
        }
    }
}