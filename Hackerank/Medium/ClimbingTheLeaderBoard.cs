using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure.Hackerank.Medium
{
   public static class ClimbingTheLeaderBoard
    {
        public static void SolutionOne(List<int> ranked, List<int> player)
        {
            HashSet<int> leaderBoards = new HashSet<int>(ranked);
            ranked = leaderBoards.ToList<int>();
            List<int> positions = new List<int>(0);
            Console.WriteLine(ranked.Count);
            for (int i = 0; i < player.Count; i++)
            {
                int score = player[i];
                int leaderBoardMid = ranked.Count / 2;

                int firstToSearch = ranked[leaderBoardMid] >= score ? 0 : leaderBoardMid;
                int lastIndexToSearch = ranked[leaderBoardMid] >= score ? leaderBoardMid : ranked.Count-1;
                Console.WriteLine("{0} {1} {2}", firstToSearch, lastIndexToSearch, leaderBoardMid);

                int nextPos = lastIndexToSearch - 1;
                for (int j = lastIndexToSearch; j >= firstToSearch; j--)
                {
                    int currentLeaderBoardPosition = ranked[j];
                    if (score < currentLeaderBoardPosition) { positions.Add(j + 1); break; }
                    else if (score == currentLeaderBoardPosition){ positions.Add(j); break; }
                    else if (score >= currentLeaderBoardPosition && score < ranked[nextPos]) { positions.Add(j); break; }
                    nextPos--;
                }

            }

            for (int i = 0; i < positions.Count; i++)
            {
                Console.Write("{0} ", positions[i]);
            }
        }
    }
}
