using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.Clear();
            
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());           

            Console.Write("Digite o Segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha uma operação (+ - * /):  ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro, operação inválida");
                    break;

                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;

                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;

                case '/':

                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível realizar divisão por 0.");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);                        
                    }
                    break;
            }

            Console.Write("Continuar calculando (S / N)? ");
            string opcao = Console.ReadLine();

            if (opcao == "S" || opcao == "s")
            {
                goto Inicio;
            }
        }
    }
}
