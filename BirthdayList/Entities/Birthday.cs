namespace BirthdayList.Models
{
    /// <summary>
    ///Абстрактный класс, представляющий общую структуру для записей о днях рождения.
    /// </summary>
    public abstract class Birthday
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateBirth { get; set; }
    }
}
