using System;

  class Media
  {
   static void Main(string[] args)
{
    Console.WriteLine("Informe a primeira nota: ");
      double nota01 = double.Parse(Console.ReadLine());

      Console.WriteLine("Informe a segunda nota: ");
      double nota02 = double.Parse(Console.ReadLine());

      Console.WriteLine("Informe a terceira nota: ");
      double nota03 = double.Parse(Console.ReadLine());

      double media = (nota01 + nota02 + nota03) / 3;

      Console.WriteLine($"Olá querido aluno! A sua média foi de {media}! :) "); 
}
  } 