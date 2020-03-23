using System;

namespace projeto
{				
    public class Program
   {
	     static void Main(string[] args)
	
    {
      
      int x = 1;
          int y = 2;

        string operacao = "";

Console.WriteLine("digite primer numero");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite segundo numero");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("porfavor escolher uma operacaon: \r\n" +

"x: adiçao \r\n"+
"y: subtraçao \r\n"+
"z: multiplicaçao \r\n"+
"w: diviçao");

Console.WriteLine("");
      
if(operacao == "+" || operacao == "x");
{
   Console.WriteLine(x+y);

}

if(operacao == "-" || operacao == "y");
    {
      Console.WriteLine(x-y);
    }
if(operacao == "*" || operacao == "z");
{
      Console.WriteLine(x*y);
       
}
if(operacao == "/" || operacao == "w");
{
       Console.WriteLine(x/y);
       
}
      Console.WriteLine("tocar cualquer teclar para finalizar");
      Console.ReadKey();   

   

        }
      
    }

}