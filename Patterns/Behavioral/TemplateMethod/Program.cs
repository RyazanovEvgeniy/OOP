using Pattern;

// Суть шаблона TemplateMethod - задание структуры алгоритма
// в методе базового класса, заставляющего производные классы
// выполнить все шаги данного алгоритма.

// Создадим человека
SmartHuman smartHuman = new();
// Выполним его шаблонный метод
smartHuman.TemplateMethod();

Console.Read();