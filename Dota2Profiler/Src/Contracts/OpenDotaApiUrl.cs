using System;

namespace Contracts
{
    public static class OpenDotaApiUrl
    {
        public const string OPENDOTA_BASE = @"https://api.opendota.com/api";
        public const string OPENDOTA_PLAYER = "/players/{0}";
        public const string OPENDOTA_MATCH = "/matches/{0}";

        public static string GetOpenDotaApiUrl(string apiUrl, string argument)
        {
            return String.Format(OPENDOTA_BASE + apiUrl, argument);
        }
    }
}
