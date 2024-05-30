namespace Lab3
{
    // Объявляем класс Program
    class Program
    {
        // Объявляем точку входа в программу - статический метод Main
        static void Main(string[] args)
        {
            // Создаем экземпляр обобщенного класса Garden<T> с типом AppleTree и именем садовника "Иван" и количеством растений 10
            Garden<AppleTree> appleGarden = new Garden<AppleTree>("Иван", 10);

            // Создаем экземпляр обобщенного класса Garden<T> с типом Currant и именем садовника "Пётр" и количеством растений 10
            Garden<Currant> currantGarden = new Garden<Currant>("Пётр", 10);

            // Выполняем операцию посадки растения с сортом "Гренни Смит" по индексу 0 в массиве растений appleGarden
            appleGarden.Plant(0, "Гренни Смит");

            // Выполняем операцию посадки растения с сортом "Чёрная сладкая" по индексу 0 в массиве растений currantGarden
            currantGarden.Plant(0, "Чёрная сладкая");
            
            //
        }
    }
}