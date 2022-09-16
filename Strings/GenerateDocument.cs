using System;

public class Program
{
   public bool GenerateDocument(string characters, string document)
   {
      foreach (char i in document)
      {
         if (characters.IndexOf(i) == -1)
         {
            return false;
         }
         characters = characters.Remove(characters.IndexOf(i), 1);
      }
      return true;
   }
}
