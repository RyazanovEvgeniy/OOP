using System.Collections;

namespace Iterator.Pizzas;

// Класс пицца
class Pizza(string name, float weight, float price)
{
    // Которая имеет свойства:
    // Название
    public string Name { get; } = name;
    // Вес
    public float Weight { get; set; } = weight;
    // Цену
    public float Price { get; set; } = price;

    // Заместим ToString()
    public override string ToString()
    {
        return Name;
    }
}

// Наша коллекция пицц, реализующая интерфейс IEnumerable
class PizzaCollection : IEnumerable
{
    // Поле нашего списка пицц
    private readonly List<Pizza> collection = [];

    // Возвращаем коллекцию
    public List<Pizza> GetCollection() => collection;

    // Добавляем элемент
    public void Add(Pizza pizza)
    {
        collection.Add(pizza);
    }

    // Удаляем элемент
    public void Remove(Pizza pizza)
    {
        collection.Remove(pizza);
    }

    // Возвращаем итератор.
    // Здесь можно подставить любой из реализованных и foreach их будет кушать.
    public IEnumerator GetEnumerator()
    {
        return new StrangeIterator(this);
    }
}

// Прямой итератор реализующий интерфейс IEnumenator
class StraightIterator(PizzaCollection collection) : IEnumerator
{
    // Поле коллекции, которую будем обходить
    private readonly PizzaCollection collection = collection;

    // Текущая позиция обхода
    private int position = 0;

    // Реализация методов IEnumerator
    // Возврат текущего элемента(с наращиванием текущей позиции)
    object IEnumerator.Current => collection.GetCollection()[position++];

    // Метод определенияя возможности дальнейшего продвижения итератора
    public bool MoveNext() => position < collection.GetCollection().Count;

    // Сброс текущей позиции обхода
    public void Reset() => position = 0;
}

// Обратный итератор
class ReverseIterator(PizzaCollection collection) : IEnumerator
{
    // Поле коллекции, которую будем обходить
    private readonly PizzaCollection collection = collection;

    // Текущая позиция обхода
    private int position = collection.GetCollection().Count - 1;

    // Реализация методов IEnumerator
    // Возврат текущего элемента(с наращиванием текущей позиции)
    public object Current => collection.GetCollection()[position--];

    // Метод определенияя возможности дальнейшего продвижения итератора
    public bool MoveNext() => position >= 0;

    // Сброс текущей позиции обхода
    public void Reset() => position = collection.GetCollection().Count - 1;
}

// Странный итератор.
// Вперед на два, назад на один.
class StrangeIterator(PizzaCollection collection) : IEnumerator
{
    // Поле коллекции, которую будем обходить
    private readonly PizzaCollection collection = collection;

    // Текущая позиция обхода
    private int position = 0;

    // Текущая итерация обхода, для реализации странной методы
    private int iteration = 0;

    // Реализация методов IEnumerator
    // Возврат текущего элемента(с наращиванием текущей позиции)
    // Собственно здесь вся суть паттерна,
    // ТО - КАК МЫ ОБХОДИМ.
    object IEnumerator.Current
    {
        get
        {
            var tmpPosition = position;

            if (iteration++ % 2 == 0)
                position += 2;
            else
                position--;

            return collection.GetCollection()[tmpPosition];
        }
    }

    // Метод определенияя возможности дальнейшего продвижения итератора
    public bool MoveNext()
    {
        if (iteration % 2 != 0)
            return position < collection.GetCollection().Count;
        else
            return true;
    }

    // Сброс текущей позиции обхода
    public void Reset()
    {
        position = 0;
        iteration = 0;
    }
}