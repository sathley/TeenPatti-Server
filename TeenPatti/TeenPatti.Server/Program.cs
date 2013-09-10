using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PubNubMessaging.Core;
using TeenPatti.Model;

namespace TeenPatti.Server
{
    public class Program
    {
        public static Pubnub Pubnub;

        const string CHANNELNAME = "test_channel";
        const string PUBLISH_KEY = "pub-c-c5fead49-3cdb-4e24-a1a2-0794f4f4deab";
        const string SUBSCRIBE_KEY = "sub-c-8104a13e-04c0-11e3-a005-02ee2ddab7fe";
        const string SECRET_KEY = "sec-c-NzNjNDViZjgtY2RjNS00YzBkLWFkNGItNjZkZmU1ZWU0NTFl";

        public static void Main()
        {
            var pubnub = new Pubnub(PUBLISH_KEY, SUBSCRIBE_KEY, SECRET_KEY);
            var tables = new List<Table>()
                {
                    new Table(VariationType.Classic, 10, 10, 1000, 3,"table1")
                };
            tables.ForEach(t=>t.InitGameplay());



        }
    }
}