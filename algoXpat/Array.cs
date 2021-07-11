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
			String winner = "";
			int currentWinnerpoint = 0;
			Dictionary<string, int> teamPointTable = new Dictionary<string, int>();
			for (int i = 0; i < results.Count; i++)
			{
				int res = results[i];
				int teamWinner = res == 1 ? 0 : 1;
				string teamKey = competitions[i][teamWinner];
				if (teamPointTable.ContainsKey(teamKey))
				{
					teamPointTable[teamKey] += 3;
				}
				else
				{
					teamPointTable.Add(teamKey, 3);
				}

				if (teamPointTable[teamKey] >= currentWinnerpoint)
				{
					winner = teamKey;
					currentWinnerpoint = teamPointTable[teamKey];
				}
			}
			return winner;
		}
	}
}
