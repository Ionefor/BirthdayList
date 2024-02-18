using BirthdayList.Managers;
using BirthdayList.Views;

namespace BirthdayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentBirthdays = BirthdayManager.GetCurrentAndUpcomingBirthday();
            Menu.DisplayedCurrentAndUpcomingBirthday();
            RecordBirthday.DisplayBirthdayRecords(currentBirthdays, ConsoleColor.White, true);
            
            while (true)
            {
                Menu.Initial();
                var input = Console.ReadLine();

                if(input == "M" || input == "m")
                {
                    MenuManager.Manage();
                }
                else if(input == "E" || input == "e")
                {
                    return;
                }
                else
                {
                    Menu.IncorrectInput();
                }
            }         
        }
    }
}
