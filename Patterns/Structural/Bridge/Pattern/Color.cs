namespace Pattern;

// Создаем интерфейс IColor
public interface IColor
{
    // Который вынуждает классы реализовать метод GetColor
    string GetColor();
}

// Класс красный, которому необходимо реализовать методы интерфейса IColor
class Red : IColor
{
    public string GetColor()
    {
        return "Red.\n";
    }
}

// Класс синий, которому необходимо реализовать методы интерфейса IColor
class Blue : IColor
{
    public string GetColor()
    {
        return "Blue.\n";
    }
}

// Класс зеленый, которому необходимо реализовать методы интерфейса IColor
class Green : IColor
{
    public string GetColor()
    {
        return "Green.\n";
    }
}