using Pattern;

// Суть шаблона Visitor - создание двух иерархий классов
// объектов и посетителей, посетители выполняют роль
// классов описывающих операции необходимые для выполнения
// с объектами, из-за чего нет необходимости их изменения

List<IAnimal> animals =
[
    new Cat(),
    new Dog(),
    new Cat(),
    new Cat()
];

var move = new Move();
foreach (IAnimal animal in animals)
    animal.Accept(move);

var speak = new Speak();
foreach (IAnimal animal in animals)
    animal.Accept(speak);

Console.Read();