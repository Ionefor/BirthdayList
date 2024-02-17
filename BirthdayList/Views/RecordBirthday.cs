using BirthdayList.Models;

namespace BirthdayList.Views
{
    /// <summary>
    ///Класс для отображения записей о днях рождениях.
    /// </summary>
    public static class RecordBirthday
    {
        public static void DisplayBirthdayRecords(List<Birthday> birthdays)
        {
            Console.WriteLine();
            Console.WriteLine(" {0, -1} |  {1, -8} | {2} | {3}", "id", "Name", "Date ", "Relation");

            foreach (var birthday in birthdays)
            {
                Console.WriteLine(birthday);
            }
        }
        public static void DisplayBirthdayRecords(List<Birthday> birthdays, ConsoleColor color, bool enableHeadlines)
        {
            if(enableHeadlines)
            {
                Console.WriteLine();
                Console.WriteLine(" {0, -1} |  {1, -8} | {2} | {3}", "id", "Name", "Date ", "Relation");
            }
            
            Console.ForegroundColor = color;

            foreach(var birthday in birthdays)
            {
                Console.WriteLine(birthday);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
