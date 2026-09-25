using System;
//nombre
namespace CS3
{
    //Clase principal
    class Program
    {
        //funcion principal
       static void Main(string[]args)
        {
            //Sesion 6: Operadpres
            //declaracion e inicializacion
            double a = 1;
            double b = 2;
            double resultado = 0;

            //1. Operadores aritmeticos
            //a. suma +
            resultado = a + b;
            Console.WriteLine($"Suma: {resultado}");
            //b. resta -
            resultado = a - b;
            Console.WriteLine($"Resta: {resultado}");
            //c. multiplicacion *
            resultado  = a * b;
            Console.WriteLine($"Multiplicacion: {resultado}");
            //d. division /
            resultado = a / b;
            Console.WriteLine($"Division: {resultado}");
            //e. Resto(módulo) %
            resultado = a % b;
            Console.WriteLine($"Residuo: {resultado}");
            resultado += resultado + 9;
            Console.WriteLine($"Resultado: {resultado}");
            /*
            // Incrementos y decrementos
            2.operadores comparativos
            a. Igualdad: ==
            b. Diferencia !=
            c. Menor que: <
            d. Mayor que: >
            e Menor o igual que: <=
            f. Mayor o igual que: >=
            */
            //sesion 7: Operadores comparativos
            bool m = false;
            m = 4 == 10;
            Console.WriteLine($"Igualdad: {m}");
            m = 10 != 10;
            Console.WriteLine($"Diferencia: {m}");
            m = 10 > 4;
            Console.WriteLine($"mayor que: {m}");
            m = 4 < 5;
            Console.WriteLine($"Menor que: {m}");
            m = 6>= 5;
            Console.WriteLine($"Matyor o igual que: {m}");
            m = 6 <= 5;
            Console.WriteLine($"Menor o igual que: {m}");
            //a. Y (AND): &&
            //b. O (OR): ||
            bool e = false;
            bool f = true;
            bool d = false;
            d = e && f;
            Console.WriteLine($"Y: {d}");
            d = e || f;
            Console.WriteLine($"O: {d}");
        }//Término de la funcion principal
    }//termino de la clase principal
}//Termino del espacio de nombres
