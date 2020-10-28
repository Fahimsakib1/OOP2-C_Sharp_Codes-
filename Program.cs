using System;

namespace Addition_Input_From_User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Take 1st Number : ");
            int n1 = Convert.ToInt32(Console.ReadLine()); // String k integer e convert korte holo
            // karon user input only string type e neoa possible but amra nite chacchi number form user
            // Tai Convert.ToInt32(Console.ReadLine()) korte hole jate amader int type nuber ta string e convert hoy


            Console.Write(" Take 2nd Number : ");
            int n2 = Convert.ToInt32(Console.ReadLine()); // String k integer e convert korte holo
            // karon user input only string type e neoa possible but amra nite chacchi number form user
            // Tai Convert.ToInt32(Console.ReadLine()) korte hole jate amader int type nuber ta string e convert hoy

            int result = n1 + n2;
            Console.Write(" Addition is : " + result);

            Console.ReadKey();

        }
    }
}
