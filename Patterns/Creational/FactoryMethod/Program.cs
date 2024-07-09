using Pattern;
using Pattern.Factory;

// Суть шаблона Фабричный Метод - делегирование обязанности по созданию объекта отдельному классу
// Это упрощает расширение кода, в случае необходимости добавления объектов нового типа 

Console.WriteLine("Выберете тип компании:");
Console.WriteLine("1: Дорожная компания");
Console.WriteLine("2: Морская компания");
Console.WriteLine("3: Компания смешанного типа");

int typeCompany;

// Ждем ввода числа и тут же проверяем:
// Что это число и то, что оно находится в заданных пределах.
while (!int.TryParse(Console.ReadLine(), out typeCompany) || typeCompany < 1 || typeCompany > 3)
    Console.WriteLine("Ошибка ввода!");

// Объявляем объект компании
Company company;

// И создаем нужный тип компании
company = typeCompany switch
{
    1 => new Company(new RoadFactory()),
    2 => new Company(new SeaFactory()),
    3 => new Company(new CombinedFactory()),
    _ => throw new Exception("Данный тип компании отсутсвует"),
};

// Запрашиваем состав транспорта
Console.WriteLine("Состав транспорта компании:");
company.TransportInfo();

// Запускаем транспорт
Console.WriteLine("Запуск транспорта:");
company.TransportDeliver();

Console.Read();