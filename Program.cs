using System;

namespace Ejercicios1
{
    // Ej. 1
    class Coches
    {
        public string color = "negro";
        public void imprimirColor()
        {
            Console.WriteLine("Este coche es: " + this.color);
        }
    }
    // Ej. 2
    class Persona
    {
        public string name = "Pepe";
        public void pedirNombre()
        {
            Console.WriteLine("Ingresa nombre de usuario:");
            this.name = Console.ReadLine();
            Console.WriteLine("Hola, " + this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============");
            Console.WriteLine("Ejercicio #1");
            Console.WriteLine("============");
            // Crea una clase de coches de color negro y tres objetos de dicha 
            // clase(puedes elegir el nombre de cada uno). Cambia el valor del atributo color a rojo, 
            // verde y gris en cada objeto.
            Coches coche1 = new Coches();
            Coches coche2 = new Coches();
            Coches coche3 = new Coches();
            coche2.color = "verde";
            coche3.color = "gris";
            Console.WriteLine("coche1: " + coche1.color);
            Console.WriteLine("coche2: " + coche2.color);
            Console.WriteLine("coche3: " + coche3.color);
            // Siguiente paso: pasar la impresión de atributos (nombre + color) a un método
            coche1.imprimirColor();
            coche2.imprimirColor();
            coche3.imprimirColor();

            Console.WriteLine("============");
            Console.WriteLine("Ejercicio #2");
            Console.WriteLine("============");
            //  Crea un método sin parámetro que reciba el nombre del usuario por línea de comandos y 
            //  escriba dicho nombre en un mensaje “Hola, nombredeusuario.”
            Persona user = new Persona();
            Console.WriteLine("Valor por defecto de name: " + user.name);
            user.pedirNombre();
            Console.WriteLine("Valor actual de name: " + user.name);

            Console.WriteLine("============");
            Console.WriteLine("Ejercicio #3");
            Console.WriteLine("============");

            // Crea un programa que reciba dos números y realice las operaciones elementales de 
            // suma, resta, multiplicación y división. 
            // En caso de la división, debe expresar una excepción si el dividor es cero, ej: “No se puede dividir por cero”.
            int num1, num2;
            Console.WriteLine("Calculadora desde Main");
            Console.WriteLine("a. Suma b. Resta c. Multiplicación d. División");
            Console.WriteLine("Elige una operación");
            char operacion = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Introduce un número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (operacion)
            {
                case 'a':
                    Console.WriteLine("Suma : " + (num1 + num2));
                    break;
                case 'b':
                    Console.WriteLine("Resta : " + (num1 - num2));
                    break;
                case 'c':
                    Console.WriteLine("Producto : " + (num1 * num2));
                    break;
                case 'd':
                    Console.WriteLine("División : " + (num1 / num2));
                    break;
            }
            Console.WriteLine("============");
            Console.WriteLine("Ejercicio #4");
            Console.WriteLine("============");

            //   Crea un programa que calcule los gastos del hogar fácilmente. 
            //   Dicho programa debe permitir al usuario introducir un concepto(string), 
            //    ej. “Luz” o “Factura de luz”, y un valor numérico(float o double) en euros, 
            //    ej. 60.1, para cada “gasto” habitual en el hogar. Una vez terminada 
            //    la lista(máximo 5 - 10 elementos o menos), el programa debe hacer la suma 
            //    de las cantidades y escribir dicha suma en pantalla con el mensaje 
            //   “Gasto mensual: valordesuma €.” o similar. Pista: podéis usar arrays.

            Console.WriteLine("Introduce concepto del gasto: ");
            string concepto = Console.ReadLine();
            Console.WriteLine("Introduce valor del gasto: ");
            float gasto = float.Parse(Console.ReadLine());

            // Escribir concepto y valor
            Console.WriteLine("Concepto | Gasto");
            Console.Write(concepto + "\t\t");
            //string strGasto = Convert.ToString(gasto);
            //string strGasto = gasto.ToString("#0.00");
            Console.WriteLine("{0:F2}", gasto); // Queda pendiente resolver punto decimal
            //Console.Write(gasto);
        }
    }
}
