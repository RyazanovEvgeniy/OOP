namespace Pattern;

// Класс заказа
public struct Order
{
    // Уникальный идентификатор заказа
    public Guid Id { get; set; }
    // Имя заказа
    public string? Name { get; set; }
    // Статус заказа
    public int StatusId { get; set; }
}