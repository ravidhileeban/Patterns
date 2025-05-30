class program
{
    #region Pattern 1: Solid Square
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
    #endregion     Print n rows and n columns of asterisks.

    #region Pattern 2: Right-Angled Triangle(increasing)
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
    #endregion Rows increase one star at a time.

    #region Pattern 3: Number Triangle
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
    #endregion Row number increases; each row prints numbers from 1 to that row number.

    #region Pattern 4: Repeating Row Number
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
    #endregion Each row prints its row number multiple times.

    #region Pattern 5: Inverted Right-Angled Triangle
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
    #endregion Starts with full stars and reduces one each row.

    #region Pattern 6: Inverted Number Pattern
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
    #endregion Decreasing numbers each row.

    #region Pattern 7: Pyramid
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
    #endregion Centered pyramid of stars with odd number count.

    #region Pattern 8: Inverted Pyramid
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
    #endregion Reversed version of Pattern 7.
    
    #region Pattern 9: Diamond Half

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
    #endregion Increasing then decreasing star pattern.
    
    # region Pattern 10: Binary Triangle

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

    #endregion Alternates between 1 and 0 per row.
    
    # region Pattern 11: Number Palindrome with Space

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

            // number
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
            space -= 2;
        }
    }
    #endregion Number pyramid with spaces in the middle, mirrored.
    
    # region Pattern 12: Incrementing Numbers

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
    #endregion Continuously increases number through triangle.
    
    # region Pattern 13: Alphabet Triangle

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
    #endregion Adds one more letter each row starting from A.
    
    # region Pattern 14: Reverse Alphabet Triangle

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
    #endregion Letters decrease each row.
    
    # region Pattern 15: Repeated Characters by Row
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
    #endregion Row index used to repeat same alphabet.
         
    # region Pattern 16: Symmetrical Alphabet Pyramid

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
    #endregion Pyramid using characters in ascending then descending order.
    
    # region Pattern 17: Reverse Letter Triangle

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
    #endregion Starts from a decreasing character to E.
    
    # region Pattern 18: Butterfly Pattern

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
    #endregion Stars on the sides with increasing/decreasing space.
    
    # region Pattern 19: Hourglass/Double Triangle

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
    #endregion Two triangles with spaces in between.
    
    # region Pattern 20: Hollow Square

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

    #endregion Only border is printed.
    
    # region Pattern 21: Concentric Number Square
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
    # endregion Layers of decreasing numbers to form a square pattern.
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the Number");
        var num = Convert.ToInt32(Console.ReadLine());
      
        Pattern1(num);
        Pattern2(num);
        Pattern3(num);
        Pattern4(num);
        Pattern5(num);
        Pattern6(num);
        Pattern7(num);
        Pattern8(num);
        Pattern9(num);
        Pattern10(num);
        Pattern11(num);
        Pattern12(num);
        Pattern13(num);
        Pattern14(num);
        Pattern15(num);
        Pattern16(num);
        Pattern17(num);
        Pattern18(num);
        Pattern19(num);
        Pattern20(num);
        Pattern21(num);
    }
}
