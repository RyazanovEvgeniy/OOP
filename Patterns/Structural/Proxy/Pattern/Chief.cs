namespace Pattern;

// Интерфейс класса шефа
interface IChief
{
    // Метод возвращения возможных статусов заказа
    IDictionary<int, string> GetStatuses();
    // Получение списка текущих заказов
    IEnumerable<Order> GetOrders();
}

// Исходный класс шефа, который мы не имеем права изменять
class Chief : IChief
{
    // Получение возможных вариантов статусов заказа, которое происходит долго
    public IDictionary<int, string> GetStatuses()
    {
        // Здесь по идее должна быть логика запроса возможных статусов из БД,
        // но просто имитируется ее работа

        // Создаем словарик
        Dictionary<int, string> statuses = new()
        {
            // Добавляем в него пары ключ-статус
            { 1, "ready" },
            { 2, "not ready" },
            { 3, "preparing" }
        };

        // Имитируем задержку
        Thread.Sleep(1000);

        // Возвращаем статусы
        return statuses;
    }

    // Метод получения текущих заказов
    public IEnumerable<Order> GetOrders()
    {
        // Здесь по идее должна быть логика запроса текущих статусов заказов,
        // но просто имитируется ее работа.

        // Создаем и возвращаем список заказов
        return         [
            // Добавляем 3 заказа со случайным статусом
            new Order() { Name = "Burger", StatusId = RandomizeStatus() },
            new Order() { Name = "Pasta", StatusId = RandomizeStatus() },
            new Order() { Name = "Omelet", StatusId = RandomizeStatus() },
        ];
    }

    // Просто логика случайного выбора статуса
    private static int RandomizeStatus() => new Random().Next(1, 4);
}