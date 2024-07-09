using System.Collections;

namespace Pattern.Word;

// Итератор прямого обхода, реализующий интерфейс IEnumerator
class StraightIterator(WordCollection collection) : IEnumerator
{
    // Поле коллекции, которую будем обходить
    private readonly WordCollection collection = collection;

    // Текущая позиция обхода
    private int position;

    // Реализация методов IEnumerator
    // Возврат текущего элемента(с наращиванием текущей позиции)
    object IEnumerator.Current => collection.GetCollection()[position++];

    // Метод определенияя возможности дальнейшего продвижения итератора
    public bool MoveNext() => position < collection.GetCollection().Count;

    // Сброс текущей позиции обхода
    public void Reset() => position = 0;
}

// Коллекция слов, реализующая интерфейс IEnumerable
class WordCollection : IEnumerable
{
    // Поле нашего списка слов
    private readonly List<string> collection = [];

    // Возвращаем коллекцию
    public List<string> GetCollection()
    {
        return collection;
    }

    // Добавляем элемент
    public void Add(string item)
    {
        collection.Add(item);
    }

    // Возвращаем итератор
    public IEnumerator GetEnumerator()
    {
        return new StraightIterator(this);
    }
}