namespace Pattern;

// Интерфейс строителя, который должен реализовать методы
public interface IBuilder
{
    // Метод постройки кухни
    void BuildKitchen();

    // Метод постройки гостиной
    void BuildLivingRoom();

    // Метод постройки ванной
    void BuildBathRoom();

    // Метод постройки спальной
    void BuildBedRoom();

    // Метод постройки туалета
    void BuildToilet();
}

// Класс строителя, реализующий интерфейс IBuilder
public class Builder : IBuilder
{
    // Поле строящегося дома
    private Home home;

    // В конструкторе создаем новый дом
    public Builder()
    {
        this.home = new Home();
    }

    // При сбросе делаем новый дом
    public void Reset()
    {
        this.home = new Home();
    }

    // Метод постройки кухни
    public void BuildKitchen()
    {
        this.home.Add("Kitchen");
    }

    // Метод постройки гостиной
    public void BuildLivingRoom()
    {
        this.home.Add("LivingRoom");
    }

    // Метод постройки ванной
    public void BuildBathRoom()
    {
        this.home.Add("BathRoom");
    }

    // Метод постройки спальной
    public void BuildBedRoom()
    {
        this.home.Add("BedRoom");
    }

    // Метод постройки туалета
    public void BuildToilet()
    {
        this.home.Add("Toilet");
    }

    // Возвращение построенного дома
    public Home GetHome()
    {
        // Забираем ссылку на текущий дом
        Home result = this.home;

        // Сбрасываем строитель
        this.Reset();

        // Возвращаем ссылку на построенный дом
        return result;
    }
}

// Класс директора, который с помощью конкретного строителя,
// строит дома по конкретным шаблонам.
public class Director
{
    // Поле где мы храним ссылку на строителя, которым пользуемся
    private IBuilder builder;

    // В конструкторе записываем полученного строителя
    public Director(IBuilder builder)
    {
        this.builder = builder;
    }

    // Метод построения дома с минимальной комплектацией
    public void BuildMinimal()
    {
        this.builder.BuildBedRoom();
        this.builder.BuildBathRoom();
        this.builder.BuildToilet();
    }

    // Метод построения дома с максимальной комплектацией
    public void BuildMaximal()
    {
        this.builder.BuildLivingRoom();
        this.builder.BuildBathRoom();
        this.builder.BuildToilet();
        this.builder.BuildKitchen();
        this.builder.BuildBedRoom();
    }
}