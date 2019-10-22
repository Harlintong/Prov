using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatögarens_dotter
{
    class Book
    {
        public int price;

        int rarity;

        int actualValue;

        string name;

        string category;
        
        bool curse;

        List<string> booknames = new List<string>() { "The Truth", "Prophet", "100", "Universal", "Area 51" };
        
        Random generator = new Random();

        public Book(string name)
        {
            name = booknames[generator.Next(4)];

            rarity = generator.Next();

            actualValue = generator.Next();

            int c = generator.Next(1, 2);

            if(c == 1)
            {
                curse = true;
            }
            else if(c == 2)
            {
                curse = false;
            }

        }
        public void PrintInfo()
        {

            Console.WriteLine("Name: " + name);

            Console.WriteLine("Rarity: " + rarity);

            Console.WriteLine("Category: " + category);

            Console.WriteLine("Price: " + price);

        }
        public int Evaluate()
        {
            int RPrice = actualValue * rarity;

            return RPrice;

        }
        public string GetCategory()
        {
            return category;
        }
        public string GetName()
        {
            return name;
        }
        public bool IsCursed()
        {
            return curse;
        }

    }
}
