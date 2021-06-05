using System;
using System.Collections.Generic;
using System.Linq;
namespace DataStructure.Leetcode.Contest
{
    public class LatestTime
    {

        public string MaximumTime(string time)
        {
            string[] t = time.Split(':');
            int minutePosition;
            int hoursPosition;
            Dictionary<int, int> hoursCombo = new Dictionary<int, int> { {0,9}, {1,9}, { 2, 3 } };
            if (t[0].Contains('?'))
            {
                minutePosition = t[0].IndexOf('?');

            }
            if (t[1].Contains('?'))
            {
                hoursPosition = t[1].IndexOf('?');
                if(hoursPosition == 0)
                {
                    int secondPos = int.Parse((t[1][1].ToString()));
                    t[hoursPosition] = hoursCombo.Last(x => x.Key < secondPos).Key.ToString();

                }
                else
                {
                    int firstPos = int.Parse((t[1][0].ToString()));
                    //t[hoursPosition] = hoursCombo.
                }
            }

            return String.Format("${0}${1}:${2}{3}", t[0][0], t[0][1], t[1][0], t[1][1]);
        }

        
    }
}
