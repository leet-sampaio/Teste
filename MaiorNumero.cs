using System;

  class MaiorNumero
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Informe o primeiro número: ");
      double numero01 = double.Parse(Console.ReadLine());

      Console.WriteLine("Informe o segundo número: ");
      double numero02 = double.Parse(Console.ReadLine());

      if(numero01 > numero02){
        Console.WriteLine("O maior número é: !" + numero01);
      } else if (numero02 > numero01){
        Console.WriteLine("O maior número é: !" + numero02);
      } else {
        Console.WriteLine("Os números são iguais! Se atente!");
      }
    }
  } 