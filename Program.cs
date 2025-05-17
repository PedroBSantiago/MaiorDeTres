
using System.Reflection.Metadata;
Console.Clear();
double a1 ,a2, a3;

Console.Write("digite um numero com até 2 casa decimais: ");
a1 = Convert.ToDouble(Console.ReadLine())!;
Console.Write("digite outro numero com até 2 casa decimais: ");
a2 = Convert.ToDouble(Console.ReadLine())!;
Console.Write("digite outro numero com até 2 casa decimais: ");
a3 = Convert.ToDouble(Console.ReadLine())!;


Console.WriteLine("Denominando maior dos 3...");
Thread.Sleep(1000);
Thread.Sleep(1000);
if (a1>a2 && a1>a3)
{ 
    Console.WriteLine($"o número maior dos tres é : {a1}");


}
else if(a2>a3 && a2>a1)
    {
        Console.WriteLine($"o número maior dos tres é : {a2}");



    }

else if (a3 > a1 && a3 > a2)
  {
    Console.WriteLine($"o número maior dos tres é : {a3}");

  }












