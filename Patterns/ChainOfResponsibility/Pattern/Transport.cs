namespace Pattern.Transport;

// Интерфейс нашего транспорта
public interface ITransport
{
    // Метод постановки следующего обработчика
    ITransport SetNext(ITransport transport);

    // Метод доставки груза
    string? Deliver(string cargo);
}

// Абстрактный класс транспорта, чтобыв не дублировать часть кода
abstract class AbstractTransport : ITransport
{
    // Поле где мы храним транспорт, следующий за данным
    private ITransport? transportNext;

    // Метод установки следующего транспорта
    public ITransport SetNext(ITransport transport)
    {
        transportNext = transport;
        return transportNext;
    }

    // Метод переобпределяемый в наследниках, по доставке груза.
    // В базовом варианте заставляет следующий транспорт довезти груз.
    public virtual string? Deliver(string cargo)
    {
        if (transportNext is not null)
            return transportNext.Deliver(cargo);
        else
            return default;
    }
}

// Класс танкера (Перевозка топлива)
class Tanker : AbstractTransport
{
    public override string? Deliver(string cargo)
    {
        // Если груз подходящий, то доставляем его
        if (cargo == "Fuel")
            return GetType().Name + " deliver " + cargo;
        // Иначе вызываем доставку из базового класса,
        // которая запускает следующий транспорт
        else
            return base.Deliver(cargo);
    }
}

// Класс легкого грузовика
class LightTrack : AbstractTransport
{
    public override string? Deliver(string cargo)
    {
        // Если груз подходящий, то доставляем его
        if (cargo == "5TCargo")
            return GetType().Name + " deliver " + cargo;
        // Иначе вызываем доставку из базового класса,
        // которая запускает следующий транспорт
        else
            return base.Deliver(cargo);
    }
}

// Класс тяжелого грузовика
class HeavyTrack : AbstractTransport
{
    public override string? Deliver(string cargo)
    {
        // Если груз подходящий, то доставляем его
        if (cargo == "25TCargo")
            return GetType().Name + " deliver " + cargo;
        // Иначе вызываем доставку из базового класса,
        // которая запускает следующий транспорт
        else
            return base.Deliver(cargo);
    }
}