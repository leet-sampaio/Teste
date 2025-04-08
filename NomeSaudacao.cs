using System;

  class NomeSaudacao
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Qual é o seu nome? ");
      string nome = Console.ReadLine();

      Console.WriteLine($"Olá, {nome}! Que alegria ter você aqui!");    
    }
  }