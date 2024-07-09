using Pattern.Transport;

namespace Pattern.Factory;

// Фабрика выпускающая транспорт случайного типа
class CombinedFactory : ITransportFactory
{
    // Реализуем метод создания объекта транспорта интерфейса транспортной фабрики
    public ITransport Create()
    {
        Random random = new Random();

        // Создаем и возвращаем транспорт случайного типа
        switch (random.Next(0, 3))
        {
            case 0:
                return new RoadTransport();
            case 1:
                return new SeaTransport();
            case 2:
                return new AirTransport();
            default:
                throw new Exception("Данный класс транспорта отсутствует");
        }
    }

    // Переопределяем приведение экземпляра класс к строке
    public override string ToString()
    {
        return "Компания смешанного типа";
    }
}