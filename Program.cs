using System;

namespace test;

class Program
{
        public static void Main(string[] args)
        {
                int a, b;
                a = 0;
                b = 0;
                int[] feld = {7, 2, 1, 3, 6, 4};
                Console.WriteLine(Aufgabe2(feld, out a, out b));
                Console.WriteLine("Start index: " + a + " Ziel Index: " + b);
        }

        static int Aufgabe1()
        {
                int count = 0, third, second, first;
                

                for(int i = 100; i < 1000; i++)
                {
                        int c = i;

                        third = c % 10;
                        c /= 10;
                        second = c % 10;
                        c /= 10;
                        first = c;

                        if(third > second && second > first)
                        {
                                count++;
                        }
                }
        return count;
        }

        static int Aufgabe2(int[] arr, out int i_start, out int i_ziel)
        {
                int erg, start, ziel, index;
                i_ziel = 0;
                i_start = 0;

                start = arr[0];

                for(int i = 1; i < arr.Length; i++)
                {
                        if(start > arr[i])
                        {
                            start = arr[i];
                            i_start = i;
                        }
                }

                ziel = arr[i_start];

                for(int i = i_start + 1; i < arr.Length; i++)
                {
                        if(ziel < arr[i])
                        {
                                ziel = arr[i];
                                i_ziel = i;
                        }
                }

                erg = ziel - start;

                return erg;
        }

        

}
