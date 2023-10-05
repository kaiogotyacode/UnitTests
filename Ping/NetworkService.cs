using System.Net.NetworkInformation;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        public string SendPing() => "Success: Ping Sent!";

        public int PingTimeout(int a, int b) => a + b;

        public DateTime LastPingDate()
        {
            return DateTime.UtcNow;
        }

        public PingOptions GetPingOptions() => new PingOptions()
        {
            Ttl = 1,
            DontFragment = true
        };

        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pings = new PingOptions[]
            {
              new (){ Ttl = 1, DontFragment = false },
              new (){ Ttl = 2, DontFragment = false }
            };

            return pings;
        }
    }

}
