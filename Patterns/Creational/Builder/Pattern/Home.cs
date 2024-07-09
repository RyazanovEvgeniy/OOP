namespace Pattern;

// Класс дома, который мы строим
public class Home
{
    // Который имеет поле листа с частями дома
    private readonly List<string> parts = [];

    // Метод добавления элемента дома
    public void Add(string part)
    {
        parts.Add(part);
    }

    // Метод перечисления элементов дома
    public string ListParts()
    {
        string result = string.Empty;

        for (int i = 0; i < parts.Count; i++)
        {
            result += parts[i];

            if (i != parts.Count - 1)
                result += ", ";
        }

        if (result?.Length == 0)
            return "Home parts: none";
        else
            return "Home parts: " + result;
    }
}