namespace Pattern;

// Интерфейс необходимый для реализации
interface IMachine
{
    void Work();
}

// Класс адаптер, которому необходимо реализовать интерфейс IMachine
class Adapter : Machine, IMachine
{
    // Реализуем наш интерфейс, с помощью базового класса
    public void Work()
    {
        DoWork();
    }
}