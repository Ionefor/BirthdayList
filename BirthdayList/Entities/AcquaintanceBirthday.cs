using BirthdayList.Interfaces;

namespace BirthdayList.Models
{
    /// <summary>
    ///Данный класс, наследует базовый класс Birthday и представляет собой запись о днях рождения знакомых.
    /// </summary>
    public class AcquaintanceBirthday : Birthday, IRelation
    {
        public static string RelationShip => "Acquaintance";
        public override string ToString()
        {
            return string.Format(" {0, -2} |  {1, -8} | {2} | {3}", Id, Name, DateBirth.ToString("dd/MM"), RelationShip);
        }
    }
}
