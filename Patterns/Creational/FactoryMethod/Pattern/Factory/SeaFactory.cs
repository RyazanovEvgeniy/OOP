using Pattern.Transport;

namespace Pattern.Factory;

// Фабрика выпускающая только морской транспорт
class SeaFactory : ITransportFactory
{
    // Реализуем метод создания объекта транспорта интерфейса транспортной фабрики
    public ITransport Create()
    {
        // Создаем и возвращаем объект морской транспорт
        return new SeaTransport();
    }

    // Переопределяем приведение экземпляра класс к строке
    public override string ToString()
    {
        return "Морская компания";
    }
}