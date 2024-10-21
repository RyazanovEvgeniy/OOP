namespace Pattern;

// Наш абстрактный класс Messenger
public abstract class Messenger
{
    // Потомки которого должны будут реализовать методы SendAlarm и SendInformation
    public abstract string SendAlarm();
    public abstract string SendInformation();
}

// Первый вариант вывода сообщений
class MessengerStandart1 : Messenger
{
    // Реализуем метод SendAlarm
    public override string SendAlarm()
    {
        return "MessengerStandart1 Alarm";
    }

    // Реализуем метод SendInformation
    public override string SendInformation()
    {
        return "MessengerStandart1 Information";
    }
}

// Второй вариант вывода сообщений
class MessengerStandart2 : Messenger
{
    // Реализуем метод SendAlarm
    public override string SendAlarm()
    {
        return "MessengerStandart2 Alarm";
    }

    // Реализуем метод SendInformation
    public override string SendInformation()
    {
        return "MessengerStandart2 Information";
    }
}