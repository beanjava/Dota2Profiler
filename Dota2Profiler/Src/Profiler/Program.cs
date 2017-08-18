using System.Collections.Generic;
using Contracts;
using OpenDotaClient;

namespace Profiler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InitializeData();

            // Bean: 86702845
            // Son : 115852730
            long playerId = 86702845;
            var playerInfo = OpenDotaClientHelper.GetObjectInfo<PlayerInfo>(OpenDotaApiUrl.OPENDOTA_PLAYER, playerId);

            // test match id: 3381931109
            long matchId = 3381931109;
            var matchInfo = OpenDotaClientHelper.GetObjectInfo<MatchInfo>(OpenDotaApiUrl.OPENDOTA_MATCH, matchId);
        }

        private static void InitializeData()
        {
            //Get all league data
            DotaData.LeaguesList = OpenDotaClientHelper.GetObjectInfo<List<LeagueInfo>>(OpenDotaApiUrl.OPENDOTA_LEAGUES);

            //Get all league data
            DotaData.HeroesList = OpenDotaClientHelper.GetObjectInfo<List<HeroInfo>>(OpenDotaApiUrl.OPENDOTA_HEROES);
        }
    }
}

