using Pattern;

// Суть шаблона Мост (Bridge) - при имеющихся двух иерархиях классов,
// в данном примере, фигуре и цвете, заменить наследование на ассоциацию,
// иначе при наследовании количество комбинацию фигур и цветов будет возврастать в геометрической прогрессии

Figure figure;

// Создаем красный куб
figure = new Cube(new Red());
Console.Write(figure.GetInfo());

// Создаем красную пирамиду
figure = new Pyramid(new Red());
Console.Write(figure.GetInfo());
// Создаем синию пирамиду
figure = new Pyramid(new Blue());
Console.Write(figure.GetInfo());

figure = new Sphere(new Green());
// Создаем зеленую сферу
Console.Write(figure.GetInfo());

Console.Read();