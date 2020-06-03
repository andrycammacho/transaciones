using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
namespace pavel
{
    class Program
    {
        static void Main(string[] args)
        {
            manejador transa = new manejador();
            
            List<registro> transation = null;




            string elige = "";
            bool cual = true;

            Console.Clear();
            while (cual)
            {
                Console.Clear();
                Console.WriteLine("tipo de transaccion");
                Console.WriteLine("1-- transaccion aprobada");
                Console.WriteLine("2--transaccion rechazada");
                Console.WriteLine("3--ver transaciones aprobadas" );
                Console.WriteLine("4--ver transaciones rechazadas");
                Console.WriteLine("5--Borrar transacciones");
                Console.WriteLine("6--salir");
                elige = Console.ReadLine();

             

                switch (elige)
                {
                    case "1":
                        Console.Clear();
                      
                        registro ob = new registro();
                        double tra = ob.NumTran;
                        Console.WriteLine("transaccion aprobada");
                        Console.WriteLine("Nombre del cliente");
                        ob.Nombre = Console.ReadLine();

                        Console.WriteLine("ingrese el numero de transaccion");
                        ob.NumTran = double.Parse(Console.ReadLine());

 
                        Console.WriteLine("ingrese el monto");
                        ob.Monto = double.Parse(Console.ReadLine());

                        transa.agregar(ob);


                        break;



                    case "2":
                        Console.Clear();
                        registro ob1 = new registro();
                        Console.WriteLine("transaccion rechaza");
                        Console.WriteLine();
                        Console.WriteLine("Nombre del cliente");
                        ob1.Nombre = Console.ReadLine();

                        Console.WriteLine("ingrese el numero de transaccion");
                        ob1.NumTran = double.Parse(Console.ReadLine());

                       

                        Console.WriteLine("ingrese el monto");
                        ob1.Monto = double.Parse(Console.ReadLine());
                        transa.agregar(ob1);
                        break;

                       case "3":
                        Console.Clear();
                        transation = transa.obtener();       
                        Console.WriteLine("transaccion aprovada");
                        Console.WriteLine("No \t\t Nombre: \t\t numero:\t\t Monto:");

                        int n = 1;
                 
                         foreach(registro valor in transation)
                        {


                            Console.WriteLine("{3} \t\t {0}     \t\t  {1} \t\t          {2}", valor.Nombre, valor.NumTran, valor.Monto,n);
              
                            n++;


                        }
                        Console.ReadKey();



                        break;
                        case "4":
                        List<registro> transac3 = transa.obtener();
                        Console.Clear();
                        Console.WriteLine("transaccion rechazadas");
                        Console.WriteLine("No \t\t Nombre: \t\t numero:\t\t Monto:");

                        int noo1 = 1;

                        for (int x = 0; x < transac3.Count; x++)
                        {

                            Console.WriteLine("{3} \t\t {0}     \t\t  {1} \t\t          {2}", transac3[x].Nombre, transac3[x].NumTran, transac3[x].Monto, noo1);


                            noo1++;


                        }
                        Console.ReadKey();

                        break;
                       case "5":
                        List<registro> transac2 = transa.obtener();
                        Console.Clear();
                        Console.WriteLine("transaccion aprovada");
                        int No1 = 1;
                        Console.WriteLine("No \t\t Nombre: \t\t numero:\t\t Monto:");



                        for (int x = 0; x < transac2.Count; x++)
                        {



                            Console.WriteLine("{3} \t\t {0}     \t\t  {1} \t\t          {2}", transac2[x].Nombre, transac2[x].NumTran, transac2[x].Monto, No1);



                            No1++;

                        }
                        Console.WriteLine("---------");
                        Console.WriteLine("Ingrese el numero de la transaccion a borrar");
                        int num1 = 0;
                        int.TryParse(Console.ReadLine(), out num1);
                        if (num1 > transa.total())
                        {
                            Console.WriteLine("Esa transaccion no existe");
                        }
                        else
                        {
                            transa.borrar(num1 - 1);
                            Console.WriteLine("Persona borrada precione una tecla para volver");
                        }

                        Console.ReadKey();

                        break;

                    case "6":

                        cual = false;
                        Console.WriteLine("Adios..");

                       

                        break;
                    default:
                        Console.WriteLine("Opcion invalidad!!");
                        Console.ReadKey();

                        break;
                }

            }
            Console.ReadKey();


        }
    }
}
