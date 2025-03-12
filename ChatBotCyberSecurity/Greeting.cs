using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotCyberSecurity
{
    internal class Greeting
    {
        public string Name { get; set; }
        public bool UseGreeted { get; set; }

        public void Greet()
        {
            if (!UseGreeted)
            {
                Console.WriteLine("Hi, I am CyberBot, may I please know you");
                Name = Console.ReadLine();
                UseGreeted = true;
                Console.WriteLine($"Nice knowing you {Name}. How can I be of aassistance today");
                MenuDisplay.LoadMenu();
            }
            else
            {
                MenuDisplay.LoadMenu();
            }

        }
    }
}
