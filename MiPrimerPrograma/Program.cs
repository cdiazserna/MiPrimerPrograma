//1ro: definir el nombre de mi clase con su respectivo método Main

public class MiPrimerPrograma
{
    static void Main(string[] args)
    {
        //Enunciado:
        //Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números. Imprimir en pantalla el resultado de cada operación.

        //2do. Declaración de mis variables (Datos de Entrada)
        int num1, num2, suma, resta, producto, cociente; //Quemar Código: poner valores directamente a las variables sin pedirlos desde la consola

        //3ro. Pedir los valores por pantalla (Consola):
        Console.Write("Ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine()); //Solamente Recibe tipos de datos String

        Console.Write("Ingrese su segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine()); //Solamente Recibe tipos de datos String

        //4to. Cálculos (Procesos)
        suma = num1 + num2;
        resta = num1 - num2;
        producto = num1 * num2;
        cociente = num1 / num2;

        //5to. Imprimir los resultados (Datos de Salida)
        Console.Write("La suma es: " + suma);
        Console.Write("\n");
        Console.Write("La resta es: " + resta);
        Console.Write("\n");
        Console.Write("El producto es: " + producto);
        Console.Write("\n");
        Console.Write("El cociente es: " + cociente);
    }
}

