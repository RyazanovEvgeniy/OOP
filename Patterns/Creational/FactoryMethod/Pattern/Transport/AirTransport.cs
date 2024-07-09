namespace Pattern.Transport;

// Класс воздушного транспорта
class AirTransport : ITransport
{
    // Реализуем метод доставка интерфейса транспорта
    public void Deliver()
    {
        Console.WriteLine("Доставка по воздуху");
    }

    // Переопределяем приведение экземпляра класс к строке
    public override string ToString()
    {
        return "Воздушный транспорт";
    }
}