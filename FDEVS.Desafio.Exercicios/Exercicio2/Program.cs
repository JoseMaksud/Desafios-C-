using System;

class Program {
    public static void Main (string[] args) {
        Console.Write("Digite seu peso em quilos: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double IMC = peso / (altura * altura);
        Console.WriteLine("Seu IMC é de: " + IMC.ToString("F2"));

        if (IMC > 40.0) {
            Console.WriteLine("Obesidade grau III\nAqui o sinal é vermelho, com forte probabilidade de já existirem doenças muito graves associadas. O tratamento deve ser ainda mais urgente.");
        } else if (IMC >= 35.0) {
            Console.WriteLine("Obesidade grau II\nMesmo que seus exames aparentem estar normais, é hora de se cuidar, iniciando mudanças no estilo de vida com o acompanhamento próximo de profissionais de saúde.");
        } else if (IMC >= 30.0) {
            Console.WriteLine("Obesidade grau I\nSinal de alerta! Chegou na hora de se cuidar, mesmo que seus exames sejam normais. Vamos dar início a mudanças hoje! Cuide de sua alimentação.");
        } else if (IMC >= 25.0) {
            Console.WriteLine("Sobrepeso\nEle é, na verdade, uma pré-obesidade e muitas pessoas nessa faixa já apresentam doenças associadas.");
        } else if (IMC >= 18.5) {
            Console.WriteLine("Normal\nQue bom que você está com o peso normal! Mantenha um estilo de vida ativo e uma alimentação equilibrada.");
        } else {
            Console.WriteLine("Abaixo do normal\nProcure um médico. Algumas pessoas têm um baixo peso por características do seu organismo, mas outras podem estar enfrentando problemas, como a desnutrição.");
        }
    }
}
