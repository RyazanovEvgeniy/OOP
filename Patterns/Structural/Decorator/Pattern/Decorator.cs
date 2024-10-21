namespace Pattern;

abstract class Decorator(Messenger messenger) : Messenger
{
    protected Messenger _messenger = messenger;

    public void SetMessenger(Messenger messenger) => _messenger = messenger;

    public override string SendAlarm()
    {
        if (_messenger != null)
            return _messenger.SendAlarm();
        else
            return string.Empty;
    }

    public override string SendInformation()
    {
        if (_messenger != null)
            return _messenger.SendInformation();
        else
            return string.Empty;
    }
}

class WhatsApp(Messenger messenger) : Decorator(messenger)
{
    public override string SendAlarm() => $"WhatsApp({base.SendAlarm()})";
    public override string SendInformation() => $"WhatsApp({base.SendInformation()})";
}

class Viber(Messenger messenger) : Decorator(messenger)
{
    public override string SendAlarm() => $"Viber({base.SendAlarm()})";
    public override string SendInformation() => $"Viber({base.SendInformation()})";
}

class Telegram(Messenger messenger) : Decorator(messenger)
{
    public override string SendAlarm() => $"Telegram({base.SendAlarm()})";
    public override string SendInformation() => $"Telegram({base.SendInformation()})";
}