using System;

class Program {
  public static void Main (string[] args) {
    int soma = 0;

    for (int i = 1; i <= 10; i++) {
      soma += i;
    }

    Console.Write("Soma de 1 a 10: " + soma);
  }
}