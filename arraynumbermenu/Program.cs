using System.Linq.Expressions;

namespace arraynumbermenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag=true;
            int[] numbers =null;
            int listlength=0;
            while (flag)
            {
                Console.WriteLine("Which Option Do U Choose?");
                Console.WriteLine();    
                Console.WriteLine("1.Make New List");
                Console.WriteLine("2.Recive The Elements");
                Console.WriteLine("3.View Elemnts");
                Console.WriteLine("4.Array Sort");
                Console.WriteLine("5.Reverse Array");
                Console.WriteLine("6.Search Element");
                Console.WriteLine("7.Delete Element");
                Console.WriteLine("8.Exit");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    if (numbers==null)
                    {
                       
                        Console.WriteLine("Please wirte how many numbers do you want to add to array: ");
                        listlength = int.Parse(Console.ReadLine());
                        numbers = new int[listlength];
                       
                    }
                    else
                    {
                        Console.WriteLine("You Had an Array!");
                        Thread.Sleep(1100);
                        Console.Clear();
                    }
                    
                    Console.Clear();
                }
                if (option == 2)
                {
                    Console.Clear();
                    if(numbers!=null)
                    {
                        Console.WriteLine("How do want to add numers to the Array" +
                      "\n" +
                      "1.Random Numbers\n" + "2.Custom Numbers");
                        int select = int.Parse(Console.ReadLine());
                        if (select == 1)
                        {
                            Random rnd = new Random();

                            for (int i = 0; i < listlength; i++)
                            {
                                int randomnumbers = rnd.Next(10, 100);
                                numbers[i] = randomnumbers;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < listlength; i++)
                            {
                                Console.WriteLine("write the nubers do u want:");
                                int number = int.Parse(Console.ReadLine());
                                numbers[i] = number;
                            }
                        }
                    }
                  else
                    {
                        Console.WriteLine("First Make An Array");
                        Thread.Sleep(1100);


                    }
                    Console.Clear();
                }

                if (option == 3)
                {
                    Console.Clear();
                    if (numbers != null)
                    {
                        for (int i = 0; i < listlength; i++)
                        {
                            Console.WriteLine("{0}: {1} ", i, numbers[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("First Make An Array");
                        Thread.Sleep(1100);

                        Console.Clear();
                    }
                }
                if (option == 4)
                {
                    Console.Clear();
                    if (numbers != null)
                    {
                        Console.WriteLine("How do want to Sort numers to the Array" +
                        "\n" +
                        "1.Soodi\n" + "2.Nozooli");
                        int select1 = int.Parse(Console.ReadLine());
                        if (select1 == 1)
                        {
                            Array.Sort(numbers);
                            for (int i = 0; i < listlength; i++)
                            {
                                Console.WriteLine("{0}: {1} ", i, numbers[i]);
                            }
                        }
                        if (select1 == 2)
                        {
                            Array.Sort(numbers);
                            Array.Reverse(numbers);
                            for (int i = 0; i < listlength; i++)
                            {
                                Console.WriteLine("{0}: {1} ", i, numbers[i]);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("First Make An Array");
                        Thread.Sleep(1100);

                    }

                    Console.Clear();
                }
                if(option == 5)
                {
                    Console.Clear();
                    if (numbers != null)
                    {
                        Array.Reverse(numbers);
                        for (int i = 0; i < listlength; i++)
                        {
                            Console.WriteLine("{0}: {1} ", i, numbers[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("First Make An Array");
                        Thread.Sleep(1100);

                    }
                   
                    Console.Clear();
                }
                if (option == 6)
                {
                    Console.Clear();
                    if (numbers != null)
                    {
                        Console.WriteLine("give a number to search in Array");
                        int numberToSearch = int.Parse(Console.ReadLine());

                        int index = Array.IndexOf(numbers, numberToSearch);

                        if (index != -1)
                        {
                            Console.WriteLine($"Number {numberToSearch} found at index {numbers}.");
                        }
                        else
                        {
                            Console.WriteLine($"Number {numberToSearch} not found in the array.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("First Make An Array");
                        

                    }
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                if (option == 7)
                {
                    Console.Clear();
                    if (numbers != null)
                    {
                        for (int i = 0; i < listlength; i++)
                        {
                            Console.WriteLine("{0}: {1} ", i, numbers[i]);
                        }
                        Console.WriteLine("which index do u want to delete");
                        int deleteindex = int.Parse(Console.ReadLine());
                        for (int i = deleteindex; i < listlength - 1; i++)
                        {
                            if (numbers[i + 1] != null)
                            {
                                int temp = numbers[i + 1];
                                numbers[i + 1] = numbers[i];
                                numbers[i] = temp;
                            }
                        }
                        listlength--;
                    }
                    else
                    {
                        Console.WriteLine("First Make An Array");
                        Thread.Sleep(1100);


                    }
                    Console.Clear();
                }
                if(option == 8)
                {
                    flag = false;
                    Console.Clear();
                  
                }
            }
            Console.WriteLine("Good Bye :)");
            Console.ReadKey();
            Environment.Exit(100);
        }
    }
}
