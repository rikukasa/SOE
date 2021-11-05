using System;
using System.Linq;
using System.Collections.Generic;

namespace SOE
{
    class SOE
    {
        static void Main(string[] args)
        {
            var h = new Human("Kasama", 1, "rikukasa1115", new List<int> { 1, 2, 3, 4, 5 });
            h.Show();
        }
    }

    class Human
    {
        private string Name { get; set; } = "#";
        public int Id { get; set; } = 0;
        public string Mail { get; set; } = "#";
        public List<int> Choice { get; set; } = new List<int> { 0 };

        public Human(string name, int id, string mail, List<int> choice)
        {
            Name = name;
            Id = id;
            Mail = mail;
            Choice = choice;
        }

        public void Show()
        {
            Console.WriteLine($"Name:{Name}\nId{Id}\nMail:{Mail}");
            Console.Write("希望物品番号:");
            for(var i = 0;i < Choice.Count(); i++)
            {
                Console.Write($"\t第{i + 1}希望:{Choice[i]}");
            }
        }
            
    }
}
