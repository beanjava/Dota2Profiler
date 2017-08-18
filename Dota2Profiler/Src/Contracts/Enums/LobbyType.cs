using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Enums
{
    public enum LobbyType
    {
        Invalid = -1,
        PublicMatchMaking = 0,
        Practice = 1,
        Tournament = 2, 
        Tutorial = 3,
        CoopWithAI = 4,
        TeamMatch = 5,
        SoloQueue = 6,
        RankedMatchMaking = 7,
        SoloMid1v1 = 8
    }
}
