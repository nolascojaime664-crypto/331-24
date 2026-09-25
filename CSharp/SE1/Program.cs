using System;
namespace SE1

{
    class Program
    {
        static void Main(string[] args)
       
       
        //2. sintaxis
        bool a;
        int numero;
        

        //3. interpolación
        a = true;
        numero = 10;
        Console.WriteLine($"Booleano +: [{a}]");
        Console.WriteLine($"Número +: [{numero}]");

        //4. Incrementos y decrementos
        int m = 0;
        int n = -1;
        m += 1;
        n-= 3;

        //5. Modulo
        int residuo = 40 % 16;
        Console.WriteLine($"Residuo: [{residuo}]");

        //6. Operadores aritmeticos
        double operacion = 0;
        operacion = ((30 + 8 - 2) / 2) * -1;
        Console.WriteLine($"Operación: [{operacion}]");

        //7. interruptores
        bool interruptor1 = false;
        bool interruptor2 = true;
        bool bombilla = false;
        if (interruptor1 && interruptor2)
        {
            bombilla = true;
            Console.WriteLine($"Bombilla: [{bombilla}]");
        }
        else
        {
            bombilla = false;
            Console.WriteLine($"Bombilla: [{bombilla}]");

        }

        //8. asueto
            int dia = 16;
            string mes = "septiembre";
            if (dia == 16 && mes == "septiembre")
            {
                Console.WriteLine("HAsueto");
            }
            else
            {
                Console.WriteLine("Sin definir");
            }

            //9. 
            bool resultado = (7 > 11) && 9!= 0;
            Console.WriteLine($"Resultado: [{resultado}]");
    }
}