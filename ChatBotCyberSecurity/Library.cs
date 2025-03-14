using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotCyberSecurity
{
    internal class Library
    {
        public List<ChatBotData> data = new List<ChatBotData>();
        public void LoadData()
        {
            // read from file

            data.Add(new ChatBotData { Content = "Testing password security", Subject = "Security", Tags = "password, security" });
            data.Add(new ChatBotData { Content = "Email ", Subject = "Email", Tags = "email, email" });
        }

    }
}
