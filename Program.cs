using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Без этой строки StreamWriter не работал и не распознавался





namespace TabGenerator
{
    class Program
    {
        //? А почему у тебя генерация случайной даты шла до void Main? Так можно? Или так надо в каком-то конкретном случае?
        //Я где-то прочёл, что программа начнёт исполняться с этого места, с void Main

        static void Main(string[] args)

        {
        //Генерируем случайную дату в отдельном классе, просто целые числа, пока не в формате времени
           string dateOfTransaction = GenerateRandomDate.SalesDate();

            string homeFolder = @"c:\GitHub\tabgen\";
            Random moneyRandom = new Random();
            Random randomPartner = new Random();
            string nextRecord = "";
            string[] allPossibleBanks = Enum.GetNames(typeof(Partners));
            int numberOfPartners = allPossibleBanks.Length;



            try
            {
                using (StreamWriter target = File.CreateText(homeFolder + @"\tableofbanks2.csv"))
                {

                    for (int i = 0; i < 10000; i++)
                    {
                        nextRecord = nextRecord + i + ", " + (Partners)randomPartner.Next(0, numberOfPartners) + ", ";
                        nextRecord = nextRecord + moneyRandom.Next(999, 100000) + ", ";
                        nextRecord = nextRecord + dateOfTransaction;
                        Console.WriteLine(" Line{0}: {1}", i, nextRecord);
                        target.WriteLine(nextRecord);

                        nextRecord = "";
                    }
                }
            }
            catch (IOException)
            {

                Console.WriteLine("Error! File already exist or path not found!");
                throw;
            }

            Console.WriteLine("Saved successfully! Table of banks built!");
            Console.ReadKey();




        }

        
    }
}
