using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenDotaClient;

namespace Profiler
{
    public class Program
    {
        static void Main(string[] args)
        {
            long playerId = 86702845;
            var playerInfo = OpenDotaClientHelper.GetPlayerInfo(playerId);
        }
    }
}
