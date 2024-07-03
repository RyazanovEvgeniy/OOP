using Observer;

// Суть шаблона Наблюдатель - ассоциация двух классов,
// с целью реагирования одним классом,
// на события происходящие в другом классе.

// Создадим журнал
var newYorkTimes = new NewYorkTimes();

// Создаем подписчика и добавляем к журналу
newYorkTimes.Attach(new Subscriber());

// Выпускаем журнал
newYorkTimes.NewPublication();
newYorkTimes.NewPublication();
newYorkTimes.NewPublication();

Console.Read();