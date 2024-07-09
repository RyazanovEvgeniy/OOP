namespace Pattern.Transport;

// Класс морского транспорта
class SeaTransport : ITransport
{
    // Реализуем метод доставка интерфейса транспорта
    public void Deliver()
    {
        Console.WriteLine("Доставка морем");
    }

    // Переопределяем приведение экземпляра класс к строке
    public override string ToString()
    {
        return "Морской транспорт";
    }
}