using System;
using System.Collections.Generic;

namespace day6_multi_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //analoģija = tabula ar rindām un kolonnām
            //atmiņā tiek rezervēts viens bloks ar garumu 2x2 int-i
            //indeksi no 0 - max-1 {0 - 1}
            int[,] tabula = new int[2,2];

            tabula[0, 0] = 5;

            int sk = tabula[0, 0];

            int[,] tabula2d = { {1,2}, {3,4} };


            //atmiņā tiek rezervēts viens bloks ar garumu 2x3x4 int-i
            int[,,] tabula3d = new int[2,3,4];

            //int[,,] tabula3d_inits = { { } };

            //izvadīt visus tabula2d elementus uz ekrāna 
            for (int i = 0; i < tabula2d.GetLength(0); i++)
            {
                for (int j = 0; j < tabula2d.GetLength(1); j++)
                {
                    //Console.WriteLine(tabula2d[i, j]);//kādā secībā izvadīs ?
                    Console.Write(tabula2d[i, j] + " ");//kādā secībā izvadīs ?
                }
                Console.WriteLine();
            }


            //uzstādīt tabula3d elementu vērtības
            //tabula3d.GetLength(0) rezultāts ir skaitlis, elementu skaits dimensijā !
            for (int i = 0; i < tabula3d.GetLength(0); i++)
            {
                for (int j = 0; j < tabula3d.GetLength(1); j++)
                {
                    for (int k = 0; k < tabula3d.GetLength(2); k++)
                    {
                        tabula3d[i, j, k] = i + j + k;
                        Console.WriteLine(tabula3d[i, j, k]);//kādā secībā izvadīs ?
                    }
                }
            }

            //masīvs masīvā; jagged arr

            //inicializējam 3 masīvus, kuri katrs ir masīvs
            //visi 3 ir null
            int[][] jagged_arr = new int[3][];


            //inizializējam visus  3 masīvus
            jagged_arr[0] = new int[1];
            //kods
            //kods
            //kods => aprēķinam jagged_arr[1] izmēru
            //kods
            //kods
            //kods
            jagged_arr[1] = new int[2];
            //kods
            //kods
            //kods
            //kods => aprēķinam jagged_arr[2] izmēru
            //kods
            jagged_arr[2] = new int[3];
            //kods
            //kods
            //kods
            //kods
            //kods

            //trīs bloki ar garumu 2x3x4 int-i


            //jagged_arr[0][0]
            //jagged_arr[0][1]
            //jagged_arr[0][2]



            //piešķiru vērtību
            jagged_arr[0][0] = 5;

            for (int i = 0; i < jagged_arr.Length; i++)
            {
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    jagged_arr[i][j] = 5;
                    //int sk = 
                }
            }

            jagged_arr[2] = new int[35];


            //analoģija ar string

            string[] str = new string[10];

            str[0] = "12345"; //str[0].Length
            str[1] = "777789789";

            //kods
            //kods
            str[1] = "kkas cits                            !!";
            //kods
            //kods


            Console.WriteLine(str[0][0]);


            int[][] jagged_arr_2 =
            {
                new int [] {1,2,3 },            //nulltais
                new int [] {4,5,6,16,17 },      //pirmais
                new int [] {7,8,9,10,12,13,14 } //otrais
            };


            int izm1 = jagged_arr_2.Length;



            //piemērs

            DateTime starts = DateTime.Now;

             /*           
            int[] masivs = new int[12345];

            for (int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = i;

                if (masivs[i] % 2 != 0) // ja ir nepāra skaitlis
                {
                    Console.WriteLine("Nepaara skaitlji: ");
                    Console.WriteLine(masivs[i]);
                }
            }
            */

            DateTime beigas = DateTime.Now;
            TimeSpan starpiba = beigas - starts;


            Console.WriteLine("Koda izpilde aizņēma :" + starpiba);


            //izmantot listi, kurā ievietot pāra skaitļus
            //vai izvadīs pareizi ?

            starts = DateTime.Now;
            /*
            List<int> para = new List<int>();
            Console.WriteLine("Paara skaitlji: ");

            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] % 2 == 0) // ja ir pāra skaitlis
                {
                    para.Add(masivs[i]);
                }
                
            }

            foreach (var paris in para)
            {
                Console.WriteLine(paris);
            }
            */

            beigas = DateTime.Now;


            starpiba = beigas - starts;

            Console.WriteLine("Koda [2] izpilde aizņēma :" + starpiba);


            //ievadīt no konsoles divus skaitļus un samainīt tos vietām
            //!!! NAV MASĪVS 

            //skaitlis1 no konsoles
            //skaitlis2 no konsoles

            //samainīt vietām skaitlis1 ar skaitlis2
            //izvadīt skaitlis1 ar skaitlis2 vērtības

            /*
            int sk1 = 0, sk2 = 0, apmanits = 0;


            sk1 = Int32.Parse(Console.ReadLine());
            sk2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("sk1 =" + sk1 + "; sk2 =" + sk2);
            apmanits = sk1;

            sk1 = sk2;
            sk2 = apmanits;

            Console.WriteLine("sk1 =" + sk1 + "; sk2 =" + sk2);
            */

            //1. uzrakstīt metodi, kura saņem kā parametru 1 stringu, ievadītu no konsoles
            //   un sadala to vārdos

            //string param = "vaards1 vards2 vaards3";
            //string[] rez = param.Split(' ');

            Console.WriteLine("Ievadi datus ...");
            string teikums = Console.ReadLine();
            //string[] vardi = Atgriez(teikums);

            //2.
            //uzrakstīt metodi, kas string (teikums) pārtaisa par skaitļu masīvu
            //string masiivs[0/1/2/3/4/5] 


            //byte viens = (byte) ievade[0];
            byte[] baiti = StringToIntArray2(teikums);

            //sašifrēsim baitu masīvu
            Crypt(baiti, 100);
            Console.WriteLine("Sašifrēti dati : [" + ByteArrayToString(baiti) + "]");


            //atšifrēti ar nepareizu atslēgu
            Crypt(baiti, 100);
            Console.WriteLine("Atšifrēti dati : [" + ByteArrayToString(baiti) + "]");





            Console.WriteLine("Hello World!");
        }



        static string ByteArrayToString(byte[] byte_data)
        {
            string rez = "";
            for (int i = 0; i < byte_data.Length; i++)
            {
                //audzējam rez, pieskaitot pārveidotu baitu par char
                rez += Convert.ToChar(byte_data[i]);
            }
            return rez;
        }



        static void Crypt(byte[] baiti, int atsleega)
        {
            for (int i=0; i< baiti.Length; i++ )
            {
                baiti[i] = (byte)(baiti[i] ^ atsleega);
            }

        }


        static byte[] StringToIntArray2(string string1)
        {
            byte[] rez = new byte[string1.Length];

            for (int i = 0; i < string1.Length; i++)
            {
                rez[i] = Convert.ToByte(string1[i]);
            }
            return rez;
        }


        static byte[] StringToIntArray(string string1)
        {
            string[] split_string = string1.Split();

            byte[] rez = new byte[split_string.Length];

            for (int i = 0; i < split_string.Length; i++)
            {
                rez[i] = Convert.ToByte(split_string[i]);
            }
            return rez;
        }

        static string[] Atgriez(string param)
        {

            string[] rez = param.Split(' ');
            return rez;
        }

    }
}
