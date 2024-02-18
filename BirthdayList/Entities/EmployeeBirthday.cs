using BirthdayList.Interfaces;

namespace BirthdayList.Models
{
    /// <summary>
    ///Данный класс, наследует базовый класс Birthday и представляет собой запись о днях рождения сотрудников.
    /// </summary>
    public class EmployeeBirthday : Birthday, IRelation
    {
        public static string RelationShip => "Employee";
        public override string ToString()
        {
            return string.Format(" {0, -2} |  {1, -8} | {2} | {3}", Id, Name, DateBirth.ToString("dd/MM"), RelationShip);
        }
    }
}
