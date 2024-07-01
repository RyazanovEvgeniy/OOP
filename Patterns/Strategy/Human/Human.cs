namespace Strategy;

// Класс нашего человека
class Human
{
    // Поле в котором мы храним текущую профессию
    private IProfession? profession;

    // Метод установки профессии
    public void SetProfession(IProfession profession)
    {
        this.profession = profession;
        Console.WriteLine($"SetProfession to {this.GetType().Name}: {profession.GetType().Name}");
    }

    // Метод работы
    public void DoWork()
    {
        // Который проверяет, есть ли профессия. Если есть работаем, если нет, то ничего не делаем.
        if (profession is not null)
            profession.DoWork();
        else
            Console.WriteLine($"{this.GetType().Name} have no profession");
    }
}