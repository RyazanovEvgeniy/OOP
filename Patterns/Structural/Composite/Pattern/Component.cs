namespace Pattern;

// Класс компонент
abstract class Component
{
    public Component() { }

    // Абстрактный метод сбора информации, который должны реализовать наследники класса
    public abstract string GetInfo();

    // Метод добавления нового элемента, если компонент составной
    public virtual void Add(Component component)
    {
        throw new NotImplementedException();
    }

    // Метод удаления элемента, если компонент составной
    public virtual void Remove(Component component)
    {
        throw new NotImplementedException();
    }

    // Метод возвращающий заключение, составной ли компонент (то есть может ли содержать другие компоненты)
    public virtual bool IsComposite()
    {
        return true;
    }
}

// Класс листа
class Leaf : Component
{
    // Замещаем метод получения информации о компоненте
    public override string GetInfo()
    {
        return "Leaf";
    }

    // Метод возвращающий заключение, составной ли компонент (то есть может ли содержать другие компоненты)
    public override bool IsComposite()
    {
        return false;
    }
}

// Класс ветки
class Branch : Component
{
    // Выделяем память под лист компонентов
    protected List<Component> component = new List<Component>();

    // Замещаем метод добавления компонента
    public override void Add(Component component)
    {
        this.component.Add(component);
    }

    // Замещаем метод удаления компонента
    public override void Remove(Component component)
    {
        this.component.Remove(component);
    }

    // Замещаем метод получения информации о компоненте
    public override string GetInfo()
    {
        string result = "Branch(";

        // Для каждого компонента в листе компонентов, собираем информацию о их компонентах =)))
        int i = 0;
        foreach (Component component in this.component)
        {
            // И записываем в возвращаемую строку
            result += component.GetInfo();

            // Костыль для вывода плюсов
            if (i < this.component.Count - 1)
                result += "+";
            i++;
        }

        //Альтернативный способо вывода
        /*
        for (int i = 0; i < this.component.Count; i++)
        {
            result += this.component[i].GetInfo();

            if (i < this.component.Count - 1)
                result += "+";
        }*/

        return result + ")";
    }
}