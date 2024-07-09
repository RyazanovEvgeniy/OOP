namespace Pattern.Transport;

// Класс дорожного транспорта
class RoadTransport : ITransport
{
    // Реализуем метод доставка интерфейса транспорта
    public void Deliver()
    {
        Console.WriteLine("Доставка по земле");
    }

    // Переопределяем приведение экземпляра класс к строке
    public override string ToString()
    {
        return "Дорожный транспорт";
    }
}