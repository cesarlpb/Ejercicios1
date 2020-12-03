using System;
using System.Linq;

namespace Ejercicios1
{

    // Ej. 1
    public class Coches
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
            Console.WriteLine("Elige Ejercicio para resolver:");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            Console.WriteLine("5. Ejercicio 5");

            int ej = Convert.ToInt32(Console.ReadLine());
            switch (ej)
            {
                case 1:
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
                    break;
                case 2:
                    Console.WriteLine("============");
                    Console.WriteLine("Ejercicio #2");
                    Console.WriteLine("============");
                    //  Crea un método sin parámetro que reciba el nombre del usuario por línea de comandos y 
                    //  escriba dicho nombre en un mensaje “Hola, nombredeusuario.”
                    Persona user = new Persona();
                    Console.WriteLine("Valor por defecto de name: " + user.name);
                    user.pedirNombre();
                    Console.WriteLine("Valor actual de name: " + user.name);
                    break;
                case 3:
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
                    break;
                case 4:
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

                    int size = 10;
                    Console.WriteLine("Introduce {0} conceptos de gastos: ", size);
                    string[] concepto = new string[size]; 
                    int[] gastos = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write("Introduce concepto " + i + ":");
                        concepto[i] = Console.ReadLine();
                        Console.Write("\nIntroduce gasto " + i + ":");
                        gastos[i] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Id | Concepto | Gasto");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write("\n" + i + " " + concepto[i]);
                        Console.Write("\t  ");
                        Console.Write(gastos[i]);
                    }
                    Console.WriteLine("\nGasto mensual: " + gastos.Sum() + " EUR.");
                    //Console.WriteLine("Introduce valor del gasto: ");
                    //int gasto = Convert.ToInt32(Console.ReadLine());

                    // Escribir concepto y valor
                    //Console.WriteLine("Concepto | Gasto");
                    //Console.Write(concepto + "\t   ");
                    //string strGasto = Convert.ToString(gasto);
                    //string strGasto = gasto.ToString("#0.00");
                    //Console.WriteLine(gasto); 
                    // Queda pendiente resolver punto decimal
                    // Console.Write(gasto);
                    break;
                case 5:
                    // Crea un todo list o memo sencillo en consola.
                    // Este programa debe aceptar máximo 5 - 10 entradas(to dos) como “Llamar a Pepe” y 
                    // un valor(string) del momento para hacer la acción “2:30 PM”. 
                    // Además, el programa debe permitir editar y borrar entradas. 
                    // Desde consola, el programa debe mostrar los To Dos existentes, crear, editar y 
                    // borrar.Puedes usar arrays de 5 elementos para realizar estas acciones.

                    Console.WriteLine("============");
                    Console.WriteLine("Ejercicio #5");
                    Console.WriteLine("============");

                    // Variables globales Ej.5
                    char opcion;
                    int len = 3;
                    string[] memo = new string[len];
                    string[] hora = new string[len];

                    elegirOpcion();

                    switch (opcion){
                        case 'c':
                            Console.WriteLine(" === Crear ===");
                            crearMemo();
                            leerMemo();
                            break;
                        case 'e':
                            Console.WriteLine(" === Editar ===");
                            editarMemo();
                            leerMemo();
                            break;
                        case 'b':
                            Console.WriteLine(" === Borrar ===");
                            borrarMemo();
                            leerMemo();
                            break;
                        case 'l':
                            Console.WriteLine(" === Leyendo ===");
                            leerMemo();
                            break;
                        case 'x':
                            Console.WriteLine("Hasta luego desde Code.");
                            Console.ReadKey();
                            break;
                    }
                    char elegirOpcion()
                    {
                        Console.WriteLine("Elige una de las opciones");
                        Console.WriteLine("c. Crear, e. Editar, b. Borrar, l. Leer, x. Salir");
                        opcion = Convert.ToChar(Console.ReadLine());
                        return opcion;
                    }
                    void crearMemo()
                    {
                        Console.WriteLine("Introduce {0} cosas por hacer: ", len);
                        for (int i = 0; i < len; i++)
                        {
                            Console.Write("Introduce to do (memo) " + i + ":");
                            memo[i] = Console.ReadLine();
                            Console.Write("\nIntroduce hora " + i + ":");
                            hora[i] = Console.ReadLine();
                            Console.WriteLine("\n");
                        }
                    }
                    void leerMemo()
                    {
                        Console.WriteLine("To do <> Hora");
                        for (int i = 0; i < len; i++)
                        {
                            Console.Write("\n" + i + " " + memo[i]);
                            Console.Write("\t  ");
                            Console.Write(hora[i]);
                        }
                    }
                    void editarMemo()
                    {
                        Console.WriteLine("Elige entrada para editar: ");
                        Console.WriteLine("(Introduce número del 0 al {0})", len-1);
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce nuevo memo: ");
                        memo[index] = Console.ReadLine();
                        Console.WriteLine("Introduce nueva hora: ");
                        hora[index] = Console.ReadLine();
                        Console.WriteLine("Edición completada.");
                    }
                    void borrarMemo()
                    {
                        Console.WriteLine("Borrando");
                        for (int i = 0; i < len; i++)
                        {
                            memo[i] = "";
                            hora[i] = "";
                        }
                        Console.WriteLine("Los memos se han borrado.");
                    }
                    
                    // Añadir guardar en log o .txt el memo y la hora

                    break;

            }

        }
    }
}
