using Pattern;

// Суть шаблона Prototype - делегирование копирования объекта самому объекту,
// ибо извне красиво и быстро это сделать нет возможности,
// соответственно создается метод в классе, который создает объект с характеристиками текущего,
// и возвращает его в место запроса.
// Пример того, как работает поверхностное копирование объекта (метод MemberwiseClone)
// и какие проблемы это вызывает.

// Создаем класс MegaClass, оператор new
// выделяет память и создает объект нужного типа
// и возвращает ссылку на него в пункт запроса
// соответственно в megaClass1 записывается эта ссылка
MegaClass megaClass1 = new()
{
    number = 1
};
Console.WriteLine("megaClass1.number == " + megaClass1.number);
// Создадим так же не ссылочный тип данных
int testInt1 = 1;
Console.WriteLine("testInt1 == " + testInt1);

// Объявим еще один MegaClass и запишем в него уже созданный megaClass1
// Здесь проявляется собственно проблема,
// записывается только ссылка из megaClass1 в megaClass2
MegaClass megaClass2 = megaClass1;
Console.WriteLine("megaClass2.number == " + megaClass2.number);
// Чего не происходит здесь, ибо int не является ссылочным типом данных,
// он выделит память и создаст переменную типа int, и запишет в нее значение из testInt1
int testInt2 = testInt1;
Console.WriteLine("testInt2 == " + testInt2);

// И когда мы изменяем megaClass1, то на самом деле мы изменяем объект
// который находится по ссылке из megaClass1,
// таким образом мы изменяем и megaClass2,
// так как в нем находится та же ссылка
Console.WriteLine("After changes in megaClass1.number and testInt1");
megaClass1.number = 2;
Console.WriteLine("megaClass2.number == " + megaClass2.number);
// Чего не происходит с нашим добрым интом
testInt1 = 2;
Console.WriteLine("testInt1 == " + testInt1);
Console.WriteLine("testInt2 == " + testInt2 + "\n");

// Теперь провернем это с нашим прототипом Car
// Создаем объект типа Car, ссылка на который запишется в
// объявленную переменную car1 типа Car
Car car1 = new("Toyota", 120, 142.3f);

// Объявим car2, и выполним поверхностное копирование из car1 в car2
Car car2 = car1.ShallowCopy();
// Объявим car3, и выполним глубокое копирование из car1 в car3
Car car3 = car1.DeepCopy();

// Выведем текущие состояния объектов
Console.WriteLine("car1");
car1.Information();
Console.WriteLine("car2");
car2.Information();
Console.WriteLine("car3");
car3.Information();

// А теперь изменим car1, и посмотрим, что произошло с car2 и car3
car1.engine.factoryNumber = 125;
car1.engine.power = 123.47f;
car1.name = "Mitsubishi";
Console.WriteLine("\nAfter changes in car1");
Console.WriteLine("car1");
car1.Information();
Console.WriteLine("car2");
car2.Information();
Console.WriteLine("car3");
car3.Information();

// Как видим при поверхностном копировании,
// ссылочные типы данных сохраняют свою привязку к старым объектам
// Таким образом приходится выполнять их глубокое их копирование,
// то есть создание новых объектов, на которые они ссылаются
Console.Read();