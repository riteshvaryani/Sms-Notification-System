using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TwlioSupport
{
    [DataContract]
    public class CoinDetail
    {
        [DataMember]
        public string id { get; private set; }

        [DataMember]
        public string name { get; private set; }

        [DataMember]
        public string symbol { get; private set; }

        [DataMember]
        public string rank { get; private set; }

        [DataMember]
        public string price_usd { get; private set; }

        [DataMember (Name = "24h_volume_usd")]
        public string h24_volume_usd { get; private set; }

        [DataMember]
        public string market_cap_usd { get; private set; }

        [DataMember]
        public string available_supply { get; private set; }

        [DataMember]
        public string total_supply { get; private set; }

        [DataMember]
        public string max_supply { get; private set; }

        [DataMember]
        public string percent_change_1h { get; private set; }

        [DataMember]
        public string percent_change_24h { get; private set; }

        [DataMember]
        public string percent_change_7d { get; private set; }

        [DataMember]
        public string last_updated { get; private set; }
    }
}
