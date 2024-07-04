namespace Pattern;

// Класс человека
class Human
{
    // Годы жизни человека.
    // (В данном примере единственная характеристика состояния, которую сохраняем)
    private int yearsOfLife = 0;

    // Метод прожигания жизни
    public void LiveSomeTime()
    {
        yearsOfLife += new Random().Next(1, 20);
        Console.WriteLine($"Human lives and now is {yearsOfLife} years old");
    }

    // Метод сохранения состояния
    public IMemento Save()
    {
        return new HumanMemento(yearsOfLife);
    }

    // Метод восстановления состояния
    public void Restore(IMemento memento)
    {
        if (memento is not HumanMemento)
        {
            throw new Exception("Unknown memento class " + memento);
        }

        yearsOfLife = memento.GetYearsOfLive();
        Console.WriteLine($"Human is now {yearsOfLife} years old");
    }
}