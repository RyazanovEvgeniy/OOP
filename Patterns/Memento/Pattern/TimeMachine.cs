namespace Pattern;

// Интерфейс снимка (Backup'a)
public interface IMemento
{
    // Который должен уметь, возвращать информацию по снимку
    string GetInformation();

    // Возвращать состояние объекта для восстановления
    int GetYearsOfLive();

    // Ну и возвращать дату снимка
    DateTime GetDate();
}

// Конкретно снимок человека, реализующий интерфейс снимка
class HumanMemento(int yearsOfLive) : IMemento
{
    // Поле даты снимка
    private readonly DateTime date = DateTime.Now;

    // Метод возврата состояния объекта
    public int GetYearsOfLive()
    {
        return yearsOfLive;
    }

    // Метод запроса информации о снимке
    public string GetInformation()
    {
        return $"Backup: {date} / Human is {yearsOfLive} years old";
    }

    // Метод запроса даты снимка
    public DateTime GetDate()
    {
        return date;
    }
}

// Класс машины времени
class TimeMachine(Human human)
{
    // Поле листа снимков
    private readonly List<IMemento> mementos = [];

    // Метод сохранения состояния человека
    public void Backup()
    {
        mementos.Add(human.Save());
    }

    // Метод возврата человека в прошлое
    public void BackToPast()
    {
        if (mementos.Count == 0)
        {
            Console.WriteLine("No backups of life");
            return;
        }

        var memento = mementos[^1];

        Console.WriteLine("TimeMachine: Human return to the past\n" + memento.GetInformation());
        human.Restore(memento);
        mementos.Remove(memento);
    }

    // Метод выводящий все снимки состояний человека
    public void ShowBackups()
    {
        Console.WriteLine("TimeMachine: ShowBackups");

        foreach (var memento in mementos)
        {
            Console.WriteLine(memento.GetInformation());
        }
    }
}