namespace Pattern;

// Интерфейс станка
public interface IMachine
{
    // Метод сбора информации о станке
    string GetInfo();
}

// Станок по производству столов
class TableFactoryMachine : IMachine
{
    // Метод сбора информации о станке
    public string GetInfo()
    {
        return "TableFactoryMachine.";
    }
}

// Станок по производству стульев
class ChairFactoryMachine : IMachine
{
    // Метод сбора информации о станке
    public string GetInfo()
    {
        return "ChairFactoryMachine.";
    }
}