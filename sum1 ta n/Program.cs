System.Console.WriteLine("please enter a number:");
int a = int.Parse(Console.ReadLine()) ;
int zegma = 0;
 for (var i = 1; i <= a; i++)
 {
    zegma = zegma+i;
 }
 System.Console.WriteLine("zegma=" + zegma);