namespace sdarot
{
    
    /// <summary>
    /// The software itself
    /// </summary>
    class StatsCalculator
    {
        /// <summary>
        /// The entry point for the application. Validates the input and manages the program flow.
        /// </summary>
        /// <param name="args">An array of input arguments provided to the application.</param>
        static void Main(string[] args)
        {
            if (CountElements(args) == 0)
            {
                ManegerUserInput();
            }
            else if (!ValidateInput(args))
            {
                ManegerUserInput();
            }
            MenuManagement();
        }

        /// <summary>
        /// Validates the input arguments to ensure they meet the required conditions.
        /// </summary>
        /// <param name="args">An array of input arguments provided to the application.</param>
        /// <returns>True if the input arguments are valid; otherwise, false.</returns>
        static bool ValidateInput(string[] args)
        {
            if (CountElements(args) < 3)
            {
                return false;
            }
            foreach (string arg in args)
            {
                if (!int.TryParse(arg, out int temp) || temp < 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        static void ToIntList(List<string> args)
        {
            
        }
        
        /// <summary>
        /// Responsible for receiving input from the user
        /// </summary>
        /// <returns>Returns an arr of strings containing the user's input.</returns>
        static string[] GetUserInput()
        {
            CleerTheScreen();
            Print("Please enter a series of positive numbers,");
            Print("A minimum of 3 members is required.");
            Print("Separate each element with a space.");
            Print("For example \"1 24 567\"");
            string input = Console.ReadLine();
            string[] temp = input.Split(' ');
            return temp;
        }

        /// <summary>
        /// Manages receiving input from the user until the input is valid.
        /// </summary>
        static void ManegerUserInput()
        {
            
        }

        /// <summary>
        /// Clears the console screen
        /// </summary>
        static void CleerTheScreen()
        {
            Console.Clear();
        }

        /// <summary>
        /// Prints the menu on a blank screen.
        /// </summary>
        static void PrintMenu()
        {
            CleerTheScreen();
            Print("menu");
            Print("Please select an option:");
            Print("a. Input a Series. (Replace the current series)");
            Print("b. Display the series in the order it was entered.");
            Print("c. Display the series in the reversed order it was entered.");
            Print("d. Display the series in sorted order (from low to high).");
            Print("e. Display the Max value of the series.");
            Print("f. Display the Min value of the series.");
            Print("g. Display the Average of the series.");
            Print("h. Display the Number of elements in the series.");
            Print("i. Display the Sum of the series.");
            Print("j. Exit.");
        }

        /// <summary>
        /// Manages the menu
        /// displaying it and handling selection
        /// </summary>
        static void MenuManagement()
        {
            
        }
        
        /// <summary>
        /// This function returns the user to the menu.
        /// </summary>
        static void BackToMenu()
        {
            Print("Press any key to return to the menu.");
            Console.ReadKey();
            MenuManagement();
        }
        
        /// <summary>
        /// Counts the number of elements in a list.
        /// </summary>
        /// <param name="arg">Gets a list of ints</param>
        /// <returns>Returns an INT of the quantity.</returns>
        static int CountElements(List<int> arg)
        {
            
        }

        /// <summary>
        /// Counts the number of elements in the array.
        /// </summary>
        /// <param name="arg">Gets an array of strings</param>
        /// <returns>Returns an INT of the quantity.</returns>
        static int CountElements(List<string> arg)
        {
            
        }

        /// <summary>
        /// Counts the number of elements in the provided array.
        /// </summary>
        /// <param name="arg">The array of strings whose elements are to be counted.</param>
        /// <returns>The total count of elements in the array.</returns>
        static int CountElements(string[] arg)
        {
            int count = 0;
            foreach (string item in arg)
            {
                count ++;
            }
            return count;
        }
        /// <summary>
        /// This function returns the value of all members.
        /// </summary>
        /// <param name="arg">Gets a list of ints</param>
        /// <returns>List item value as INT</returns>
        static int FindSum(List<int> arg)
        {
            int sum = 0;
            foreach (int item in arg)
            {
                sum += item;
            }
            return sum;
        }
        
        /// <summary>
        /// Accepts a list of ints and returns the highest value.
        /// </summary>
        /// <param name="arg">Gets a list of ints</param>
        /// <returns>Highest number as int</returns>
        static int FindMax(List<int> arg)
        {
            int max = arg[0];
            foreach (int item in arg)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        
        /// <summary>
        /// Accepts a list of ints and returns the lowest value.
        /// </summary>
        /// <param name="arg">Gets a list of ints</param>
        /// <returns>Lowest number as int</returns>
        static int FindMin(List<int> arg)
        {
            int min = arg[0];
            foreach (int item in arg)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        /// <summary>
        /// Calculates the average by dividing the numerator by the denominator.
        /// </summary>
        /// <param name="numerator">The numerator for the calculation.</param>
        /// <param name="denominator">The denominator for the calculation.</param>
        /// <returns>The calculated average as a double.</returns>
        static double FindAverage(int numerator, int denominator)
        {
            return (double)numerator / denominator;
        }

        /// <summary>
        /// This function turns off the software.
        /// </summary>
        static void Exit()
        {
            Print("Exiting...");
            Environment.Exit(0);
        }
        
        /// <summary>
        /// This function accepts a double and prints it.
        /// </summary>
        /// <param name="arg">double</param>
        static void Print(double arg)
        {
            Console.WriteLine(arg);
        }
        
        /// <summary>
        /// This function accepts a string and prints it.
        /// </summary>
        /// <param name="arg">string</param>
        static void Print(string arg)
        {
            Console.WriteLine(arg);
        }
        
        /// <summary>
        /// This function accepts an int and prints it
        /// </summary>
        /// <param name="arg">int</param>
        static void Print(int arg)
        {
            Console.WriteLine(arg);
        }
        
        /// <summary>
        /// This function receives a list of strings and prints it.
        /// </summary>
        /// <param name="arg">List of strings</param>
        static void Print(List<string> arg)
        {
            foreach (string item in arg)
            {
                Console.WriteLine(item);
            }
                
        }
        
        /// <summary>
        /// This function accepts a list of ints and prints it.
        /// </summary>
        /// <param name="arg">List of ints</param>
        static void Print(List<int> arg)
        {
            foreach (int item in arg)
            {
                Console.WriteLine(item);
            }
                
        }
    }
}