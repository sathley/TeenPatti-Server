using System;
using System.Threading;

namespace TeenPatti.Server
{
    public class RainDrop
    {
        private static long _lastMilliseconds = long.MaxValue;
        private static long _sequence;

        //Time: 1st August 2012
        private const long EpochTime = 634793760000000000;
        private const int ServerIdBits = 9;
        private const int DataCenterIdBits = 3;
        private const int SequenceBits = 8;

        private const int ServerIdShift = SequenceBits;
        private const int DataCenterIdShift = SequenceBits + ServerIdBits;
        private const int TimeShift = SequenceBits + ServerIdBits + DataCenterIdBits;

        public long GetNextId()
        {
            return GetNextId(Configuration.ServerId , Configuration.DataCentreId);
        }

        public long GetNextId(long serverId, long dataCenterId)
        {
            var currentSequence = NextSeq();
            var lastMilliSeconds = Interlocked.Read(ref _lastMilliseconds);
            var currentMilliSeconds = GetSystemMilliSeconds();

            Interlocked.CompareExchange(ref _lastMilliseconds, currentMilliSeconds, lastMilliSeconds);

            if (lastMilliSeconds > currentMilliSeconds)
            {
                GetNextId(serverId, dataCenterId);
            }
            return GenerateId(currentMilliSeconds, currentSequence, serverId, dataCenterId);
        }

        private static long NextSeq()
        {
            Interlocked.CompareExchange(ref _sequence, -1, 255);

            return Interlocked.Increment(ref _sequence);
        }

        private static long GenerateId(long milliSeconds, long sequence, long serverId, long dataCenterId)
        {
            var dataCenter = dataCenterId << DataCenterIdShift;

            var server = serverId << ServerIdShift;

            long id = milliSeconds | dataCenter | server | sequence;
            return id;
        }

        private static long GetSystemMilliSeconds()
        {
            var epochTime = string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["raindrop.epochtime"]) ? EpochTime
                : long.Parse(System.Configuration.ConfigurationManager.AppSettings["raindrop.epochtime"]);
            var now = DateTime.UtcNow.Ticks;
            var time = (now - epochTime) / TimeSpan.TicksPerMillisecond;
            return time << TimeShift;
        }

        private static void EpochTimeGet()
        {

            var epochTime = DateTime.Parse("1 Aug 2012");
            Console.WriteLine(epochTime.Ticks);
        }
    }
}