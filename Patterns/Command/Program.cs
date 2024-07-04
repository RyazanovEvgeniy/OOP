using Pattern;

// Суть шаблона Command - создание классов под команды системы,
// что позволяет в дальнейшем работать с каждой из них,
// как с отдельным объектом.
// То есть открываются возможности создания очереди команд,
// откладывания команды и тд.

// Создаем командира
Commander commander = new();

// Устанавливаем ему две команды, которые он должен исполнять
commander.SetCommand1(new SimpleCommand());
commander.SetCommand2(new CompositeCommand());

// Заставляем его их исполнить
commander.Execute();

Console.Read();