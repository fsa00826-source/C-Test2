using System;

class program
{
    static void Main(string[] args)
    {
        int num01;
        int num02;

        Console.Write("Input an operation: ");
        var _operator = Console.Read();
        if (_operator == "+")
        {
            int res1 = num01 + num02;
            Console.Write("Result: " + res1);
        }
        else if (_operator == "-")
        {
            int res2 = num01 - num02;
            Console.Write("The result is: " + res2);
        }
        else if (_operator == "*")
        {
            int res3 = num01 * num02;
            Console.Write("The Product is: " + res3);
        }
        else if (_operator == "/")
        {
            int res4 = num01 / num02;
            Console.Write("The difference is: " + res4);
        }
        else
        {
            Console.WriteLine("Invalid Parameter, the input you entered is not applicable in this field");
        }

        //ReadKey();
        Console.ReadKey();
    }
}

