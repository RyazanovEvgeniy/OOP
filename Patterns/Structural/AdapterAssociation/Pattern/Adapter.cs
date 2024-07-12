namespace Pattern;

// Интерфейс необходимый для реализации
interface IMachine
{
    void Work();
}

// Класс адаптер, которому необходимо реализовать интерфейс IMachine
class Adapter : IMachine
{
    // Создаем экземпляр класса Machine
    readonly Machine machine = new();

    // Реализуем наш интерфейс, с помощью экземпляра класса
    public void Work()
    {
        machine.DoWork();
    }
}