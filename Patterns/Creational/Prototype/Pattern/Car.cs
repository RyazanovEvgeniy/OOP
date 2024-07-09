namespace Pattern;

// Класс двигателя автомобиля
public class Engine(int factoryNumber, float power)
{
    // С полями фабричного номера
    public int factoryNumber = factoryNumber;
    // и мощности
    public float power = power;
}

// Класс машины, с возможностью его клонирования
public class Car(string name, int engineFactoryNumber, float enginePower)
{
    // С полями имени машины
    public string name = name;
    // и двигателя
    public Engine engine = new(engineFactoryNumber, enginePower);

    // Поверхностное копирование машины
    public Car ShallowCopy()
    {
        return (Car)MemberwiseClone();
    }

    // Глубокое копирование машины
    public Car DeepCopy()
    {
        Car clone = (Car)MemberwiseClone();
        clone.engine = new Engine(engine.factoryNumber, engine.power);
        return clone;
    }

    // Вывод информации о машине
    public void Information()
    {
        Console.WriteLine("Name == " + name);
        Console.WriteLine("engine.factoryNumber == " + engine.factoryNumber);
        Console.WriteLine("engine.power == " + engine.power);
    }
}