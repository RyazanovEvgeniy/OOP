using Iterator.Words;
using Iterator.Pizzas;

// Суть шаблона Итератор - вынос поведения обхода коллекции в отдельный класс,
// что позволяет избежать размывания сущности коллекции,
// которая заключается в хранении данных, а не в хранении вариантов обхода этих данных.

// Есть два варианта реализации паттерна:
// 1) Итератор принимает коллекцию в параметрах конструктора при создании
// 2) Итератор возвращается самой коллекцией (как в данном примере(метод GetEnumerator))

// Бонусом является то, что реализуя интерфейсы IEnumenator, IEnumerable,
// можно спокойно использовать оператор foreach, а может еще какие.

// Правда в данном примере я не стал городить что-то сложное,
// вроде коллекций в виде деревьев или еще чего, а просто обходил список.

// P.S. Iteration - Повторение, Iterator - Повторитель,
// Enumerator - Перечислитель (Счетчик), Enumerable - Перечисляемый

// Коллекция слов возврающая StraightIterator
var wordCollection = new WordCollection
{
    // Добавляем элементы коллекции
    "First",
    "Second",
    "Third",
    "Fourth ",
    "Fifth"
};

// Выводим
Console.WriteLine("Слова:");
foreach (var element in wordCollection)
    Console.WriteLine(element);

// Немного усложненная коллекция объектов пицца
// реализованы три варианта обхода прямой, обратный и странный.
// Возвращается StrangeIterator
var pizzaCollection = new PizzaCollection
{
    // Добавляем элементы коллекции
    new Pizza("1", 123.0f, 500.0f),
    new Pizza("2", 110.0f, 700.0f),
    new Pizza("3", 115.0f, 750.0f),
    new Pizza("4", 116.0f, 750.0f),
    new Pizza("5", 117.0f, 750.0f),
    new Pizza("6", 118.0f, 750.0f)
};

Console.WriteLine();
Console.WriteLine("Пицца, обход по StrangeIterator");

// Обход по StrangeIterator, через foreach
foreach (Pizza pizza in pizzaCollection)
{
    pizza.Price = pizza.Weight * 6;
    Console.WriteLine("Пицца: " + pizza + " Вес, г.: " + pizza.Weight + " Цена, р.: " + pizza.Price);
}

// Обход по ReverseIterator, не через foreach
Console.WriteLine();
Console.WriteLine("Ради интереса, реализация не через foreach, ReverseIterator");

ReverseIterator reverseIterator = new(pizzaCollection);

Pizza pizzaTest;

while (reverseIterator.MoveNext())
{
    pizzaTest = (Pizza)reverseIterator.Current;

    pizzaTest.Price = pizzaTest.Weight * 6;
    Console.WriteLine("Пицца: " + pizzaTest + " Вес, г.: " + pizzaTest.Weight + " Цена, р.: " + pizzaTest.Price);
}

Console.Read();