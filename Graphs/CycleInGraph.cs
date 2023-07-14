using System;
using System.Collections.Generic;

class Program
{
    public static bool CycleInGraph(List<List<int>> edges)
    {
        bool[] isVisited = new bool[edges.Count];

        for (int i = 0; i < edges.Count; i++)
        {
            if (isVisited[i] || !IsCyclePresent(i, edges, new HashSet<int>(), isVisited))
                continue;
            else
                return true;
        }
        return false;
    }

    private static bool IsCyclePresent(int current, List<List<int>> edges, HashSet<int> visited, bool[] isVisited)
    {
        isVisited[current] = true;

        if (visited.Contains(current))
        {
            return true;
        }

        visited.Add(current);

        foreach (int neighbor in edges[current])
        {
            if ((isVisited[neighbor] && !visited.Contains(neighbor)) || !IsCyclePresent(neighbor, edges, visited, isVisited))
                continue;
            else
                return true;
        }

        visited.Remove(current);
        return false;
    }
}
