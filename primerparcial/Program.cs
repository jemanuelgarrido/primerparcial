
namespace Primerparcial
{
    class Primerparcial

    {
        static void Main(string[] args)

        {
            // Solicitar al usuario un número entero positivo N mayor que cero
            Console.Write("Ingrese un numero entero positivo N mayor que cero: ");
            int n = int.Parse(Console.ReadLine());
            // Calcular la suma de los primeros N números enteros positivos y almacenar el resultado en la variable "suma"
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }

            // Imprimir en la pantalla todos los números enteros positivos menores o iguales que N
            Console.Write("Los numeros enteros positivos menores o iguales que N son: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Imprimir en la pantalla todos los números enteros impares menores o iguales que N
            Console.Write("Los numeros enteros impares menores o iguales que N son: ");
            for (int i = 1; i <= n; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Imprimir en la pantalla la tabla de multiplicar del número N, desde el 1 hasta el 10
            Console.WriteLine("La tabla de multiplicar del numero " + n + " es:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }

            // Imprimir en la pantalla la secuencia de números enteros positivos que comienzan en N y se incrementan en 2 hasta que se alcance un valor mayor que 20
            Console.Write("La secuencia de numeros enteros positivos que comienzan en N y se incrementan en 2 hasta que se alcance un valor mayor que 20 es: ");
            int j = n;
            while (j <= 20)
            {
                Console.Write(j + " ");
                j += 2;
            }
            Console.WriteLine();

            // Imprimir en la pantalla el valor de la variable "suma" al final del proceso
            Console.WriteLine("La suma de los primeros " + n + " numeros enteros positivos es: " + suma);
        }


    }
}




