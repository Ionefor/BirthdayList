using BirthdayList.Interfaces;

namespace BirthdayList.Models
{
    /// <summary>
    ///Данный класс, наследует базовый класс Birthday и представляет собой запись о днях рождения друзей.
    /// </summary>
    public class FriendBirthday : Birthday, IRelation
    {
        public string RelationShip => "Friend";

        public override string ToString()
        {
            return string.Format(" {0, -2} |  {1, -8} | {2} | {3}", Id, Name, DateBirth.ToString("dd/MM"), RelationShip);
        }
    }
}
