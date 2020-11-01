using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace DataStructure.Hackerank.Medium
{
   public static class ClimbingTheLeaderBoard
    {
        public static void SolutionOne(List<int> ranked, List<int> player)
        {
            Stopwatch g = new Stopwatch();
            g.Start();
            HashSet<int> leaderBoards = new HashSet<int>(ranked);
            ranked = leaderBoards.ToList<int>();
            List<int> positions = new List<int>();
            for (int i = 0; i < player.Count; i++)
            {
                int score = player[i];
                int leaderBoardMid = ranked.Count / 2;

                int firstToSearch = ranked[leaderBoardMid] >= score ? ranked.Count-1 : leaderBoardMid;
                int lastIndexToSearch = ranked[leaderBoardMid] >= score ? leaderBoardMid : 0;

                int nextPos = firstToSearch - 1;
                for (int j = firstToSearch; j >= lastIndexToSearch; j--)
                {
                    int currentLeaderBoardPosition = ranked[j];
                    if (score < currentLeaderBoardPosition) { positions.Add(j + 2); break; }
                    else if (score == currentLeaderBoardPosition){ positions.Add(j+1); break; }
                    
                    else if ( j == lastIndexToSearch) { positions.Add(j+1); break; }
                    nextPos--;
                }

            }
            Console.WriteLine("{0}",g.ElapsedMilliseconds);
            for (int i = 0; i < positions.Count; i++)
            {
                Console.Write("{0} ", positions[i]);
            }
        }
    }
}
