using Structural.adapter;
using Structural.bridge;
using Structural.composite;
using Structural.decorator;
using Structural.facade;
using Structural.flyweight;
using Structural.proxy;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//Adapter

ILocalPayment payment = new StripeAdapter();
payment.ProcessPayment(1000);

//Adapter end

Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();

//Bridge

IDevice tv = new TVDevice();
AdvancedRemoteControl remote = new AdvancedRemoteControl(tv);
remote.TogglePower();
remote.Mute();

//Brige end

Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();

//Composite

Folder root = new Folder("Root");
Folder docs = new Folder("Documents");
docs.Add(new FileItem("Resume.pdf", 500));
root.Add(docs);
root.Add(new FileItem("Photo.jpg", 1500));
root.Display();

//Composite end

Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();

//Decorator

ICoffee myCoffee = new Espresso();
myCoffee = new Milk(myCoffee);
myCoffee = new Caramel(myCoffee);
Console.WriteLine($"{myCoffee.GetDescription()} коштує {myCoffee.GetCost()} грн.");

//Decorator end

Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();

//Facade

HomeCinemaFacade cinema = new HomeCinemaFacade();
cinema.WatchMovie("Матриця");

//Facade end

Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();

//Flyweight

var forest = new List<Tree>();
var oakType = TreeFactory.GetTreeType("Дуб", "Зелений", "OakTexture.png");
var pineType = TreeFactory.GetTreeType("Сосна", "Темно-зелений", "PineTexture.png");
forest.Add(new Tree(10, 20, oakType));
forest.Add(new Tree(15, 25, oakType));
forest.Add(new Tree(100, 200, pineType));
foreach (var tree in forest) tree.Draw();

//Flyweight end

Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();

//Proxy

IImage image = new ImageProxy("big_photo.png");
image.Display();

//Proxy end
