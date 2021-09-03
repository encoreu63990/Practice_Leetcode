using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/design-underground-system/
    /// https://leetcode.com/problems/design-underground-system/discuss/1441513/C-Solution
    /// </summary>
    class _1396_Design_Underground_System
    {
        public class UndergroundSystem
        {
            Dictionary<int, CheckInMessage> checkInDict = null;
            Dictionary<string, List<int>> travelTimeDict = null;

            public UndergroundSystem()
            {
                checkInDict = new Dictionary<int, CheckInMessage>();
                travelTimeDict = new Dictionary<string, List<int>>();
            }

            public void CheckIn(int id, string stationName, int t)
            {
                if (checkInDict.ContainsKey(id))
                {
                    checkInDict[id].StationName = stationName;
                    checkInDict[id].Time = t;
                }
                else
                {
                    checkInDict.Add(id, new CheckInMessage(stationName, t));
                }
            }

            public void CheckOut(int id, string stationName, int t)
            {
                var checkInMessage = checkInDict[id];

                var startStation = checkInMessage.StationName;
                var startTime = checkInMessage.Time;

                var key = startStation + "_" + stationName;
                if (travelTimeDict.ContainsKey(key))
                {
                    travelTimeDict[key].Add(t - startTime);
                }
                else
                {
                    travelTimeDict.Add(key, new List<int> { t - startTime });
                }
            }

            public double GetAverageTime(string startStation, string endStation)
            {
                var key = startStation + "_" + endStation;
                return travelTimeDict[key].Average();
            }

            public class CheckInMessage
            {
                public CheckInMessage(string stationName, int time)
                {
                    StationName = stationName;
                    Time = time;
                }

                public string StationName { get; set; }
                public int Time { get; set; }
            }
        }
    }
}
