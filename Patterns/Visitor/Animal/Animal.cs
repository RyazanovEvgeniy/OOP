namespace Visitor;

public interface IAnimal
{
    void Accept(IVisitor visitor);
}

public class Cat : IAnimal
{
    public void Accept(IVisitor visitor) => visitor.Do(this);
}

public class Dog : IAnimal
{
    public void Accept(IVisitor visitor) => visitor.Do(this);
}

public interface IVisitor
{
    void Do(Cat cat);
    void Do(Dog dog);
}

class Move : IVisitor
{
    public void Do(Cat cat) => Console.WriteLine(cat.GetType().Name + " " + GetType().Name);
    public void Do(Dog dog) => Console.WriteLine(dog.GetType().Name + " " + GetType().Name);
}

class Speak : IVisitor
{
    public void Do(Cat cat) => Console.WriteLine(cat.GetType().Name + " " + GetType().Name);
    public void Do(Dog dog) => Console.WriteLine(dog.GetType().Name + " " + GetType().Name);
}