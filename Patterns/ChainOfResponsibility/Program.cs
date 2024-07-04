using Pattern.Transport;

// Суть шаблона Цепочки обязанностей - в создании цепочки объектов,
// и передачи запроса по этой цепочке
// (Храним в объекте следующий благодаря ассоциации). 
// Выполнит этот запрос первый объект, который сможет его обработать.

// Создадим танкер
var tanker = new Tanker();
// Легкий грузовик
var lightTrack = new LightTrack();
// Тяжелый грузовик
var heavyTrack = new HeavyTrack();

// Выстраиваем их друг за другом
tanker.SetNext(lightTrack).SetNext(heavyTrack);

// И попробуем доставить каждый груз с помощью нашей цепочки
foreach (var item in new List<string> { "5TCargo", "100TCargo", "25TCargo", "Fuel", "25TCargo", "Fuel" })
{
    var result = tanker.Deliver(item);

    // Если получили сообщение о доставке, пишем результат
    if (result is not null)
        Console.WriteLine($"{result}");
    // Если не доставили пишем, то же пишем результат
    else
        Console.WriteLine($"{item} was not delivered.");
}

Console.Read();