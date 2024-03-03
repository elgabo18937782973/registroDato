using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minipro
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("bienvenido a compoPC, ¿desea registrarse?");
            Console.WriteLine("1.- si  2- no ");
           
            int opccion = int.Parse(Console.ReadLine());
            switch (opccion)
            {
                case 1:
                    regitrocliente();

                    break;
                    
            }
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("desea adquirir algunos de nuestros productos? ");
            Console.WriteLine("si, no");
            string res = Console.ReadLine().ToLower();

            Console.Clear();
            if (res == "si")
            {
                int op = 0;
                while (op != 7)
                {
                    Console.WriteLine("-----------BIENVENIDO AL MENU DE OPCCIONES-----------:");
                    Console.WriteLine(" 1.- placas bases  2.- procesadores ");
                    Console.WriteLine(" 3.- targeta grafica 4.- memoria ram");
                    Console.WriteLine(" 5.- discos duros   6.- factura  7.- salir");

                    Console.WriteLine("¿que opcion desea adquirir?");
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (op)
                    {
                        case (1):
                            PlacasBase();
                            Console.Clear();
                            break;

                        case (2):
                            Procesadores();
                            Console.Clear();
                            break;
                        case (3):
                            TargetaGrafica();
                            Console.Clear();
                            break;
                        case (4):
                            MemoriaRam();
                            Console.Clear();    
                            break;
                        case (5):
                            DiscoDuro();
                            Console.Clear();
                            break;
                        case 6:
                            facturacliente();
                            
                            break;



                    }
                }
                Console.WriteLine("gracias por visitarnos, hasta pronto");
            }

            else if (res == "no")
            {
                Console.WriteLine("entendido muchas gracias por su visita");
            }
            else
            {
                Console.WriteLine("error, porfavor ingrese ´si´ o ´no´");
            }

            Console.ReadKey();
        }
        static void regitrocliente()
        {
            Console.WriteLine("ingrese su nombre");

            string nom = Console.ReadLine();
            Console.WriteLine("ingrese su apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            string registro = ($"cliente : {nom} \nApellido: {apellido}\nEdad: {edad}");

            string archivo = @"D:\proyecto final\proF\proF.txt";
            File.AppendAllText(archivo,registro);
            Console.WriteLine("muchas gracias por regitrarse");

            Console.ReadKey();

        }
        static void facturacliente( )
        {
            Console.WriteLine("nombre");
            Console.WriteLine("apellido");
            Console.WriteLine("edad");
            Console.WriteLine("componentes comprados");
            Console.WriteLine();

        }
        public static void PlacasBase()
        {
            Console.WriteLine("------------------ P L A C A S  B A S E S -----------------------");
            Console.WriteLine("1.-Gigabyte X670 GAMING X AX v2 Socket AM5 ATX (259,90 $)");
            Console.WriteLine("2.-Gigabyte H510M H v2 Socket 1200 (68,90 $)");
            Console.WriteLine("3.-MSI B760 Gaming Plus Wifi Socket 1700 (158,90 $)");
            Console.WriteLine("4.-Gigabyte B550 Gaming X V2 Socket AM4 (114,89 $)");
            Console.WriteLine("5.-Asus TUF Gaming B760-Plus WiFi (198,90 $)");
            Console.WriteLine("6.-Asus TUF Gaming B650M-Plus Socket AM5 (220,90 $)");
            Console.WriteLine("¿cual desea adquirir?");
            double precio1 = 259.90;
            double precio2 = 68.90;
            double precio3 = 158.90;
            double precio4 = 114.89;
            double precio5 = 198.90;
            double precio6 = 220.90;
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("entendido, ¿cuantas Gigabyte X670 GAMING X AX v2 Socket AM5 ATX desea adquirir?");
                    double pla = double.Parse(Console.ReadLine());
                    double total = pla * precio1;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {total}$, gracias por su compra ");

                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("entendido, ¿cuantas Gigabyte H510M H v2 Socket 1200 desea adquirir?");
                    double plac = double.Parse(Console.ReadLine());
                    double total2 = plac * precio2;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {total2}$, gracias por su compra ");

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("entendido, ¿cuantas Gigabyte X670 GAMING X AX v2 Socket AM5 ATX desea adquirir?");
                    double placa = double.Parse(Console.ReadLine());
                    double total3 = placa * precio3;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {total3}$, gracias por su compra ");

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("entendido, ¿cuantas Gigabyte X670 GAMING X AX v2 Socket AM5 ATX desea adquirir?");
                    double placa1 = double.Parse(Console.ReadLine());
                    double total4 = placa1 * precio4;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {total4}$, gracias por su compra ");

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("entendido, ¿cuantas Gigabyte X670 GAMING X AX v2 Socket AM5 ATX desea adquirir?");
                    double placa2 = double.Parse(Console.ReadLine());
                    double total5 = placa2 * precio5;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {total5}$, gracias por su compra ");

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine("entendido, ¿cuantas Gigabyte X670 GAMING X AX v2 Socket AM5 ATX desea adquirir?");
                    double placa3 = double.Parse(Console.ReadLine());
                    double total6 = placa3 * precio6;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {total6}$, gracias por su compra ");

                    Console.ReadKey();
                    Console.Clear();
                    break;

            }

            
        }
        public static void Procesadores()
        {
            Console.WriteLine("------------------- P R O C E S A D O R E S --------------------------");
            Console.WriteLine("1.-Intel Core i5 12400F Socket 1700 (142,90 $)");
            Console.WriteLine("2.-Intel i5 11400 Socket 1200 (163,89 $)");
            Console.WriteLine("3.-AMD Ryzen 7 5800X Socket AM4 (202,90 $)");
            Console.WriteLine("4.-AMD Ryzen 5 8600G AM5(229,90 $)");
            Console.WriteLine("5.-INTEL CORE i3 12100 Socket 1700 (118,89 $)");
            Console.WriteLine("6.-AMD Ryzen 5 5600 Socket AM4 (122,90 $)");
            Console.WriteLine("¿cual desea adquirir?");
            double p1 = 142.90;
            double p2 = 163.89;
            double p3 = 202.90;
            double p4 = 229.90;
            double p5 = 118.89;
            double p6 = 122.90;

            int opcion1 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion1)
            {
                case 1:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double ad1 = double.Parse(Console.ReadLine());
                    double cabal1 = ad1 * p1;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {cabal1}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double ad2 = double.Parse(Console.ReadLine());
                    double cabal2 = ad2 * p2;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {cabal2}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double ad3 = double.Parse(Console.ReadLine());
                    double cabal3 = ad3 * p3;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {cabal3}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double ad4 = double.Parse(Console.ReadLine());
                    double cabal4 = ad4 * p4;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {cabal4}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double ad5 = double.Parse(Console.ReadLine());
                    double cabal5 = ad5 * p5;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {cabal5}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double ad6 = double.Parse(Console.ReadLine());
                    double cabal6 = ad6 * p6;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {cabal6}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;


            }
        }
        public static void TargetaGrafica()
        {
            Console.WriteLine("------------------- T A R G E T A S   G R A F I C A S --------------------------");
            Console.WriteLine("1.-Gigabyte RTX 4070 Ti Super Gaming OC 16GB GDDR6X DLSS3 (979,00 $)");
            Console.WriteLine("2.-Powercolor AMD Radeon RX 7800 XT Hellhound 16GB GDDR6 (552,90 $)");
            Console.WriteLine("3.-Tarjeta gráfica MSI GT 710 2GB 710-2-SL (45,90 $)");
            Console.WriteLine("4.-MSI RTX 4060 Ti Ventus 3X 8GB OC DLSS3 8GB GDDR6(469,89 $)");
            Console.WriteLine("5.-Powercolor AMD Radeon RX 7800 XT Red Devil 16GB GDDR6(621,90 $)");
            Console.WriteLine("6.-MSI GT1030 2GHD4 LP OC 2GB DDR4(79,90 $)");
            Console.WriteLine("¿cual desea adquirir?");
            double pre1 = 979.00;
            double pre2 = 552.90;
            double pre3 = 45.90;
            double pre4 = 469.989;
            double pre5 = 621.90;
            double pre6 = 79.90;

            int opcion3 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion3)
            {
                case 1:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double a1 = double.Parse(Console.ReadLine());
                    double t1 = a1 * pre1;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {t1}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double a2 = double.Parse(Console.ReadLine());
                    double t2 = a2 * pre2;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {t2}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double a3 = double.Parse(Console.ReadLine());
                    double t3 = a3 * pre3;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {t3}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double a4 = double.Parse(Console.ReadLine());
                    double t4 = a4 * pre4;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {t4}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double a5 = double.Parse(Console.ReadLine());
                    double t5 = a5 * pre5;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {t5}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double a6 = double.Parse(Console.ReadLine());
                    double t6 = a6 * pre6;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {t6}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;


            }

            Console.Clear();
        }
        public static void MemoriaRam()
        {
            Console.WriteLine("------------------- M E M O R I A S  R A M --------------------------");
            Console.WriteLine("1.-Kingston FURY BEAST 16GB DDR4 3200MHz CL16 Negro Intel XMP (41,90  $)");
            Console.WriteLine("2.-Kingston KVR26S19S8/8 8GB DDR4 2666MHz CL19 SODIMM(23,90 $)");
            Console.WriteLine("3.-Kingston Fury Beast RGB 8GB DDR4 3200MHz CL16 (36,91 $)");
            Console.WriteLine("4.-CRUCIAL CT16G4SFRA32A 16GB DDR4 3200MHz CL22 SODIMM(27,90 $)");
            Console.WriteLine("5.-Kingston Fury Beast 8GB DDR4 3200MHz CL16 Negro Intel XMP(21,90  $)");
            Console.WriteLine("6.-Kingston 8GB DDR3 1600MHz CL11 SODIMM(44,90 $)");
            Console.WriteLine("¿cual desea adquirir?");
            double pec1 = 41.90;
            double pec2 = 23.90;
            double pec3 = 36.91;
            double pec4 = 27.90;
            double pec5 = 21.90;
            double pec6 = 44.90;

            int opcion4 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion4)
            {
                case 1:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double b1 = double.Parse(Console.ReadLine());
                    double ta1 = b1 * pec1;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {ta1}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double b2 = double.Parse(Console.ReadLine());
                    double ta2 = b2 * pec2;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {ta2}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double b3 = double.Parse(Console.ReadLine());
                    double ta3 = b3 * pec3;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {ta3}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double b4 = double.Parse(Console.ReadLine());
                    double ta4 = b4 * pec4;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {ta4}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double b5 = double.Parse(Console.ReadLine());
                    double ta5 = b5 * pec5;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {ta5}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double b6 = double.Parse(Console.ReadLine());
                    double ta6 = b6 * pec6;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {ta6}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;


            }

            Console.Clear();

        }
        public static void DiscoDuro()
        {
            Console.WriteLine("------------------- D I S C O S  D U R O S --------------------------");
            Console.WriteLine("1.-WD Black SN850X 1TB M.2 + Disipador (99,90 $)");
            Console.WriteLine("2.-Seagate Barracuda 2TB 3.5 HDD( 57,90 $)");
            Console.WriteLine("3.-Seagate Expansion Portable 1TB 2.5 HDD(59,90 $)");
            Console.WriteLine("4.-WD Black SN850X 4TB M.2(334,89 $)");
            Console.WriteLine("5.-SSD WD Black SN770M 1TB M.2 2230(109,89 $)");
            Console.WriteLine("6.-Disco Duro Seagate Barracuda 4TB SATA III 3.5(93,90 $)");
            Console.WriteLine("¿cual desea adquirir?");
            double poc1 = 99.90;
            double poc2 = 57.90;
            double poc3 = 59.90;
            double poc4 = 334.89;
            double poc5 = 109.89;
            double poc6 = 93.90;

            int opcion5 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion5)
            {
                case 1:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double c1 = double.Parse(Console.ReadLine());
                    double tar1 = c1 * poc1;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {tar1}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double c2 = double.Parse(Console.ReadLine());
                    double tar2 = c2 * poc2;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {tar2}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double c3 = double.Parse(Console.ReadLine());
                    double tar3 = c3 * poc3;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {tar3}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double c4 = double.Parse(Console.ReadLine());
                    double tar4 = c4 * poc4;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {tar4}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double c5 = double.Parse(Console.ReadLine());
                    double tar5 = c5 * poc5;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {tar5}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine("entendido, ¿cuantas Intel Core i5 12400F Socket 1700 desea adquirir");
                    double c6 = double.Parse(Console.ReadLine());
                    double tar6 = c6 * poc6;
                    Console.Clear();
                    Console.WriteLine($"su precio total es de {tar6}$, gracias por su compra ");
                    Console.ReadKey();
                    Console.Clear();
                    break;


            }

            Console.Clear();
        }
    }


}

