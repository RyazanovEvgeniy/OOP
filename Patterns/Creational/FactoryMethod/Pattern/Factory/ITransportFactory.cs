using Pattern.Transport;

namespace Pattern.Factory;

// Интерфейс Фабрики транспорта
interface ITransportFactory
{
    // Метод создающий объект транспорта и возвращающий его
    ITransport Create();
}