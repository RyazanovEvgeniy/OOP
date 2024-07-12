using Pattern;

// Суть шаблона Легковес - в выносе общей составляющей какого либо класса
// в отдельный класс и передаче его новому классу, что позволяет
// сократить выделение памяти. Несмотря на то, что легковесами по идее являеются
// экземпляры облегченного класса, легковесом именуется класс в который выносится
// общее состояние (в данном случае класс Flyweight).
// При создании облегченного объекта легковес следит за тем,
// создан ли уже данный легковес, если да используется имеющийся,
// иначе создает новый.

// Создадим наш легковес
IFlyweight flyweight = new Flyweight();

// Создадим машины и передадим ссылку на легковес
var car1 = new Car("BMV X5 Red", flyweight);
var car2 = new Car("BMV X3 Black", flyweight);
var car3 = new Car("BMV M3 White", flyweight);
var car4 = new Car("Chevrolet Camaro Red", flyweight);
var car5 = new Car("Chevrolet Camaro White", flyweight);

// Смотрим, что все работает
Console.WriteLine(car1);
Console.WriteLine(car2);
Console.WriteLine(car3);
Console.WriteLine(car4);
Console.WriteLine(car5);

// Смотрим какие строки хранятся в легковесе
Console.WriteLine(string.Join(" ", Flyweight.parametrs));

// По итогу количество строк хранящееся в памяти в данном примере
// сокращено с 15 до 8, а при увеличении количества экземпляров
// классов до пары тысяч экономия будет более существенна.

Console.Read();