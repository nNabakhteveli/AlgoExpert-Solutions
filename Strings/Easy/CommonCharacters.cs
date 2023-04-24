using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
	public string[] CommonCharacters(string[] strings) {
		var dict = new Dictionary<char, int>();

        for (int i = 0; i < strings.Length; i++)
        {
            var usedChars = "";
            for (int j = 0; j < strings[i].Length; j++)
            {
                if (usedChars.IndexOf(strings[i][j]) == -1) {    
                    if (dict.ContainsKey(strings[i][j]) == true) dict[strings[i][j]] += 1;
                    else dict[strings[i][j]] = 1;
    
                    usedChars += strings[i][j];
                }
            }
        }

        var arr = new List<string>();

        foreach (var i in dict)
        {
            if (i.Value == strings.Length) arr.Add(i.Key.ToString());
        }
        
		return arr.ToArray();
	}
}
