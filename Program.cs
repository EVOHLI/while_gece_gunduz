using System;

namespace while_gece_gunduz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool parseResult=false;
            while (parseResult == false) ;
            {
                
               
                
                    Console.WriteLine("enter the time");
                    parseResult = int.TryParse(Console.ReadLine(), out int a);




                    if (parseResult == true && a <= 24)
                    {
                        //  int a = Convert.ToInt32(Console.ReadLine());//
                        if (a >= 6 && a <= 11)
                        {
                            Console.WriteLine("it is morning");
                        }
                        else
                        {
                            if (a >= 12 && a <= 17)
                            {
                                Console.WriteLine("it is afternoon");

                            }
                            else
                            {
                                if (a >= 18 && a <= 21)
                                {
                                    Console.WriteLine("it is night");
                                }
                                else
                                {
                                    Console.WriteLine("it is evening ");
                                }

                            }

                        }
                    }
                    else
                    {
                      
                        Console.WriteLine("sehvdir");
                    }


                }
            }
        }
    }

