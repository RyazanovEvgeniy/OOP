using Pattern;

// Суть шаблона Фасад - создание класса предоставляющего простой доступ (урезанный)
// к какой либо сложной логике.
// Зачастую фасад контролирует жизненный цикл объектов управляемых им.

// Создаем умный дом
SmartHouse smartHouse = new();

// Человек приходит в дом
Console.WriteLine(smartHouse.HumanGoInto());
// И уходит
Console.WriteLine(smartHouse.HumanGoOut());
// И еще разок приходит
Console.WriteLine(smartHouse.HumanGoInto());

Console.Read();