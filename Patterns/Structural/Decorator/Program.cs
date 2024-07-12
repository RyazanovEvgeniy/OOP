using Pattern;

// Суть шаблона Декоратор - заключается в создании абстрактного класса,
// в данном примере класса Messenger,
// который реализуется в классах наследниках messengerStandart1 и messengerStandart2,
// и создании класса Decorator, который принимает в параметрах объект того же абстрактного типа,
// который наследует сам Decorator. 
// Целью данных манипуляций является - возможность динамически добавлять существующим объектам новую функциональность.
// Например добавить возможность нашему объекту messengerStandart1, (типа) отправлять сообщение в WhatsApp, Viber и тд.

// Создаем объект MessengerStandart1 и смотрим его работу
MessengerStandart1 messengerStandart1 = new();
Console.WriteLine($"messengerStandart1.SendAlarm() == {messengerStandart1.SendAlarm()}");
Console.WriteLine($"messengerStandart1.SendInformation() == {messengerStandart1.SendInformation()}\n");

// Создаем объект MessengerStandart2 и смотрим его работу
MessengerStandart2 messengerStandart2 = new();
Console.WriteLine($"messengerStandart2.SendAlarm() == {messengerStandart2.SendAlarm()}");
Console.WriteLine($"messengerStandart2.SendInformation() == {messengerStandart2.SendInformation()}\n");

// Создаем объект WhatsApp(messengerStandart1) и апкастим его к Messenger, смотрим как работает
Messenger messenger = new WhatsApp(messengerStandart1);
Console.WriteLine($"WhatsApp(messengerStandart1) messenger.SendAlarm() == {messenger.SendAlarm()}");
Console.WriteLine($"WhatsApp(messengerStandart1) messenger.SendInformation() == {messenger.SendInformation()}\n");

// Тоже самое в Viber, только с messengerStandart2
messenger = new Viber(messengerStandart2);
Console.WriteLine($"Viber(messengerStandart2) messenger.SendAlarm() == {messenger.SendAlarm()}");
Console.WriteLine($"Viber(messengerStandart2) messenger.SendInformation() == {messenger.SendInformation()}\n");

// Downcast и проверка
Viber viber = (Viber)messenger;
Console.WriteLine($"Viber(messengerStandart2) messenger.SendAlarm() == {messenger.SendAlarm()}");
Console.WriteLine($"Viber(messengerStandart2) messenger.SendInformation() == {messenger.SendInformation()}\n");

// Проверяем работает ли смена стандарта
viber.SetMessenger(messengerStandart1);
Console.WriteLine($"Viber(messengerStandart1) messenger.SendAlarm() == {messenger.SendAlarm()}");
Console.WriteLine($"Viber(messengerStandart1) messenger.SendInformation() == {messenger.SendInformation()}\n");

// Ну чисто поржать
messenger = new Telegram(messenger);
messenger = new WhatsApp(messenger);
messenger = new Telegram(messenger);
messenger = new Viber(messenger);
messenger = new Viber(messenger);
messenger = new Telegram(messenger);
Console.WriteLine($"messenger.SendAlarm() == {messenger.SendAlarm()}");
Console.WriteLine($"messenger.SendInformation() == {messenger.SendInformation()}\n");

Console.Read();