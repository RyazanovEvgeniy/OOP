namespace Pattern;

class ChiefProxy(Chief chief) : IChief
{
    // Поле куда помещается исходный объект
    private readonly Chief chief = chief;

    // Поле со статусами заказов
    private IDictionary<int, string>? statuses;

    // Реализация метода запроса заказов с добавлением логгирования в консоль
    public IEnumerable<Order> GetOrders()
    {
        // Выводим текущее время в консоль
        Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()\n");

        // Перенаправляем запрос в исходный класс
        return chief.GetOrders();
    }

    // Реализация метода запроса вариантов статусов заказа
    public IDictionary<int, string> GetStatuses()
    {
        // Если варианты статусов не были полученны раннее,
        // то получаем их, с помощью исходного класса
        return statuses ??= chief.GetStatuses();
    }
}