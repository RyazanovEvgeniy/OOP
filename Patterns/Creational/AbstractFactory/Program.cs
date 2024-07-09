using Pattern;

// Суть шаблона абстрактная фабрика - реализация интерфейса
// по созданию объектов семейства связанных классов.
// (По факту к фабричному методу добавляем классы создающие данные фабрики)
// Фабрика сама создает объекты нужного семейства, что упрощает работу с ней.

// Создаем фабрику по производству столов
IFactory factory = new TableFactory();

// Создаем рабочего и станок
var worker = factory.CreateWorker();
var machine = factory.CreateMachine();

// Смотрим информацию по тому, что создали
Console.WriteLine(worker.GetInfo());
Console.WriteLine(machine.GetInfo());
// Проверяем взаимодействие рабочего со станком
Console.WriteLine(worker.CreateItem(machine));

Console.WriteLine();

// То же самое с другой фабрикой
factory = new ChairFactory();

// Создаем рабочего и станок
worker = factory.CreateWorker();
machine = factory.CreateMachine();

// Смотри информацию того, что создали
Console.WriteLine(worker.GetInfo());
Console.WriteLine(machine.GetInfo());
// Проверяем взаимодействие рабочего со станком
Console.WriteLine(worker.CreateItem(machine));

Console.Read();