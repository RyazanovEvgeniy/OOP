namespace Pattern;

// Класс, недоступный для изменения
class Machine
{
    private int counter;

    // И его работа
    public void DoWork()
    {
        counter++;
        Console.WriteLine("Work " + counter);
    }
}