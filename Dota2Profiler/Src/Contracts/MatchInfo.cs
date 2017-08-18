using Contracts.Enums;

namespace Contracts
{
    public class MatchInfo
    {
        /// <summary>
        /// Gets or set the match id of the match
        /// </summary>
        public long match_id { get; set; }

        /// <summary>
        /// Gets or sets the status of dire's barrack
        /// </summary>
        public long barracks_status_dire { get; set; }

        /// <summary>
        /// Gets or sets the status of radiant's barrack
        /// </summary>
        public long barracks_status_radiant { get; set; }

        /// <summary>
        /// Gets or sets the duration of the match in seconds
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// Gets or sets the time of first blood in seconds
        /// </summary>
        public int first_blood_time { get; set; }

        /// <summary>
        /// Gets or sets the game mode of match
        /// </summary>
        public GameMode game_mode { get; set; }

        /// <summary>
        /// Gets or sets the lobby type of match
        /// </summary>
        public LobbyType lobby_type { get; set; }
    }
}
