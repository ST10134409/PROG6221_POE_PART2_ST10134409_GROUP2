using System.Data;

namespace PROG6221POE_ATT1_ST10134409
{
    internal class Program
    {
        //declaring global variables because they will be use in multiple nethods
        static int i;
        static int ingNum;
        static String[] arrIngName;
        static double[] arrIngQuan;
        static String[] arrUOM;
        static int z;
        static String[] arrDesc;
        int select;
        static int steps;

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE RECIPE APPLICATION");

            do {
                Console.WriteLine("Please select an option: " + "\n" +
                     "1. Input the ingredients" + "\n" +
                    "2. Input the instructions" + "\n" +
                    "3. Display the ingredients and instructions" + "\n" +
                    "4. Display a scaled version of all ingredients" + "\n" +
                    "5. Reset all measurements" + "\n" +
                    "Click any other number to exit");
                //wriiten in list form for better readability

                int opt = Convert.ToInt16(Console.ReadLine());

                //calling methods so that they may be implented based of of what the user selects
                if (opt == 1)
                {

                    Ingredients();

                }
                else if (opt == 2) {

                    Instructions();

                }
                else if (opt == 3)
                {

                    Display();

                }
                else if (opt == 4)
                {

                    Calculation();

                }
                else if (opt == 5)
                {

                    Reset();

                }
                else { Environment.Exit(0); }
            } while(true);
        }

        static void Ingredients()
        {

            Console.WriteLine("How many ingredients would you like to enter");
            //variables for number of ingredients
            ingNum = Convert.ToInt16(Console.ReadLine());
            //use the number of ingredients entered to accept that number in an array
            arrIngName = new string[ingNum];//use 'arr' to indicate that i am working with an array
            arrIngQuan = new double[ingNum];//using double because at some point you have to divide them
            arrUOM = new string[ingNum];//UOM is short for unit of measure


            for (int i = 0; i < ingNum; i++)
            {
                //all the arrays use the i iterration to keep them parallel
                Console.WriteLine("Enter the ingredient name:  ");
                arrIngName[i] = Console.ReadLine();

                Console.WriteLine("Enter the recommended quantitiy: ");
                arrIngQuan[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the unit of measurement: ");
                arrUOM[i] = Console.ReadLine();


            }

        }

        static void Instructions()
        {

            Console.WriteLine("How many steps are there in your recipe: ");
            steps = Convert.ToInt16(Console.ReadLine());

            arrDesc = new string[steps];//instructions are stored in this array

            for (int z = 0; z < steps; z++)
            {
                //z + 1 so that every step is numbered
                Console.WriteLine("What is step " + (z + 1) + ": " );
                arrDesc[z] = Console.ReadLine();


            }


        }
        static void Display()
        {

           Console.WriteLine("******INGREDIENTS******");
            for (int i = 0; i < ingNum; i++)
            {
                //.WriteLine so that every ingredient is written on a new line to make reading it easier
                //spacing for better readability
                Console.WriteLine("Ingredient " + (i+1) + ": " + arrIngName[i] + " " + arrIngQuan[i] + " " + arrUOM[i] );

            }

            Console.WriteLine("********INSTRUCTIONS*********");
            for (int z = 0; z < steps; z++)
            {
                Console.WriteLine("Step " + (z + 1) + ": " + arrDesc[i]);

            }
        }

        static void Calculation()
        {
            //user option
            //Typed out in list format for better readability
            Console.WriteLine("How much would you like to scale the recipe by: " + "\n" 
                + "1. Factor of 0.5" + "\n" 
                + "2. Factor of 2" + "\n" 
                + "3. Factor of 3");
            int select = Convert.ToInt16(Console.ReadLine());

            if (select == 1)
            {
                for (int i = 0; i < ingNum; i++)
                {
                    //will multiply value by 0,5
                    Console.WriteLine("Ingredients: " + arrIngName[i] + " " + (arrIngQuan[i] * 0, 5) + " " + arrUOM[i]);
                }
            }
            else if (select == 2)
            {
                for (int i = 0; i < ingNum; i++)
                {
                    //will multiply value by 2
                    Console.WriteLine("Ingredients: " + arrIngName[i] + " " + (arrIngQuan[i] * 2) + " " + arrUOM[i]);
                }
            }
            else if (select == 3)
            {
                for (int i = 0; i < ingNum; i++)
                {
                    //will multiply value by 3
                    Console.WriteLine("Ingredients: " + arrIngName[i] + " " + (arrIngQuan[i] * 3) + " " + arrUOM[i]);

                }
            }
            else { }
        }
        static void Reset() {

            for (int i = 0; i < ingNum; i++)
            {
                //Will enter the original values
                Console.WriteLine("Ingredients: " + arrIngName[i] + "\t" + arrIngQuan[i] + arrUOM[i]);
            }
        }
    }
}