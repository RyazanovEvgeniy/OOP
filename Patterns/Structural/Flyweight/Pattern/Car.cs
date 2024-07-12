namespace Pattern;

// Класс машины
public class Car
{
    // Поле легковеса
    private readonly IFlyweight flyweight;
    // Поле параметров машины
    private readonly int[] parametrs;

    // Конструктор класса
    public Car(string fullInfo, IFlyweight flyweight)
    {
        // Записываем полученный легковес
        this.flyweight = flyweight;

        // Забираем параметры у легковеса
        parametrs = flyweight.GetParametrs(fullInfo);
    }

    // Перепишем приведение к строке класса
    public override string ToString() => String.Join(" ", parametrs.Select(e => flyweight.Read(e)));
}