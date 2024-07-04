namespace Pattern;

// Класс животного
class Animal
{
    // Поле класса в котором мы храним текущее состояние животного
    private State? state;

    // Конструктор класса,
    // в котором мы инициализируем объект с выбранным состоянием
    public Animal(State state) => ChangeState(state);

    // Метод смены состояния
    public void ChangeState(State state)
    {
        Console.WriteLine($"ChangeState to {state.GetType().Name}.");
        this.state = state;
        this.state.SetAnimal(this);
    }

    // Метод проведения работы,
    // делегирующий саму работу текущему состоянию животного
    public void DoWork()
    {
        state?.DoWork();
    }

    // Метод запрашивающий текущее состояние объекта,
    // делегирующий сам запрос так же текущему состоянию
    public void GetState()
    {
        state?.GetState();
    }
}

// Абстрактный класс состояния животного
abstract class State
{
    // Поле нашего животного, для того,
    // чтобы можно было им управлять из класса состояния
    // и его наследников
    protected Animal? animal;

    // Метод установки животного, которым управляет состояние
    public void SetAnimal(Animal animal)
    {
        this.animal = animal;
    }

    // Метод работы, реализуемый в наследниках
    public abstract void DoWork();

    // Метод запроса состояния, реализуемый в наследниках
    public abstract void GetState();
}

// Состояние сна
class Sleep : State
{
    // Метод работы
    public override void DoWork()
    {
        Console.WriteLine("Sleep.");
        Console.WriteLine("Animal wake up.");
        animal?.ChangeState(new Hunt());
    }

    // Метод запроса состояния
    public override void GetState()
    {
        Console.WriteLine($"Current state: {GetType().Name}");
    }
}

// Состояние охоты
class Hunt : State
{
    // Метод работы
    public override void DoWork()
    {
        Console.WriteLine("Hunt.");
        Console.WriteLine("Animal eat food.");
        animal?.ChangeState(new Sleep());
    }

    // Метод запроса состояния
    public override void GetState()
    {
        Console.WriteLine($"Current state: {GetType().Name}");
    }
}