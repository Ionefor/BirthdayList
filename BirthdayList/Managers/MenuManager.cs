using BirthdayList.Models;
using BirthdayList.Views;

namespace BirthdayList.Managers
{
    /// <summary>
    ///Класс управления меню программы.
    /// </summary>
    public static class MenuManager
    {
        public static void Manage()
        {
        mainMenu:;
            Menu.ShowOptionsMainMenu();
        repeat:;

            List<Birthday> currentBirthdays;
            string id, name, date;

            switch (Console.ReadLine())
            {
                case "1":

                    currentBirthdays = BirthdayManager.GetAllBirthday();
                    Menu.DisplayedAllBirthday();
                    RecordBirthday.DisplayBirthdayRecords(currentBirthdays);
                    AdditionalMenuFirst:;
                    Menu.ShowOptionsAdditionalMenu();

                    switch (Console.ReadLine())
                    {
                        case "1":
                            currentBirthdays = BirthdayManager.Sort(m => m.DateBirth.Month,
                                d => d.DateBirth.Day, currentBirthdays);
                            Menu.DisplayedAllBirthday();
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays);
                            goto AdditionalMenuFirst;

                        case "2":
                            currentBirthdays = BirthdayManager.Sort(n => n.Name, currentBirthdays);
                            Menu.DisplayedAllBirthday();
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays);
                            goto AdditionalMenuFirst;

                        case "3":
                            currentBirthdays = BirthdayManager.GetPastBirthday();
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays, ConsoleColor.Red, true);

                            currentBirthdays = BirthdayManager.GetCurrentBirthday();
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays, ConsoleColor.Green, false);

                            currentBirthdays = BirthdayManager.GetUpcomingBirthday();
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays, ConsoleColor.Yellow, false);
                            Menu.DisplayedBirthdayColors();
                            goto AdditionalMenuFirst;

                        case "4":
                            goto mainMenu;

                        default:
                            goto AdditionalMenuFirst;
                    }
                case "2":
                    currentBirthdays = BirthdayManager.GetCurrentAndUpcomingBirthday();
                    RecordBirthday.DisplayBirthdayRecords(currentBirthdays);
                    Menu.DisplayedCurrentAndUpcomingBirthday();
                AdditionalMenuSecond:;
                    Menu.ShowOptionsAdditionalMenu();

                    switch (Console.ReadLine())
                    {
                        case "1":
                            currentBirthdays = BirthdayManager.Sort(m => m.DateBirth.Month,
                                d => d.DateBirth.Day, currentBirthdays);
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays);
                            Menu.DisplayedCurrentAndUpcomingBirthday();
                            goto AdditionalMenuSecond;

                        case "2":
                            currentBirthdays = BirthdayManager.Sort(n => n.Name, currentBirthdays);
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays);
                            Menu.DisplayedCurrentAndUpcomingBirthday();
                            goto AdditionalMenuSecond;

                        case "3":
                            currentBirthdays = BirthdayManager.GetPastBirthday();
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays, ConsoleColor.Red, true);

                            currentBirthdays = BirthdayManager.GetCurrentBirthday();
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays, ConsoleColor.Green, false);

                            currentBirthdays = BirthdayManager.GetUpcomingBirthday();
                            RecordBirthday.DisplayBirthdayRecords(currentBirthdays, ConsoleColor.Yellow, false);
                            Menu.DisplayedBirthdayColors();
                            goto AdditionalMenuSecond;

                        case "4":
                            goto mainMenu;

                        default:
                            goto AdditionalMenuSecond;
                    }
                case "3":
                    Menu.ShowOptionsAddMenu();

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Menu.EnteredName();
                            name = Console.ReadLine();

                            Menu.EnteredDate();
                            date = Console.ReadLine();

                            if (BirthdayManager.AddBirthday(name, date, 1))
                            {
                                Menu.CompletedSuccessfully();
                            }
                            else
                            {
                                Menu.IncorrectData();
                            }
                            break;

                        case "2":
                            Menu.EnteredName();
                            name = Console.ReadLine();

                            Menu.EnteredDate();
                            date = Console.ReadLine();

                            if (BirthdayManager.AddBirthday(name, date, 2))
                            {
                                Menu.CompletedSuccessfully();
                            }
                            else
                            {
                                Menu.IncorrectData();
                            }
                            break;

                        case "3":
                            Menu.EnteredName();
                            name = Console.ReadLine();

                            Menu.EnteredDate();
                            date = Console.ReadLine();

                            if (BirthdayManager.AddBirthday(name, date, 3))
                            {
                                Menu.CompletedSuccessfully();
                            }
                            else
                            {
                                Menu.IncorrectData();
                            }
                            break;

                        case "4":
                            goto mainMenu;

                        default:
                            Menu.IncorrectInput();
                            break;
                    }
                    break;

                case "4":
                    Menu.EnteredId();
                    id = Console.ReadLine();

                    if (BirthdayManager.RemoveBirthday(id))
                    {
                        Menu.CompletedSuccessfully();
                    }
                    else
                    {
                        Menu.IncorrectData();
                    }
                    break;

                case "5":
                    Menu.EnteredId();
                    id = Console.ReadLine();

                    Menu.EnteredName();
                    name = Console.ReadLine();

                    Menu.EnteredDate();
                    date = Console.ReadLine();

                    if (BirthdayManager.UpdateBirthday(id, name, date))
                    {
                        Menu.CompletedSuccessfully();
                    }
                    else
                    {
                        Menu.IncorrectData();
                    }

                    break;

                case "6":
                    break;

                default:
                    Menu.IncorrectInput();
                    goto repeat;
            }
        }
    }
}
