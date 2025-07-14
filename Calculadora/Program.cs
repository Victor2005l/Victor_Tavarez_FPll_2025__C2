using System;

class Calculadora
{
    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA DE CONSOLA ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Raíz cuadrada");
            Console.WriteLine("6. Exponenciación (a^b)");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();

            double a, b, resultado;

            switch (opcion)
            {
                case "1":
                    (a, b) = LeerDosNumeros();
                    resultado = a + b;
                    MostrarResultado(resultado);
                    break;

                case "2":
                    (a, b) = LeerDosNumeros();
                    resultado = a - b;
                    MostrarResultado(resultado);
                    break;

                case "3":
                    (a, b) = LeerDosNumeros();
                    resultado = a * b;
                    MostrarResultado(resultado);
                    break;

                case "4":
                    (a, b) = LeerDosNumeros();
                    if (b == 0)
                        Console.WriteLine("❌ No se puede dividir por cero.");
                    else
                        MostrarResultado(a / b);
                    break;

                case "5":
                    Console.Write("Ingresa el número: ");
                    a = LeerNumero();
                    if (a < 0)
                        Console.WriteLine("❌ No se puede calcular la raíz de un número negativo.");
                    else
                        MostrarResultado(Math.Sqrt(a));
                    break;

                case "6":
                    (a, b) = LeerDosNumeros();
                    MostrarResultado(Math.Pow(a, b));
                    break;

                case "0":
                    salir = true;
                    Console.WriteLine("👋 Cerrando la calculadora...");
                    break;

                default:
                    Console.WriteLine("⚠️ Opción no válida. Intenta de nuevo.");
                    break;
            }

            if (!salir)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static (double, double) LeerDosNumeros()
    {
        Console.Write("Ingresa el primer número: ");
        double a = LeerNumero();
        Console.Write("Ingresa el segundo número: ");
        double b = LeerNumero();
        return (a, b);
    }

    static double LeerNumero()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double num))
                return num;
            Console.Write("Entrada inválida. Ingresa un número válido: ");
        }
    }

    static void MostrarResultado(double resultado)
    {
        Console.WriteLine($"📌 Resultado: {resultado}");
    }
}
