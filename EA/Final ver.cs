using System;

namespace EA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string username = "";
            string username_1 = "admin";
            string password = "";
            string password_1 = "password";

            bool LoginSuccess = false;

            while (LoginSuccess = true)
            {
                Console.WriteLine("username : ");
                username = Console.ReadLine();
                Console.WriteLine("password : ");
                password = Console.ReadLine();

                if (username == username_1 && password == password_1)
                {
                    LoginSuccess = true;
                    Menu(a);
                }
                else if (username != username_1)
                { Console.WriteLine("username incorrect \n"); }
                else if (password != password_1)
                { Console.WriteLine("password incorrect \n"); }

            }
        }

        static void Menu(string c)
        {

            string x;
            string y;

            int a1 = 0;
            int b1 = 0;

            double a = 0;
            double b = 0;

            bool x_2 = true;
            bool y_2 = true;

            goto start;

        begin:
            if (c == "a")
            {
                Input(out x, out y);



                x_2 = int.TryParse(x, out a1);
                y_2 = int.TryParse(x, out b1);
                a = Convert.ToDouble(x);
                b = Convert.ToDouble(y);



                if (x_2 == false || y_2 == false)
                {
                    Console.WriteLine("\nError");
                    a1 = 0;
                    b1 = 0;
                    goto start;

                }
                else
                {
                    a1 = Convert.ToInt32(x);
                    b1 = Convert.ToInt32(y);

                    if (a1 - a != 0 || b1 - b != 0 || a1 < 0 || b1 < 0)
                    {


                        Console.WriteLine("\nError");
                        a1 = 0;
                        b1 = 0;
                        goto start;


                    }

                    else
                    {
                       
                        goto start;
                    }
                }

                

            }

            else if (c == "b")
            {
                Console.WriteLine("The Result is " + Add(a1, b1) + "\n");
                goto start;
            }
            else if (c == "c")
            {
                Console.WriteLine("The Result is " + Minus(a1, b1) + "\n");
                goto start;
            }
            else if (c == "d")
            {
                Console.WriteLine("The Result is " + Times(a1, b1) + "\n");
                goto start;
            }
            else if (c == "e")
            {
                Console.WriteLine("The Result is " + Div(a1, b1) + "\n");
                goto start;
            }

            else if (c == "q")
            {

                goto end;
            }
            else
            {
                Console.WriteLine("Wrong!!!\n");
                goto start;
            }

        start:
            Console.WriteLine("\n First: " + a1 + " Second: " + b1);
            Console.WriteLine(" [a] Input \n");
            Console.WriteLine(" [b] Add ");
            Console.WriteLine(" [c] minus ");
            Console.WriteLine(" [d] times ");
            Console.WriteLine(" [e] div \n");
            Console.WriteLine(" [q] Quit ");
            Console.WriteLine(" Choice: ");

            c = Console.ReadLine();

            goto begin;

        end:
            Console.WriteLine(" Bye!!! ");
        }

        static void Input(out string x, out string y)
        {
            Console.WriteLine("First number");
            x = Console.ReadLine();

            Console.WriteLine("Second number");
            y = Console.ReadLine();
        }
        static int Add(int a1, int b1)
        {
            int c_1;
            c_1 = a1 + b1;
            return c_1;
        }
        static int Minus(int a1, int b1)
        {
            int c_1;
            c_1 = a1 - b1;
            return c_1;
        }
        static int Times(int a1, int b1)
        {
            int c_1;
            c_1 = a1 * b1;
            return c_1;
        }
        static int Div(int a1, int b1)
        {
            int c_1 = 0;
            if (a1 <= 0 || b1 <= 0)
            {
                a1 = 0;
                b1 = 0;
                Console.WriteLine("\nError ");
            }
            else if (a1 % b1 != 0)
            { Console.WriteLine("\n The Reminder is " + (a1 % b1)); }
            else if ((a1 == 0 || b1 == 0))
            { c_1 = a1 / b1; }

            return c_1;
        }


    }
}
