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

            category = categoryList[generator.Next(0, categoryList.Count)];

            name = nameList[generator.Next(0, nameList.Count)];
        }

        public void PrintInfo()
        {
            System.Console.WriteLine(name);

            System.Console.WriteLine(rarity);

            System.Console.WriteLine(category);

            System.Console.WriteLine(price);

        }

        public float Evaluate()
        {
            float correctPrice = actualValue * rarity;

            int multiplication = generator.Next (0, 2);
            if (multiplication == 1)
            {
                correctPrice *= 0.5f;
            }
            else
            {
                correctPrice *= 1.5f;
            }
       
            
            return correctPrice;
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
            int chance = generator.Next(0,5);

            if (cursed == true)
            {
                if (chance == 0 || chance == 1 || chance == 2 || chance == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else if (cursed == false)
            {
                if (chance == 0 || chance == 1 || chance == 2 || chance == 3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
