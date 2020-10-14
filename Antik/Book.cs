using System;
using System.Collections.Generic;

namespace Antik
{
    public class Book
    {
        public int price;

        string name;

        int rarity;

        string category;

        int actualValue;

        bool cursed;

        Random generator;

        List<string> categoryList = new List<string>() {""};

        List <string> nameList = new List <string>() {""};

        public Book()
        {
            actualValue = generator.Next(20, 201);

            rarity = generator.Next(1,6);

            int trueOrFalse;
            trueOrFalse = generator.Next(0,2);
            if (trueOrFalse == 0)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }



        }

        public void PrintInfo()
        {

        }

        public int Evaluate()
        {

            return 10;
        }

        public string GetCategory()
        {

            return "wää";
        }

        public string GetName()
        {

            return "name";
        }

        public bool IsCursed()
        {

            return false;
        }
    }
}
