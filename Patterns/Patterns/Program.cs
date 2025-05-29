class program
{
    public static void Pattern1(int num)
    {

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {

                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    public static void Pattern2(int num)
    {
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    public static void Pattern3(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    public static void Pattern4(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
    public static void Pattern5(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            for (int j = 0; j < num - i + 1; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    public static void Pattern6(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= num - i + 1; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }

    public static void Pattern7(int num)
    {
        for (int i = 0; i < num; i++)
        {
            //space (5-0-1)
            for (int j = 0; j < num - i - 1; j++)
            {
                Console.Write(" ");
            }
            //star (2*i+1)
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");

            }
            //space (5-0-1)
            for (int j = 0; j < num - i - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static void Pattern8(int num)
    {
        for (int i = 0; i < num; i++)
        {
            //space
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            //star
            for (int j = 0; j < 2 * num - (2 * i + 1); j++)
            {
                Console.Write("*");
            }
            //space
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");

            }
            Console.WriteLine();
        }
    }

    public static void Pattern9(int num)
    {
        for (int i = 1; i <= 2 * num - 1; i++)
        {
            int star = i;
            if (i > num)
            {
                star = 2 * num - i;
            }
            for (int j = 1; j <= star; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }

    public static void Pattern10(int num)
    {
        int star = 1;
        for (int i = 0; i < num; i++)
        {
            if (i % 2 == 0)
            {
                star = 1;
            }
            else
            {
                star = 0;
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write(star);
                star = 1 - star;
            }
            Console.WriteLine();
        }
    }

    public static void Pattern11(int num)
    {
        int space = 2 * (num - 1);
        for (int i = 1; i <= num; i++)
        {
            //number
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            //space
            for (int j = 1; j <= space; j++)
            {
                Console.Write(" ");
            }

            //number
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
            space -= 2;
        }
    }

    public static void Pattern12(int num)
    {
        int n = 1;
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(n);
                n = n + 1;
            }
            Console.WriteLine();
        }
    }
    public static void Pattern13(int num)
    {
        for (int i = 0; i <= num; i++)
        {
            for (char chr = 'A'; chr <= 'A' + i; chr++)
            {
                Console.Write(chr);
            }
            Console.WriteLine();
        }
    }

    public static void Pattern14(int num)
    {
        for (int i = 0; i <= num; i++)
        {
            for (char chr = 'A'; chr <= 'A' + num - i; chr++)
            {
                Console.Write(chr);
            }
            Console.WriteLine();
        }
    }

    public static void Pattern15(int num)
    {
        for (int i = 0; i < num; i++)
        {
            char chr = (char)('A' + i);
            //var n = chr + i;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(chr);
            }
            Console.WriteLine();
        }
    }

    public static void Pattern16(int num)
    {
        for (int i = 0; i < num; i++)
        {
            //space
            for (int j = 0; j < num - i - 1; j++)
            {
                Console.Write(" ");
            }

            //star
            char chr = 'A';
            int breakpoint = (2 * i + 1) / 2;
            for (int j = 1; j <= 2 * i + 1; j++)
            {
                Console.Write(chr);
                if (j <= breakpoint)
                {
                    chr++;
                }
                else
                {
                    chr--;
                }
            }

            //space
            for (int j = 0; j < num - i - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static void Pattern17(int num)
    {
        for (int i = 0; i <= num; i++)
        {

            for (char chr = (char)('E' - i); chr <= 'E'; chr++)
            {
                Console.Write(chr);
            }

            Console.WriteLine();
        }
    }

    public static void Pattern18(int num)
    {

        int space = 0;

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num - i; j++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < space; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < num - i; j++)

            {
                Console.Write("*");
            }
            space += 2;
            Console.WriteLine();
        }
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }

            for (int j = 0; j < space - 2; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            space -= 2;
            Console.WriteLine();
        }
    }

    public static void Pattern19(int num)
    {
        int space = 2 * num - 2;

        for (int i = 1; i <= 2 * num - 1; i++)
        {
            int star = i;
            if (i > num)
            {
                star = 2 * num - i;
            }
            //Star
            for (int j = 1; j <= star; j++)
            {
                Console.Write("*");

            }
            //space
            for (int j = 1; j <= space; j++)
            {
                Console.Write(" ");
            }
            //Star
            for (int j = 1; j <= star; j++)
            {
                Console.Write("*");
            }
            if (i < num)
            {
                space -= 2;
            }
            else
            {
                space += 2;
            }
            Console.WriteLine();
        }
    }

    public static void Pattern20(int num)
    {
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                if (i == 0 || j == 0 || i == num - 1 || j == num - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }
    }

    public static void Pattern21(int num)
    {
        for (int i = 0; i < 2 * num - 1; i++)
        {
            for (int j = 0; j < 2 * num - 1; j++)
            {
                int top = i;
                int left = j;
                int right = (2 * num - 2) - i;
                int down = (2 * num - 2) - j;
                int size = Math.Min(Math.Min(top, right), Math.Min(left, down));
                Console.Write(num - size + "");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        //int n;
        Console.WriteLine("Please enter the Number");
        var num = Convert.ToInt32(Console.ReadLine());
      
        Pattern15(num);
     
    }
}
