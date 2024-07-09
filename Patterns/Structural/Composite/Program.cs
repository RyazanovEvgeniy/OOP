using Pattern;

// Суть шаблона Компоновщик (Composite) - создание абстрактного класса,
// в данном примере класса Component,
// с какими либо общими методами, в данном случае GetInfo,
// что позволяет сформировать из объектов наследуемых от Component древовидную структуру.
// В дальнейшем это позволяет работать с этой структурой как с единым объектом

// Создаем первую ветку, так как она самая первая, то по факту это дерево;)
Branch tree = new();

// На ней вырастает первая ветка с двумя листочками
Branch branch1 = new();
branch1.Add(new Leaf());
branch1.Add(new Leaf());
tree.Add(branch1);

// Еще ветка с одним листочком и веткой без листьев
Branch branch2 = new();
branch2.Add(new Leaf());
Branch branch3 = new();
branch2.Add(branch3);
tree.Add(branch2);

// Выводим то, что произрастает
Console.WriteLine($"Tree: {tree.GetInfo()}\n");

Console.Read();