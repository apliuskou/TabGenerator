using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabGenerator
{
    class GenerateRandomDate
    {

        public static string SalesDate()
        {
            Random randomDay = new Random();
            int day = randomDay.Next(1, 30); //Тупо генерируем целое число от 1 до 30

            Random randomMonth = new Random();
            int month = randomMonth.Next(1, 12); //Тупо генерируем целое число от 1 до 12

            Random randomYear = new Random();
            int year = randomYear.Next(1995, 2016); //Тупо генерируем целое число от 1995 до 2016

            string _day;
            _day = Convert.ToString(day); //Конвертим день в стринг

            string _month;
            _month = Convert.ToString(month); //Конвертим номер месяца в стринг

            string _year;
            _year = Convert.ToString(year); //Конвертим год в стринг

            string dayOfTransaction = _year + ", " + _month + ", " + _day; //Формируем строку "Дата транзакции"
            //У тебя эта дата записана иначе, в формате времени: гггг/мм/дд  чч:мм:сс
            //Но я пока оставлю запятые. Вдруг это будет критично при анализе файла.


            return dayOfTransaction;
        }
    }
}
