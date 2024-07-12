namespace Pattern;

public class SmartHouse
{
    // Защищенные поля классов света и кухни нашего дома
    private Light light;
    private Kitchen kitchen;

    // Конструктор умного дома
    public SmartHouse()
    {
        // В котором мы создаем классы света и кухни, и записываем их в наши поля
        this.light = new Light();
        this.kitchen = new Kitchen();
    }

    // Метод отвечающий за логику действий при входе человека в дом 
    public string HumanGoInto()
    {
        string result = "Human go into house:\n";
        result += this.light.turnOn();
        result += this.kitchen.checkFood();
        result += this.kitchen.cookFood();
        return result;
    }

    // Метод отвечающий за логику действий при выходе человека из дома 
    public string HumanGoOut()
    {
        string result = "Human go out house:\n";
        result += this.light.turnOff();
        return result;
    }
}

// Класс света
public class Light
{
    // Включение
    public string turnOn()
    {
        return "Light turned on.\n";
    }

    // И выключение
    public string turnOff()
    {
        return "Light turned off.\n";
    }
}

// Класс кухни
public class Kitchen
{
    // Приватное поле количества еды
    private int food = 0;

    // Метод проверки наличия еды
    public string checkFood()
    {
        // Если еды нет
        if (food == 0)
        {
            // Заказываем
            food++;
            return "Order food delivery.\n";
        }
        else
        {
            // Иначе говорим, что она есть
            return "Food in stock.\n";
        }
    }

    // Готовим еду
    public string cookFood()
    {
        // Если еда есть
        if (food > 0)
            // Готовим
            return "Food is cooked.\n";
        else
            // Иначе говорим, что нужно заказать еду
            return "Need order food.\n";
    }
}