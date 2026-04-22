using behavioral.chainofresponsibility;
using behavioral.command;
using behavioral.iterator;
using behavioral.mediator;
using behavioral.memento;
using behavioral.observer;
using behavioral.state;
using behavioral.strategy;
using behavioral.templatmethod;
using behavioral.visitor;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// --- 1. STRATEGY ---
Console.WriteLine("=== 1. Strategy (Розрахунок вартості доставки) ===");
var calculator = new DeliveryCalculator(new BikeDelivery());
calculator.PrintCost(3.5);
calculator.SetStrategy(new CarDelivery());
calculator.PrintCost(12.0);

// --- 2. OBSERVER ---
Console.WriteLine("\n=== Observer ===");
var tracker = new OrderTracker();
tracker.Subscribe(new MobileAppCustomer("Олег"));
tracker.ChangeStatus("Прийнято кухнею");
tracker.ChangeStatus("Передано кур'єру");

// --- 3. COMMAND ---
Console.WriteLine("\n=== Command ===");
var chef = new Chef();
var terminal = new WaiterTerminal();
terminal.TakeOrder(new PizzaCommand(chef));
terminal.SendToKitchen();

// --- 4. STATE ---
Console.WriteLine("\n=== State ===");
var order = new OrderContext();
order.CancelOrder();
order.MoveNext();
order.CancelOrder();

// --- 5. CHAIN OF RESPONSIBILITY ---
Console.WriteLine("\n=== Chain of Responsibility ===");
var bot = new ChatBot();
var human = new HumanOperator();
bot.SetNext(human);
bot.Handle("Simple");
bot.Handle("Complex");

// --- 6. TEMPLATE METHOD ---
Console.WriteLine("\n=== Template Method ===");
var coffee = new CoffeeMaker();
coffee.MakeBeverage();

// --- 7. MEMENTO ---
Console.WriteLine("\n=== Memento ===");
var cart = new ShoppingCart();
cart.Add("Піца Маргарита");
cart.Add("Кока-Кола");
cart.Print();

var savedCart = cart.Save();
cart.Clear();
Console.WriteLine("Кошик випадково очищено!");
cart.Print();

cart.Restore(savedCart);
Console.WriteLine("Відновлюємо дані...");
cart.Print();

// --- 8. MEDIATOR ---
Console.WriteLine("\n=== Mediator ===");
var dispatcher = new DeliveryDispatcher();
var restaurant = new Restaurant(dispatcher);
restaurant.FoodReady();

// --- 9. ITERATOR ---
Console.WriteLine("\n=== Iterator ===");
var menu = new MenuCollection();
foreach (var item in menu)
{
    Console.WriteLine($"- {item}");
}

// --- 10. VISITOR ---
Console.WriteLine("\n=== Visitor ===");
var holidayDiscount = new HolidayDiscountVisitor();
var pizzaItem = new PizzaItem();
var drinkItem = new DrinkItem();

pizzaItem.Accept(holidayDiscount);
drinkItem.Accept(holidayDiscount);
