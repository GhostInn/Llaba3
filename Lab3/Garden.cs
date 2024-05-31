namespace Lab3;

public class Garden<T> where T : Plant, new()
{
    public string Gardener { get; set; }

    public T[] Plants { get; set; }

    public Garden(string gardener, int plantCount)
    {
        Gardener = gardener ?? throw new Exception();
        Plants = new T[plantCount];

        for (int i = 0; i < plantCount; i++)
        {
            Plants[i] = new T();
        }
    }

    public void Plant(int plantIndex, string plantSort)
    {
        Plants[plantIndex].Sort = plantSort ?? throw new Exception();

        Console.WriteLine($"Садовник {Gardener} посадил дерево {Plants[plantIndex].Sort}");
    }
}
