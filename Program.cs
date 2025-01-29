
using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            int mySecondInt = 10;

            if(myInt < mySecondInt)
            {
                myInt += 10;
            }
        
        Console.WriteLine(myInt);

        string myCow = "Cow";
        // string myCapitalizedCow = "Cow";

        if (myCow == myCapitalizedCow)
        {
            Console.WriteLine("Equal");
        }
        else if (myCow == myCapitalizedCow.ToUpper())
        {
            Console.WriteLine("Equal without case sensitivity");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }


        switch (myCow)
        {
            case "cow":
            Console.WriteLine("Lowercase");
            break;
            case "Cow":
            Console.WriteLine("Uppercase");
            break;
            default:
            Console.WriteLine("Default Ran");
            break;
        }


        }
    }
}