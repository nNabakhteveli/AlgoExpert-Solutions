using System.Collections.Generic;
using System;


// Time complexity: O(n)
public class Program
{
   public string TournamentWinner(List<List<string>> competitions, List<int> results)
   {
      var map = new Dictionary<string, int>();

      int greatestPoint = 0;
      string winnerTeamName = "";

      for (int i = 0; i < competitions.Count; i++)
      {
         int winnerTeamIndex = results[i] == 1 ? 0 : 1; // Because in results list, 1 means home team and 0 means away team
         string winner = competitions[i][winnerTeamIndex];

         map[winner] = map.ContainsKey(winner) ? map[winner] + 3 : 3;

         if (map[winner] > greatestPoint)
         {
            greatestPoint = map[winner];
            winnerTeamName = winner;
         }
      }
      return winnerTeamName;
   }
}