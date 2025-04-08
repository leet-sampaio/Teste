using System;

  class Idade
  {
    static void Main(string[] args)
{
    Console.WriteLine("Informe o ano que você nasceu? ");
      int ano = int.Parse(Console.ReadLine());

      int idade = 2025 - ano;

      Console.WriteLine($"Olá, pessoa maravilhosa! Aposto que esse ano você completa {idade} anos! Acertei? "); 
}
  } 