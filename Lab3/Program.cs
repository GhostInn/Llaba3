namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden<AppleTree> appleGarden = new Garden<AppleTree>("Иван", 10);

            Garden<Currant> currantGarden = new Garden<Currant>("Пётр", 10);

            appleGarden.Plant(0, "Гренни Смит");

            currantGarden.Plant(0, "Чёрная сладкая");
        }
    }
}
