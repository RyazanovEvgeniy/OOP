using Pattern.Transport;
using Pattern.Factory;

namespace Pattern;

// Класс компании
class Company
{
    // Массив всего транспорта компании
    private ITransport[] transport;

    // Конструктор компании, в который передается выбранная фабрика транспорта
    public Company(ITransportFactory transportFactory)
    {
        // Создаем массив из 10 объектов типа транспорт
        transport = new ITransport[10];

        // Заполняем массив с помощью фабричного метода
        // ********************************************
        // ******** ЭТО СУТЬ ФАБРИЧНОГО МЕТОДА ********
        // ********************************************
        for (int i = 0; i < transport.Length; i++)
            transport[i] = transportFactory.Create();
    }

    // Метод доставки
    public void TransportDeliver()
    {
        // Для каждого транспорта запускаем его вид доставки
        for (int i = 0; i < transport.Length; i++)
        {
            transport[i].Deliver();
        }
    }

    // Метод вывода информации по количеству каждого вида транспорта
    public void TransportInfo()
    {
        // Считаем для каждого элемента массива объектов где совпадает условие
        int roadTransport = transport.Where((item) => {
            return item.ToString() == "Дорожный транспорт";
        }).Count();

        // Считаем для каждого элемента массива объектов где совпадает условие
        int seaTransport = transport.Where((item) => {
            return item.ToString() == "Морской транспорт";
        }).Count();

        // Считаем для каждого элемента массива объектов где совпадает условие
        int airTransport = transport.Where((item) => {
            return item.ToString() == "Воздушный транспорт";
        }).Count();

        // Выводим на экран
        Console.WriteLine($"Дорожный транспорт: {roadTransport}, Водный транспорт: {seaTransport}, Воздушный транспорт: {airTransport}");
    }
}