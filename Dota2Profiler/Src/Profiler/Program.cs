using OpenDotaClient;

namespace Profiler
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Bean: 86702845
            // Son : 115852730
            long playerId = 86702845;
            var playerInfo = OpenDotaClientHelper.GetPlayerInfo(playerId);

            // test match id: 3381931109
            long matchId = 3381931109;
            var matchInfo = OpenDotaClientHelper.GetMatchInfo(matchId);
        }
    }
}
