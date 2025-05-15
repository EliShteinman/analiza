namespace sdarot
{
    /// <summary>
    /// Provides methods for performing statistical calculations on numerical data.
    /// </summary>
    internal static class StatsCalculator
    {
        /// <summary>
        /// A static variable that represents a collection of numeric values.
        /// This list is utilized to store and process a series of double-precision floating-point numbers
        /// entered by the user or manipulated through application operations.
        /// </summary>
        private static List<double> _numbers = null!;

        /// <summary>
        /// Entry point of the application, initiates user input handling and subsequent processes.
        /// </summary>
        /// <param name="args">An array of command-line arguments passed to the application.</param>
        private static void Main(string[] args)
        {
            UserInputManager(args);
        }

        /// <summary>
        /// Validates the input arguments, ensuring that there are at least three elements,
        /// all of which are non-negative numbers.
        /// </summary>
        /// <param name="args">An array of input arguments to be validated.</param>
        /// <returns>Returns true if the input is valid; otherwise, false.</returns>
        private static bool ValidateInput(string[] args)
        {
            if (CountElements(args) < 3)
            {
                return false;
            }

            for (int i = 0; i < CountElements(args); i++)
            {
                if (!double.TryParse(args[i], out double temp) || temp < 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Converts an array of string representations of numbers into a list of doubles.
        /// </summary>
        /// <param name="args">An array of strings containing numeric values to be parsed and added to the list.</param>
        private static void ToIntList(string[] args)
        {
            _numbers = [];
            for (int i = 0; i < CountElements(args); i++)
            {
                _numbers.Add(double.Parse(args[i]));
            }
        }

        /// <summary>
        /// Prompts the user to input a series of positive numbers, separated by spaces,
        /// ensuring a minimum of three elements are entered.
        /// </summary>
        /// <returns>An array of strings containing the numbers entered by the user.</returns>
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
        /// Manages the handling and validation of user input to ensure proper data processing.
        /// If input is invalid, prompts for re-entry until valid input is provided.
        /// </summary>
        /// <param name="args">An array of command-line arguments or user-entered input values to be processed.</param>
        private static void UserInputManager(string[] args)
        {
            if (!ValidateInput(args))
            {
                string[] userArgs = GetUserInput();
                UserInputManager(userArgs);
            }

            ToIntList(args);
            MenuManagement();
        }

        /// <summary>
        /// Clears the console screen to provide a clean slate for subsequent output.
        /// </summary>
        private static void CleerTheScreen()
        {
            Console.Clear();
        }

        /// <summary>
        /// Displays the main menu options to the user by clearing the screen and printing predefined menu items.
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
        /// Handles the menu navigation by displaying the menu, processing user input, and executing corresponding actions.
        /// Facilitates interaction between the user and the application by managing menu options and returning to the main menu after execution.
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
        /// Waits for user input to proceed and navigates back to the main menu.
        /// Ensures continuity of the program by allowing the user to return to the main menu after an action is completed.
        /// </summary>
        private static void BackToMenu()
        {
            Print("Press any key to return to the menu.");
            Console.ReadKey();
            MenuManagement();
        }

        /// <summary>
        /// Handles the user's menu selection and executes the corresponding functionality
        /// based on the selected option.
        /// </summary>
        /// <param name="userSelection">A string representing the user's selection from the menu options.</param>
        private static void UserSelectionSwitch(string userSelection)
        {
            switch (userSelection)
            {
                case "a": // a. Input a Series. (Replace the current series)
                    string[] ignore = [];
                    UserInputManager(ignore);
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
                    List<double> temp = CopyList(_numbers);
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
        /// Creates a new list by copying all elements from the input list.
        /// </summary>
        /// <param name="arg">The list of doubles to be copied.</param>
        /// <returns>A new list containing the same elements as the input list.</returns>
        private static List<double> CopyList(List<double> arg)
        {
            List<double> temp = [];
            for (int i = 0; i < CountElements(arg); i++)
            {
                temp.Add(arg[i]);
            }

            return temp;
        }

        /// <summary>
        /// Sorts the provided list of doubles in ascending order using the bubble sort algorithm.
        /// </summary>
        /// <param name="arg">The list of doubles to be sorted.</param>
        private static void SortList(List<double> arg)
        {
            for (int i = 0; i < CountElements(arg); i++)
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
        /// Swaps the elements at the specified indices in the provided list.
        /// </summary>
        /// <param name="arg">The list in which the elements will be swapped.</param>
        /// <param name="index1">The index of the first element to be swapped.</param>
        /// <param name="index2">The index of the second element to be swapped.</param>
        private static void SwapInList(List<double> arg, int index1, int index2)
        {
            (arg[index1], arg[index2]) = (arg[index2], arg[index1]);
        }

        /// <summary>
        /// Counts the number of elements in the provided list.
        /// </summary>
        /// <param name="arg">The list of integers whose elements are to be counted.</param>
        /// <returns>The total number of elements in the list.</returns>
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
        /// Counts the number of elements in the given list of doubles.
        /// </summary>
        /// <param name="arg">The list of doubles whose elements need to be counted.</param>
        /// <returns>The number of elements in the provided list.</returns>
        private static int CountElements(List<double> arg)
        {
            int count = 0;
            foreach (int _ in arg)
            {
                count++;
            }

            return count;
        }


        /// <summary>
        /// Counts the number of elements in the provided string array.
        /// </summary>
        /// <param name="arg">An array of strings whose elements are to be counted.</param>
        /// <returns>Returns the total number of elements in the input array.</returns>
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
        /// <param name="arg">The list of strings to count the elements from.</param>
        /// <returns>The total number of elements in the list.</returns>
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
        /// Calculates the sum of all elements in the provided list of numbers.
        /// </summary>
        /// <param name="arg">A list of double values whose sum is to be calculated.</param>
        /// <returns>The sum of all elements in the provided list as a double.</returns>
        private static double FindSum(List<double> arg)
        {
            double sum = 0;
            for (int i = 0; i < CountElements(arg); i++)
            {
                sum += arg[i];
            }

            return sum;
        }

        /// <summary>
        /// Finds the maximum value in a list of numbers.
        /// </summary>
        /// <param name="arg">A list of double values to search for the maximum value.</param>
        /// <returns>The maximum value found in the list.</returns>
        private static double FindMax(List<double> arg)
        {
            double max = arg[0];
            for (int i = 0; i < CountElements(arg); i++)
            {
                if (arg[i] > max)
                {
                    max = arg[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Determines and returns the minimum value from the given list of double numbers.
        /// </summary>
        /// <param name="arg">A list of double numbers from which to find the minimum value.</param>
        /// <returns>The minimum value in the provided list of numbers.</returns>
        private static double FindMin(List<double> arg)
        {
            double min = arg[0];
            for (int i = 0; i < CountElements(arg); i++)
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
        /// <param name="numerator">The total sum of the series.</param>
        /// <param name="denominator">The number of elements in the series.</param>
        /// <returns>The average value of the series as a double.</returns>
        private static double FindAverage(double numerator, int denominator)
        {
            return numerator / denominator;
        }

        /// <summary>
        /// Terminates the program's execution and closes the application.
        /// </summary>
        private static void Exit()
        {
            Print("Exiting...");
            Environment.Exit(0);
        }

        /// <summary>
        /// Outputs the provided double value to the console.
        /// </summary>
        /// <param name="arg">The double value to be printed.</param>
        private static void Print(double arg)
        {
            Console.WriteLine(arg);
        }

        /// <summary>
        /// Outputs the provided string argument to the console, appending a newline at the end.
        /// </summary>
        /// <param name="arg">The string to be displayed on the console.</param>
        private static void Print(string arg)
        {
            Console.WriteLine(arg);
        }

        /// <summary>
        /// Outputs the provided integer value to the console.
        /// </summary>
        /// <param name="arg">The integer value to be printed.</param>
        private static void Print(int arg)
        {
            Console.WriteLine(arg);
        }

        /// <summary>
        /// Outputs each element of a list of strings to the console.
        /// Each element is printed on a new line.
        /// </summary>
        /// <param name="arg">The list of strings to be printed to the console.</param>
        private static void Print(List<string> arg)
        {
            for (int i = 0; i < CountElements(arg); i++)
            {
                Console.WriteLine(arg[i]);
            }
        }

        /// <summary>
        /// Outputs the contents of a list of numbers to the console, each element on a new line.
        /// </summary>
        /// <param name="arg">The list of double values to be printed to the console.</param>
        private static void Print(List<double> arg)
        {
            for (int i = 0; i < CountElements(arg); i++)
            {
                Console.WriteLine(arg[i]);
            }
        }
    }
}