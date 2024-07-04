using Pattern;

// Суть шаблона Mediator - в замене связи многие ко многими,
// на связь один ко многим, вынося логику взаимодействия объектов
// из самих объектов в класс посредник, значительно их упрощая.

Chef chef = new();
Packer packer = new();
Courier courier = new();

var _ = new BurgerMediator(chef, packer, courier);

Console.WriteLine("Order of burger:");
chef.MakeBurger();

Console.Read();