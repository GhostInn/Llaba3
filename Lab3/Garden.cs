namespace Lab3;

// Объявляем обобщенный класс Garden<T>, где T - тип, унаследованный от Plant и имеющий публичный конструктор без параметров
public class Garden<T> where T : Plant, new()
{
    // Объявляем свойство для хранения имени садовника
    public string Gardener { get; set; }

    // Объявляем свойство для хранения массива растений типа T
    public T[] Plants { get; set; }

    // Объявляем конструктор класса Garden<T> с двумя параметрами: именем садовника и количеством растений
    public Garden(string gardener, int plantCount)
    {
        // Присваиваем свойству Gardener переданное имя садовника
        Gardener = gardener ?? throw new Exception();
        // Создаем новый массив растений типа T с заданным количеством элементов
        Plants = new T[plantCount];

        // Цикл для создания и инициализации каждого растения в массиве с помощью публичного конструктора без параметров
        for (int i = 0; i < plantCount; i++)
        {
            Plants[i] = new T();
        }
    }

    // Объявляем метод Plant для посадки растения с заданным сортом по заданному индексу в массиве растений
    public void Plant(int plantIndex, string plantSort)
    {
        // Присваиваем свойству Sort у растения с заданным индексом в массиве переданный сорт
        Plants[plantIndex].Sort = plantSort ?? throw new Exception();

        // Выводим сообщение о том, что садовник посадил растение с заданным сортом
        Console.WriteLine($"Садовник {Gardener} посадил дерево {Plants[plantIndex].Sort}");
    }
}