using System;

class CalculadoraSimple
{
    static void Main()
    {
        double resultado = 0.0;
        bool salir = false;

        Console.WriteLine("Calculadora Simple");
        Console.WriteLine("Ingrese un número seguido de una operación (+ o -) y otro número.");
        Console.WriteLine("Ejemplo: 5 + 3 o 10 - 2");
        Console.WriteLine("Para salir, escriba 'salir'.");

        while (!salir)
        {
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "salir")
            {
                salir = true;
                continue;
            }

            string[] partes = entrada.Split(' ');
            if (partes.Length != 3)
            {
                Console.WriteLine("Entrada inválida. Por favor, siga el formato: número operador número.");
                continue;
            }

            double numero1, numero2;
            if (!double.TryParse(partes[0], out numero1) || !double.TryParse(partes[2], out numero2))
            {
                Console.WriteLine("Entrada inválida. Los números deben ser válidos.");
                continue;
            }

            char operador = partes[1][0];
            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                default:
                    Console.WriteLine("Operador no válido. Use '+' para sumar o '-' para restar.");
                    continue;
            }

            Console.WriteLine("Resultado: " + resultado);
        }

        Console.WriteLine("Gracias por usar la calculadora simple.");
    }
}
