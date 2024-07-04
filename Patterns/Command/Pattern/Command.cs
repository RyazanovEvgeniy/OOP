namespace Pattern;

// Интерфейс команды
public interface ICommand
{
    string Execute();
}

// Простая команда, которая реализует метод Execute
class SimpleCommand : ICommand
{
    public string Execute() => "SimpleCommand.Execute()";
}

// Составная команда
class CompositeCommand : ICommand
{
    // Которая имеет поле солдата
    private readonly Soldier soldier;

    // Которого она создает в конструкторе
    public CompositeCommand() => soldier = new Soldier("Soldier.Execute()");

    // Реализуем метод интерфейса, через солдата
    public string Execute() => "CompositeCommand." + soldier.Execute();
}

// Класс командира
class Commander
{
    // С двумя полями установленных команд
    private ICommand? command1;
    private ICommand? command2;

    // Метод установки первой команды
    public void SetCommand1(ICommand command) => command1 = command;

    // Метод установки второй команды
    public void SetCommand2(ICommand command) => command2 = command;

    // Метод запускающий последовательное выполнение двух команд
    public void Execute()
    {
        if (command1 is not null)
            Console.WriteLine(command1.Execute());
        if (command2 is not null)
            Console.WriteLine(command2.Execute());
    }
}

// Класс солдата
class Soldier(string command)
{
    private readonly string command = command;

    // Метод выполнения команды
    public string Execute() => command;
}