using System;

namespace MarieCurie.DoIt.Domain
{
    public class AuthenticationToken
    {
        public static string HeaderName = "X-Auth-Token";
        public string Value { get; set; }
        public DateTime Expiry { get; set; }

        public bool IsExpired { get { return DateTime.Now > Expiry; } }
    }
}
