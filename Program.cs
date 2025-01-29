
using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myGroceryArray = ["Cheese", "Milk"];
            // myGroceryArray[1] = "Yogurt";
            // //myGroceryArray[2] = "Yogurt";

            // Console.WriteLine(myGroceryArray[0]);
            // Console.WriteLine(myGroceryArray[1]);

            List<string> myGroceryList = ["Ice Cream", "Crackers"];
            //  Console.WriteLine(myGroceryList[0]);
            //  Console.WriteLine(myGroceryList[1]);

             IEnumerable<string> myGroceryEnumerable = myGroceryList;

             List<string> mySecondGroceryList = myGroceryEnumerable.ToList();

             int[,] myMultiDimensionalArray = {
                {1,2},//0
                {3,4},//1
                {5,6}//2
             };

            // Console.WriteLine(myMultiDimensionalArray[0,0]);
            // Console.WriteLine(myMultiDimensionalArray[2,1]);

            Dictionary<string, int> groceryPrices = new Dictionary<string, int>();

            groceryPrices["Cheese"] = 5;
             groceryPrices["Yogurt"] = 3;

            Console.WriteLine(groceryPrices["Cheese"]);
            Console.WriteLine(groceryPrices["Yogurt"]);
            // Console.WriteLine(groceryPrices["Random"]);
        }
    }
}

// namespace HelloWorld
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] myGroceryArray = ["Cheese", "Milk"];
//             myGroceryArray[1] = "Yogurt";
//             //myGroceryArray[2] = "Yogurt";
//             Console.WriteLine(myGroceryArray[0]);
//             Console.WriteLine(myGroceryArray[1]);

//             List<string> myGroceryList = new List<string>();

//             myGroceryList.Add("Ice Cream");
//             myGroceryList.Add("Crackers");
//              Console.WriteLine(myGroceryList[0]);
//              Console.WriteLine(myGroceryList[1]);
//         }
//     }
// }