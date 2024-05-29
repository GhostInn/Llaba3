namespace Lab3;

// Объявляем класс AppleTree, который наследуется от базового класса Plant
public class AppleTree : Plant
{
    // Конструктор класса AppleTree без параметров
    public AppleTree()
    {
        // Присваиваем свойству или полю Sort строковый литерал "нет сорта"
        Sort = "нет сорта";
    }
}