using System;
using System.Collections.Generic;

namespace DataStructure.algoXpat
{
    public class Array
    {
        public Array()
        {
        }

		public static string TournamentWinner(List<List<string>> competitions, List<int> results)
		{
			// Write your code here.
			String winner = "";
			Dictionary<string, int> teamPointTable = new Dictionary<string, int>();

			for (int i = 0; i < results.Count; i++)
			{
				int res = results[i];
				int teamWinner = res == 1 ? 0 : 1;
					string teamKey = competitions[i][teamWinner];
					if (teamPointTable.ContainsKey(teamKey))
                    {
						teamPointTable[teamKey]+= 3;
                    } else
                    {
						teamPointTable.Add(teamKey, 3);
                    }
			}

			int score = 0;
            foreach (var item in teamPointTable)
            {
				if (item.Value > score)
                {
					score = item.Value;
					winner = item.Key;
				}
			}

			// find winner
			return winner;
		}
	}
}
