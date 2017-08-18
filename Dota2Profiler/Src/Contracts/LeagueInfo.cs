using Contracts.Enums;

namespace Contracts
{
    public class LeagueInfo
    {
        /// <summary>
        /// Gets or set the name of league
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the id of league
        /// </summary>
        public int leagueid { get; set; }

        /// <summary>
        /// Gets or sets the description of league
        /// </summary>
        public string ticket { get; set; }

        /// <summary>
        /// Gets or sets the description of league
        /// </summary>
        public string banner { get; set; }

        /// <summary>
        /// Gets or sets the tier of league
        /// </summary>
        public LeagueTier? tier { get; set; }
    }
}