using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class PlayerInfo
    {
        /// <summary>
        /// Gets or set the solo competitive rank of a player
        /// </summary>
        public string solo_competitive_rank { get; set; }

        /// <summary>
        /// Gets or sets the party competitive rank of a player
        /// </summary>
        public string competitive_rank { get; set; }

        /// <summary>
        /// Gets or sets the profile of the player
        /// </summary>
        public PlayerProfile profile { get; set; }
    }

    public class PlayerProfile
    {
        /// <summary>
        /// Gets or sets the account Id
        /// </summary>
        public long account_id { get; set; }

        /// <summary>
        /// Gets or sets the personal steam display name
        /// </summary>
        public string personaname { get; set; }

        /// <summary>
        /// Gets or sets the steam id 
        /// </summary>
        public string steamid { get; set; }
    }
}
