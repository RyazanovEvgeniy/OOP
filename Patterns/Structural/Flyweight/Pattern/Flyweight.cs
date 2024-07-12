namespace Pattern;

// Интерфейс легковеса
public interface IFlyweight
{
    // Метод получения параметров
    public int[] GetParametrs(string fullInfo);
    // Метод чтения параметров
    public string Read(int index);
}

// Класс реализующий легковес
public class Flyweight : IFlyweight
{
    // Список параметров хранимых легковесом
    public static List<string> parametrs = new List<string>();

    // Метод получения параметров
    public int[] GetParametrs(string fullInfo)
    {
        // Возвращаем массив позиций элементов параметров в лист хранимых параметров
        // Сначала разделяем строку на подстроки, после чего применяемой к каждой метод GetOrCreate
        // и склеиваем в массив
        return fullInfo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(GetOrCreate)
                                .ToArray();
    }

    // Реализация проверки существования переданного параметра в списке параметров
    private int GetOrCreate(string parametr)
    {
        // Если такого параметра нет в списке, то добавляем
        if (!parametrs.Contains(parametr))
            parametrs.Add(parametr);

        // Ищем номер параметра в массиве и передаем его
        return Read(parametr);
    }

    // Чтение номера параметра в листе параметров
    public int Read(string value) => parametrs.IndexOf(value);

    // Чтение параметра по номеру в листе параметров
    public string Read(int index) => parametrs[index];
}