namespace Strategy;

// Интерфейс профессии человека
public interface IProfession
{
    // Метод работы
    void DoWork();
}

// Класс танцора
class Dancer : IProfession
{
    // Который танцует
    public void DoWork()
    {
        Console.WriteLine("Human dancing");
    }
}

// Класс певца
class Singer : IProfession
{
    // Который внезапно поет
    public void DoWork()
    {
        Console.WriteLine("Human singing");
    }
}