// class Q1
// {
//     static bool examination = false;
//     static int number;
//
//     static void Main()
//     {
//         ReceivingInput();
//         PrintChoice();
//     }
//
//     static void ReceivingInput()
//     {
//         do
//         {
//             Console.Clear();
//             Print("Enter a number between 1 and 50:");
//             string choice = Console.ReadLine();
//             examination = int.TryParse(choice, out number);
//             if (!examination)
//             {
//                 Print("Number required.");
//             }
//             else if (number < 1 || number > 50)
//             {
//                 Print("Please enter a number between 1 and 50.");
//                 examination = false;
//             }
//         } while (!examination);
//     }
//
//     static void PrintChoice()
//     {
//         for (int i = 1; i <= number; i++)
//         {
//             if (i % 3 == 0)
//             {
//                 Print("Fizz");
//                 if (i % 5 == 0)
//                 {
//                     Print("Buzz");
//                 }
//             }
//             else
//             {
//                 if (i % 5 == 0)
//                 {
//                     Print("Buzz");
//                 }
//                 else
//                 {
//                     Print(i);
//                 }
//             }
//         }
//     }
//     static void Print(int num)
//     {
//         Console.WriteLine(num);
//     }
//     static void Print(string str)
//     {
//         Console.WriteLine(str);
//     }
// }

// class Q2
// {
//     static string input = "";
//     static void Main()
//     {
//         Start();
//     }
//
//     static void Start()
//     {
//         Console.WriteLine("Please type the sentence.");
//         input = Console.ReadLine();
//         string editInput = DifferentCases(input);
//         Print(editInput);
//     }
//
//     static string DifferentCases(string input)
//     {
//         string temp = "";
//         int tempInt = 0;
//         int count = 0;
//         foreach (char c in input)
//         {
//             if (!char.IsLetter(c))
//             {
//                 tempInt = count + 1;
//             }
//             else if (count == tempInt)
//             {
//                 temp += char.ToUpper(c);
//             }
//             else
//             {
//                 temp += char.ToLower(c);
//             }
//             count++;
//         }
//         return temp;
//     }
//
//     static void Print(string str)
//     {
//         Console.WriteLine(str);
//     }
// }

// class Q3
// {
//     static void Main()
//     {
//         string input = InputUser();
//         int count = ConsonantCount(input);
//         Print(count);
//     }
//     static string InputUser()
//     {
//         Print("Please type what you want to check.");
//         return Console.ReadLine();
//     }
//     static int ConsonantCount(string str)
//     {
//         int count = 0;
//         foreach (char c in str)
//         {
//             switch (c)
//             {
//                 case 'a':
//                     break;
//                 case 'A':
//                     break;
//                 case 'e':
//                     break;
//                 case 'E':
//                     break;
//                 case 'i':
//                     break;
//                 case 'I':
//                     break;
//                 case 'o':
//                     break;
//                 case 'O':
//                     break;
//                 case 'u':
//                     break;
//                 case 'U':
//                     break;
//                 case ' ':
//                     break;
//                 default:
//                     count++;
//                     break;
//             }
//         }
//         return count;
//     }
//     static void Print(int num)
//     {
//         Console.WriteLine(num);
//     }
//     static void Print(string str)
//     {
//         Console.WriteLine(str);
//     }
// }