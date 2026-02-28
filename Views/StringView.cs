using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private StringService service = new StringService();

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==== String Processing System ====");
                Console.WriteLine("1. Enter Text");
                Console.WriteLine("2. View Current Text");
                Console.WriteLine("3. Convert to UPPERCASE");
                Console.WriteLine("4. Convert to lowercase");
                Console.WriteLine("5. Count Characters");
                Console.WriteLine("6. Check if Contains Word");
                Console.WriteLine("7. Replace Word");
                Console.WriteLine("8. Extract Substring");
                Console.WriteLine("9. Trim Spaces");
                Console.WriteLine("10. Reset Text");
                Console.WriteLine("11. Exit");
                Console.Write("Choose: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text: ");
                        service.SetText(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Current text: " + service.GetText());
                        break;

                    case 3:
                        service.ToUpperCase();
                        break;

                    case 4:
                        service.ToLowerCase();
                        break;

                    case 5:
                        Console.WriteLine("Length: " + service.CountCharacters());
                        break;

                    case 6:
                        Console.Write("Enter word: ");
                        string word = Console.ReadLine();
                        Console.WriteLine(service.ContainsWord(word));
                        break;

                    case 7:
                        Console.Write("Old word: ");
                        string oldWord = Console.ReadLine();
                        Console.Write("New word: ");
                        string newWord = Console.ReadLine();
                        service.ReplaceWord(oldWord, newWord);
                        break;

                    case 8:
                        Console.Write("Start index: ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Length: ");
                        int len = Convert.ToInt32(Console.ReadLine());
                        service.Substring(start, len);
                        break;

                    case 9:
                        service.TrimSpaces();
                        break;

                    case 10:
                        service.Reset();
                        break;

                    case 11:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
