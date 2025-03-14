using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotCyberSecurity
{
    internal class MenuDisplay
    {
        public static void LoadMenu()
        {
            Library library = new Library();
            library.LoadData();
            int choice = 0;
            Console.WriteLine("1 . ask a question");
            Console.WriteLine("2 . vew all topics");
            Console.WriteLine("3 . menu 3");
            Console.WriteLine("4 . menu 4");
            Console.WriteLine("5 . vew all topics");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                var data = library.data;
                Console.WriteLine("Please type in your question");
                //search data set for content that matches what the user typed
                var question = Console.ReadLine();
                var searchArray = question.Split(' ');
                bool contentFound = false;
                foreach (var item in searchArray)
                {
                    var record = data.FirstOrDefault(x => x.Subject.ToLower().Contains(item.ToLower()) || x.Tags.ToLower().Contains(item.ToLower()));
                    if (record != null)
                    {
                        Console.WriteLine("I have found the following information for you\n");
                        Console.WriteLine($"{record.Content}");
                        contentFound = true;
                        break;
                    }
                }
                if (!contentFound)
                    Console.WriteLine($"Sorry no content for {question}");
            }
        }

    }
}


