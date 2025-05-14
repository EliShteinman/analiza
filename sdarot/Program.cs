namespace sdarot
{

    /// <summary>
    /// The software itself
    /// </summary>
    internal static class StatsCalculator
    {
        /// <summary>
        /// A collection that stores integer values, representing the current series of numbers
        /// inputted or managed in the StatsCalculator.
        /// </summary>
        private static List<int> _numbers = null!;

        /// <summary>
        /// The entry point for the application. Validates the input and manages the program flow.
        /// </summary>
        /// <param name="args">An array of input arguments provided to the application.</param>
        private static void Main(string[] args)
        {
            ManegerUserInput(args);
        }

        /// <summary>
        /// Validates the input arguments to ensure they meet the required conditions.
        /// </summary>
        /// <param name="args">An array of input arguments provided to the application.</param>
        /// <returns>True if the input arguments are valid; otherwise, false.</returns>
        private static bool ValidateInput(string[] args)
        {
            if (CountElements(args) < 3)
            {
                return false;
            }

            for (int i = 0; i < CountElements(args) - 1; i++)
            {
                if (!int.TryParse(args[i], out int temp) || temp < 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Converts an array of strings representing numbers into a list of integers.
        /// </summary>
        /// <param name="args">An array of string inputs, where each element is expected to represent a positive integer.</param>
        private static void ToIntList(string[] args)
        {
            _numbers = [];
            for (int i = 0; i < CountElements(args) - 1; i++)
            {
                _numbers.Add(int.Parse(args[i]));
            }
        }

        /// <summary>
        /// Responsible for receiving input from the user
        /// </summary>
        /// <returns>Returns an arr of strings containing the user's input.</returns>
        private static string[] GetUserInput()
        {
            CleerTheScreen();
            Print("Please enter a series of positive numbers,");
            Print("A minimum of 3 members is required.");
            Print("Separate each element with a space.");
            Print("For example \"1 24 567\"");
            string input = Console.ReadLine()!;
            string[] temp = input.Split(' ');
            return temp;
        }

        /// <summary>
        /// Manages and validates the input from the user, ensuring it meets the required conditions.
        /// If validation fails, prompts the user to provide new input.
        /// </summary>
        /// <param name="args">An array of input arguments to be validated and processed.</param>
        private static void ManegerUserInput(string[] args)
        {
            if (!ValidateInput(args))
            {
                string[] userArgs = GetUserInput();
                ManegerUserInput(userArgs);
            }

            ToIntList(args);
            MenuManagement();
        }

        /// <summary>
        /// Clears the console screen
        /// </summary>
        private static void CleerTheScreen()
        {
            Console.Clear();
        }

        /// <summary>
        /// Prints the menu on a blank screen.
        /// </summary>
        private static void PrintMenu()
        {
            List<string> menu = [
                "menu",
                "Please select an option:",
                "a. Input a Series. (Replace the current series)",
                "b. Display the series in the order it was entered.",
                "c. Display the series in the reversed order it was entered.",
                "d. Display the series in sorted order (from low to high).",
                "e. Display the Max value of the series.",
                "f. Display the Min value of the series.",
                "g. Display the Average of the series.",
                "h. Display the Number of elements in the series.",
                "i. Display the Sum of the series.",
                "j. Exit.",
            ];
            CleerTheScreen();
            Print(menu);
        }

        /// <summary>
        /// Manages the main menu's interaction flow. Displays the menu options, captures user input, processes the selection, and handles transitions back to the menu.
        /// </summary>
        private static void MenuManagement()
        {
            PrintMenu();
            string userSelection = Console.ReadLine()!;
            CleerTheScreen();
            UserSelectionSwitch(userSelection);
            BackToMenu();
        }

        /// <summary>
        /// This function returns the user to the menu.
        /// </summary>
        private static void BackToMenu()
        {
            Print("Press any key to return to the menu.");
            Console.ReadKey();
            MenuManagement();
        }

        /// <summary>
        /// Handles the user's selection from the menu by executing the corresponding functionality.
        /// </summary>
        /// <param name="userSelection">The menu option selected by the user as a string.</param>
        private static void UserSelectionSwitch(string userSelection)
        {
            switch (userSelection)
            {
                case "a": // a. Input a Series. (Replace the current series)
                    string[] ignore = [];
                    ManegerUserInput(ignore);
                    break;
                case "b": // b. Display the series in the order it was entered.
                    Print(_numbers);
                    break;
                case "c": // c. Display the series in the reversed order it was entered.
                    for (int i = CountElements(_numbers) - 1; i >= 0; i--)
                    {
                        Print(_numbers[i]);
                    }

                    break;
                case "d": // d. Display the series in sorted order (from low to high).
                    List<int> temp = CopyList(_numbers);
                    SortList(temp);
                    Print(temp);
                    break;
                case "e": // e. Display the Max value of the series.
                    Print(FindMax(_numbers));
                    break;
                case "f": // f. Display the Min value of the series.
                    Print(FindMin(_numbers));
                    break;
                case "g": // g. Display the Average of the series.
                    Print(FindAverage(FindSum(_numbers), CountElements(_numbers)));
                    break;
                case "h": // h. Display the Number of elements in the series.
                    Print(CountElements(_numbers));
                    break;
                case "i": // i. Display the Sum of the series.
                    Print(FindSum(_numbers));
                    break;
                case "j": // j. Exit.
                    Exit();
                    break;
                default: // Invalid selection.
                    Print("Invalid selection.");
                    Print("Please select a valid option.");
                    break;
            }
        }

        /// <summary>
        /// Creates a copy of the provided list of integers.
        /// </summary>
        /// <param name="arg">The list of integers to be copied.</param>
        /// <returns>A new list containing all elements from the input list.</returns>
        private static List<int> CopyList(List<int> arg)
        {
            List<int> temp = [];
            for (int i = 0; i < CountElements(arg) - 1; i++)
            {
                temp.Add(arg[i]);
            }

            return temp;
        }

        /// <summary>
        /// Sorts a list of integers in ascending order using the bubble sort algorithm.
        /// </summary>
        /// <param name="arg">The list of integers to be sorted.</param>
        private static void SortList(List<int> arg)
        {
            for (int i = 0; i < CountElements(arg) - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < CountElements(arg) - 1 - i; j++)
                {
                    if (arg[j] > arg[j + 1])
                    {
                        SwapInList(arg, j, j + 1);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Swaps the elements in a list at the specified indices.
        /// </summary>
        /// <param name="arg">The list of integers where the swap will occur.</param>
        /// <param name="index1">The index of the first element to be swapped.</param>
        /// <param name="index2">The index of the second element to be swapped.</param>
        private static void SwapInList(List<int> arg, int index1, int index2)
        {
            (arg[index1], arg[index2]) = (arg[index2], arg[index1]);
        }

        /// <summary>
        /// Counts the number of elements in a list.
        /// </summary>
        /// <param name="arg">Gets a list of ints</param>
        /// <returns>Returns an INT of the quantity.</returns>
        private static int CountElements(List<int> arg)
        {
            int count = 0;
            foreach (int _ in arg)
            {
                count++;
            }

            return count;
        }

        /// <summary>
        /// Counts the number of elements in the provided array.
        /// </summary>
        /// <param name="arg">The array of strings whose elements are to be counted.</param>
        /// <returns>The total count of elements in the array.</returns>
        private static int CountElements(string[] arg)
        {
            int count = 0;
            foreach (string _ in arg)
            {
                count++;
            }

            return count;
        }

        /// <summary>
        /// Counts the number of elements in a list of strings.
        /// </summary>
        /// <param name="arg">A list of strings to count the elements from.</param>
        /// <returns>The total count of elements in the provided list.</returns>
        private static int CountElements(List<string> arg)
        {
            int count = 0;
            foreach (string _ in arg)
            {
                count++;
            }

            return count;
        }

        /// <summary>
        /// This function returns the value of all members.
        /// </summary>
        /// <param name="arg">Gets a list of ints</param>
        /// <returns>List item value as INT</returns>
        private static int FindSum(List<int> arg)
        {
            int sum = 0;
            for (int i = 0; i < CountElements(arg) - 1; i++)
            {
                sum += arg[i];
            }

            return sum;
        }

        /// <summary>
        /// Accepts a list of ints and returns the highest value.
        /// </summary>
        /// <param name="arg">Gets a list of ints</param>
        /// <returns>Highest number as int</returns>
        private static int FindMax(List<int> arg)
        {
            int max = arg[0];
            for (int i = 0; i < CountElements(arg) - 1; i++)
            {
                if (arg[i] > max)
                {
                    max = arg[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Accepts a list of ints and returns the lowest value.
        /// </summary>
        /// <param name="arg">Gets a list of ints</param>
        /// <returns>Lowest number as int</returns>
        private static int FindMin(List<int> arg)
        {
            int min = arg[0];
            for (int i = 0; i < CountElements(arg) - 1; i++)
            {
                if (arg[i] < min)
                {
                    min = arg[i];
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
        private static double FindAverage(int numerator, int denominator)
        {
            return (double)numerator / denominator;
        }

        /// <summary>
        /// This function turns off the software.
        /// </summary>
        private static void Exit()
        {
            Print("Exiting...");
            Environment.Exit(0);
        }

        /// <summary>
        /// This function accepts a double and prints it.
        /// </summary>
        /// <param name="arg">double</param>
        private static void Print(double arg)
        {
            Console.WriteLine(arg);
        }

        /// <summary>
        /// This function accepts a string and prints it.
        /// </summary>
        /// <param name="arg">string</param>
        private static void Print(string arg)
        {
            Console.WriteLine(arg);
        }

        /// <summary>
        /// This function accepts an int and prints it
        /// </summary>
        /// <param name="arg">int</param>
        private static void Print(int arg)
        {
            Console.WriteLine(arg);
        }

        /// <summary>
        /// This function receives a list of strings and prints it.
        /// </summary>
        /// <param name="arg">List of strings</param>
        private static void Print(List<string> arg)
        {
            for (int i = 0; i < CountElements(arg) - 1; i++)
            {
                Console.WriteLine(arg[i]);
            }
        }

        /// <summary>
        /// This function accepts a list of ints and prints it.
        /// </summary>
        /// <param name="arg">List of ints</param>
        private static void Print(List<int> arg)
        {
            for (int i = 0; i < CountElements(arg) - 1; i++)
            {
                Console.WriteLine(arg[i]);
            }
        }
    }
}