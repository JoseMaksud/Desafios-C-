using System;

class Program {
    public static void Main (string[] args) {
        Console.Write("Digite um número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite outro número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        Console.Write("Digite a operação desejada: ");
        string operacao = Console.ReadLine();

        switch (operacao) {
            case "+":
                resultado = numero1 + numero2;
                break;
            case "-":
                resultado = numero1 - numero2;
                break;
            case "*":
                resultado = numero1 * numero2;
                break;
            case "/":
                if (numero2 != 0) {
                    resultado = numero1 / numero2;
                } else {
                    Console.WriteLine("Divisão por zero não é permitida.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                return; 
        }

        Console.WriteLine("O resultado é: " + resultado);
    }
}
