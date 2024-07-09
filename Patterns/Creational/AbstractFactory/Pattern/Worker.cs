namespace Pattern;

// Интерфейс рабочего
public interface IWorker
{
    // Метод сбора информации о рабочем
    string GetInfo();
    // Метод создания какой либо вещи
    string CreateItem(IMachine machine);
}

// Рабочий производящий столы
class TableFactoryWorker : IWorker
{
    // Метод сбора информации о рабочем
    public string GetInfo()
    {
        return "TableFactoryWorker.";
    }

    // Метод создания какой либо вещи
    public string CreateItem(IMachine machine)
    {
        var result = machine.GetInfo();

        return $"TableFactoryWorker create item on {result}";
    }
}

// Рабочий производящий стулья
class ChairFactoryWorker : IWorker
{
    // Метод сбора информации о рабочем
    public string GetInfo()
    {
        return "ChairFactoryWorker.";
    }

    // Метод создания какой либо вещи
    public string CreateItem(IMachine machine)
    {
        var result = machine.GetInfo();

        return $"ChairFactoryWorker create item on {result}";
    }
}