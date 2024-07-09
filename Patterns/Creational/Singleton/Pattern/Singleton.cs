namespace Pattern;

public class Singleton
{
    // Приватный конструктор, чтобы никто не смог залезть
    // и создавать экземпляры, как захочет
    private Singleton() { }

    // Статическое поле, куда будет записан наш экземпляр
    private static Singleton? instance;

    // Статический метод получения экземпляра класса.
    // Статический потому что, иначе придется создать экземпляр класса,
    // а потом уже вызывать его метод.
    public static Singleton GetInstance()
    {
        // Если экземпляр не существует, то создаем его
        if (instance is null)
            instance = new Singleton();
        // И возвращаем
        return instance;
    }
}