namespace Pattern.Mediator;

public interface IMediator
{
    void Notify(object sender, string ev);
}

// Посредник бургерной
public class BurgerMediator : IMediator
{
    private readonly Chef chef;
    private readonly Packer packer;
    private readonly Courier courier;

    public BurgerMediator(Chef chef, Packer packer, Courier courier)
    {
        this.chef = chef;
        this.chef.SetMediator(this);
        this.courier = courier;
        this.courier.SetMediator(this);
        this.packer = packer;
        this.packer.SetMediator(this);
    }

    // Выстраиваем взаимодействие объектов, логично что мы не ограничены одной операцией
    public void Notify(object sender, string ev)
    {
        if (ev == "Chef made a burger")
        {
            Console.WriteLine("Mediator event: Chef made a burger");
            packer.PackBurger();
        }
        if (ev == "Packer packed a burger")
        {
            Console.WriteLine("Mediator event: Packer packed a burger");
            courier.DeliverBurger();
        }
    }
}

public class BaseWorker()
{
    protected IMediator? mediator;

    public void SetMediator(IMediator mediator)
    {
        this.mediator = mediator;
    }
}

// Класс повара
public class Chef : BaseWorker
{
    public void MakeBurger()
    {
        Console.WriteLine("Chef made a burger");
        mediator?.Notify(this, "Chef made a burger");
    }
}

// Класс упаковщика
public class Packer : BaseWorker
{
    public void PackBurger()
    {
        Console.WriteLine("Packer packed a burger");
        mediator?.Notify(this, "Packer packed a burger");
    }
}

// Класс курьера
public class Courier : BaseWorker
{
    public void DeliverBurger()
    {
        Console.WriteLine("Courier delivered a burger");
        mediator?.Notify(this, "Courier delivered a burger");
    }
}