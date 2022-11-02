using System;



public class Program
{
   public static int GetNthFib(int n) => n > 0 && n <= 2 ? n - 1 : GetNthFib(n - 1) + GetNthFib(n - 2);
}