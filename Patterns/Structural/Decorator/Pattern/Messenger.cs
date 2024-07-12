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

// Класс Decorator
abstract class Decorator : Messenger
{
    // Поле куда запишем, какой Messenger использует наш декоратор
    protected Messenger messenger;

    // Конструктор класса
    public Decorator(Messenger messenger)
    {
        this.messenger = messenger;
    }

    // Метод установки поля messenger
    public void SetMessenger(Messenger messenger)
    {
        this.messenger = messenger;
    }

    // Замещаем метод SendAlarm
    public override string SendAlarm()
    {
        // Проверим не пустой ли объект
        if (this.messenger != null)
            // Реализуем через наш messenger
            return this.messenger.SendAlarm();
        else
            return string.Empty;
    }

    // Замещаем метод SendInformation
    public override string SendInformation()
    {
        // Проверим не пустой ли объект
        if (this.messenger != null)
            // Реализуем через наш messenger
            return this.messenger.SendAlarm();
        else
            return string.Empty;
    }
}

// Ну и три варианта декоратора
// в которых замещаются методы SendAlarm и SendInformation
class WhatsApp : Decorator
{
    public WhatsApp(Messenger messenger) : base(messenger)
    {
    }

    public override string SendAlarm()
    {
        return $"WhatsApp({base.SendAlarm()})";
    }

    public override string SendInformation()
    {
        return $"WhatsApp({base.SendAlarm()})";
    }
}

class Viber : Decorator
{
    public Viber(Messenger messenger) : base(messenger)
    {
    }

    public override string SendAlarm()
    {
        return $"Viber({base.SendAlarm()})";
    }

    public override string SendInformation()
    {
        return $"Viber({base.SendAlarm()})";
    }
}

class Telegram : Decorator
{
    public Telegram(Messenger messenger) : base(messenger)
    {
    }

    public override string SendAlarm()
    {
        return $"Telegram({base.SendAlarm()})";
    }

    public override string SendInformation()
    {
        return $"Telegram({base.SendAlarm()})";
    }
}