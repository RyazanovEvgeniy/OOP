namespace Pattern;

// Класс человека
abstract class Human
{
    // Создаем структура алгоритма в шаблонном методе
    public void TemplateMethod()
    {
        GetInformation();
        MakeDecision();
        Work();
    }

    // Абстрактные методы,
    // которые должны быть в реализованы у производных классов.
    // Метод поиска информации
    protected abstract void GetInformation();

    // Метод принятия решения
    protected abstract void MakeDecision();

    // Метод работы
    protected abstract void Work();
}

class SmartHuman : Human
{
    // Метод поиска информации
    protected override void GetInformation()
    {
        Console.WriteLine("SmartHuman.GetInformation()");
    }

    // Метод принятия решения
    protected override void MakeDecision()
    {
        Console.WriteLine("SmartHuman.MakeDecision()");
    }

    // Метод работы
    protected override void Work()
    {
        Console.WriteLine("SmartHuman.Work()");
    }
}