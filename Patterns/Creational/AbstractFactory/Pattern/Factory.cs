namespace Pattern;

// Интерфейс абстрактной фабрики
public interface IFactory
{
    // Метод создания рабочего
    IWorker CreateWorker();
    // Метод создания станка
    IMachine CreateMachine();
}

// Класс фабрики по производству столов
class TableFactory : IFactory
{
    // Метод создания рабочего
    public IWorker CreateWorker()
    {
        return new TableFactoryWorker();
    }

    // Метод создания станка
    public IMachine CreateMachine()
    {
        return new TableFactoryMachine();
    }
}

// Класс фабрики по производству стульев
class ChairFactory : IFactory
{
    // Метод создания рабочего
    public IWorker CreateWorker()
    {
        return new ChairFactoryWorker();
    }

    // Метод создания станка
    public IMachine CreateMachine()
    {
        return new ChairFactoryMachine();
    }
}