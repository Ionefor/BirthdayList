using BirthdayList.DatabaseContext;
using BirthdayList.Models;

namespace BirthdayList.Managers
{
    /// <summary>
    ///Класс управления записями о днях рождения.
    /// </summary>
    public static class BirthdayManager
    {
        public static List<Birthday> GetCurrentAndUpcomingBirthday()
        {
            using (var context = new BirthdayContext())
            {
                return context.birthdays.Where(b => b.DateBirth.Day == DateTime.Now.Day ||
                                b.DateBirth.Month == DateTime.Now.Month && b.DateBirth.Day >= DateTime.Now.Day).ToList();
            }
        }
        public static List<Birthday> GetAllBirthday()
        {
            using (var context = new BirthdayContext())
            {
                return context.birthdays.ToList();
            }
        }
        public static List<Birthday> GetPastBirthday()
        {
            using (var context = new BirthdayContext())
            {
                return context.birthdays.Where(b => (b.DateBirth.Month > 0 && b.DateBirth.Month < DateTime.Now.Month)
                    || b.DateBirth.Month == DateTime.Now.Month && b.DateBirth.Day < DateTime.Now.Day).ToList();
            }
        }
        public static List<Birthday> GetCurrentBirthday()
        {
            using (var context = new BirthdayContext())
            {
                return context.birthdays.Where(b => b.DateBirth == DateTime.Now.Date).ToList();
            }
        }
        public static List<Birthday> GetUpcomingBirthday()
        {
            using (var context = new BirthdayContext())
            {
                return context.birthdays.Where(b => (b.DateBirth.Month > DateTime.Now.Month && b.DateBirth.Month <= 12)
                || (b.DateBirth.Month == DateTime.Now.Month && b.DateBirth.Day > DateTime.Now.Day)).ToList();
            }
        }
        public static bool AddBirthday(string name, string date, int choiceRelation)
        {
            using (var context = new BirthdayContext())
            {
                var splitingDate = date.Split('.').Select(int.Parse).ToArray();
                DateTime currentdate;

                try
                {
                    currentdate = new DateTime(splitingDate[2], splitingDate[1], splitingDate[0]);
                }
                catch
                {
                    return false;
                }

                switch (choiceRelation)
                {
                    case 1:
                        context.friends.Add(new FriendBirthday
                        {
                            Name = name,
                            DateBirth = currentdate
                        });
                        context.SaveChanges();
                        break;

                    case 2:
                        context.employees.Add(new EmployeeBirthday
                        {
                            Name = name,
                            DateBirth = currentdate
                        });
                        context.SaveChanges();
                        break;

                    case 3:
                        context.acquaintances.Add(new AcquaintanceBirthday
                        {
                            Name = name,
                            DateBirth = currentdate
                        });
                        context.SaveChanges();
                        break;

                    default:
                        break;
                }

                return true;
            }
        }
        public static bool RemoveBirthday(string id)
        {
            using (var context = new BirthdayContext())
            {
                if (!(int.TryParse(id, out int currentId) && currentId > 0 && currentId < context.birthdays.Count()))
                {
                    return false;
                }
                var birthday = context.birthdays.FirstOrDefault(b => b.Id == currentId);

                context.birthdays.Remove(birthday);
                context.SaveChanges();

                return true;
            }
        }
        public static bool UpdateBirthday(string id, string name, string date)
        {
            using (var context = new BirthdayContext())
            {

                if (!(int.TryParse(id, out int currentId) && currentId > 0 && currentId < context.birthdays.Count()))
                {
                    return false;
                }

                var birthday = context.birthdays.FirstOrDefault(b => b.Id == currentId);
                var splitingDate = date.Split('.').Select(int.Parse).ToArray();
                DateTime currentdate;

                try
                {
                    currentdate = new DateTime(splitingDate[2], splitingDate[1], splitingDate[0]);
                }
                catch
                {
                    return false;
                }

                if (birthday != null)
                {
                    birthday.Name = name;
                    birthday.DateBirth = currentdate;
                    context.SaveChanges();
                }
                return true;
            }
        }
        public static List<Birthday> Sort(Func<Birthday, string> sort, List<Birthday> birthdays)
        {
            return birthdays.OrderBy(sort).ToList();
        }
        public static List<Birthday> Sort(Func<Birthday, int> firstSortParametr,
            Func<Birthday, int> secondSortParametr, List<Birthday> birthdays)
        {
            return birthdays.OrderBy(firstSortParametr).ThenBy(secondSortParametr).ToList();
        }       
    }
}
