namespace BirthdayList.Views
{
    /// <summary>
    ///Класс для отображения интерфейса пользователя.
    /// </summary>
    public static class Menu
    {
        public static void EnteredName()
        {
            Console.WriteLine();
            Console.Write("\r\nВведите имя: ");
        }
        public static void EnteredDate()
        {
            Console.WriteLine();
            Console.Write("\r\nВведите дату (dd/mm/yyyy): ");
        }
        public static void EnteredId()
        {
            Console.WriteLine();
            Console.Write("\r\nВведите id: ");
        }
        public static void ShowOptionsMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Введите номер желаемой операции:");
            Console.WriteLine("1) Вывести список всех дней рождений");
            Console.WriteLine("2) Вывести список сегодняшних и ближайших дней рождений");
            Console.WriteLine("3) Добавить запись в список");
            Console.WriteLine("4) Удалить запись из списка");
            Console.WriteLine("5) Редактировать запись из списка");
            Console.WriteLine("6) Закрыть меню");
            Console.Write("\r\nВыберите опцию: ");
        }
        public static void ShowOptionsAddMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Введите номер желаемой операции:");
            Console.WriteLine("1) Добавить день рождение друга");
            Console.WriteLine("2) Добавить день рождение сотрудника");
            Console.WriteLine("3) Добавить день рождение знакомого");
            Console.WriteLine("4) Назад");
            Console.Write("\r\nВыберите опцию:");
        }
        public static void ShowOptionsAdditionalMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Введите номер желаемой операции:");
            Console.WriteLine("1) Отсортировать выведенный список по дате");
            Console.WriteLine("2) Отсортировать выведенный список по именам");
            Console.WriteLine("3) Выделить цветом, в зависимости от даты");
            Console.WriteLine("4) Открыть главное меню");
            Console.Write("\r\nВыберите опцию:");
        }
        public static void Initial()
        {
            Console.WriteLine();
            Console.WriteLine("Для того чтобы вызвать меню, введите m.");
            Console.WriteLine("Для того чтобы выйти из программы, введите e.");
        }
        public static void IncorrectInput()
        {
            Console.WriteLine();
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз");
        }
        public static void IncorrectData()
        {
            Console.WriteLine();
            Console.WriteLine("Введены некорректные данные!");
        }
        public static void CompletedSuccessfully()
        {
            Console.WriteLine();
            Console.WriteLine("Операция выполнена успешно!");
        }   
        public static void DisplayedCurrentAndUpcomingBirthday()
        {
            Console.WriteLine();
            Console.WriteLine("Сегодняшние дни рождения, а так же ближайшие:");
        }
        public static void DisplayedAllBirthday()
        {
            Console.WriteLine();
            Console.WriteLine("Все дни рождения из списка:");
        }      
        public static void DisplayedBirthdayColors()
        {
            Console.WriteLine();
            Console.WriteLine("Красным цветом выделены прошедшие дни рожденья,\nзеленым - сегодняшние, а желтым будущие.");
        }
    }
}
