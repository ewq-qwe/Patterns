using CreationalRunner.abstract_factory;
using CreationalRunner.builder;
using CreationalRunner.factory;
using CreationalRunner.prototype;
using CreationalRunner.singleton;
using System.IO;

//Abstract
Console.WriteLine("------Abstract-----");
ISpaceShipFactory humanFactory = new HumanShipFactory();
IEngine humanEngine = humanFactory.CreateEngine();
IHull humanHull = humanFactory.CreateHull();

ISpaceShipFactory alienFactory = new AlienShipFactory();
IEngine alienEngine = alienFactory.CreateEngine();
IHull alienHull = alienFactory.CreateHull();

humanEngine.Start();
humanHull.ShowDurability();
Console.WriteLine("-------------");
alienEngine.Start();
alienHull.ShowDurability();
Console.WriteLine("------Abstract end-----");
Console.WriteLine();
//Abstract end

//Builder
Console.WriteLine("------Builder-----");

IShipBuilder warBuilder = new WarShipBuilder();
ShipyardDirector director = new ShipyardDirector(warBuilder);
director.ConstructFullShip();
SpaceShip warShip = warBuilder.GetShip();
warShip.ShowSpecs();

IShipBuilder cargoBuilder = new CargoShipBuilder();
director = new ShipyardDirector(cargoBuilder);
director.ConstructFullShip();
SpaceShip cargoShip = cargoBuilder.GetShip();
cargoShip.ShowSpecs();

Console.WriteLine("------Builder end-----");
Console.WriteLine();
//Builder end

//Factory
Console.WriteLine("------Factory-----");
ISupportShip miner = SupportShipFactory.CreateShip(SupportShipType.Miner);
miner.PerformDuty();

ISupportShip medic = SupportShipFactory.CreateShip(SupportShipType.Medical);
medic.PerformDuty();

ISupportShip diplomat = SupportShipFactory.CreateShip(SupportShipType.Diplomatic);
diplomat.PerformDuty();
Console.WriteLine("------Factory end-----");
Console.WriteLine();
//Factory end

//Factory Method
Console.WriteLine("------Factory Method-----");

Shipyard cargoYard = new CargoShipyard();
cargoYard.DispatchShip();

Console.WriteLine();

Shipyard fighterYard = new FighterShipyard();
fighterYard.DispatchShip();

Console.WriteLine("------Factory Method end-----");
Console.WriteLine();
//Factory Method end

//Prototype
Console.WriteLine("------Prototype-----");

SwarmDrone prototypeAlpha = new SwarmDrone("Alpha-7", 100, "Агресивний пошук");

SwarmDrone clone1 = (SwarmDrone)prototypeAlpha.Clone();
SwarmDrone clone2 = (SwarmDrone)prototypeAlpha.Clone();
SwarmDrone clone3 = (SwarmDrone)prototypeAlpha.Clone();

clone3.ModelName = "Alpha-7 (Командир)";
clone3.LaserPower = 150;

prototypeAlpha.ShowInfo();
clone1.ShowInfo();
clone2.ShowInfo();
clone3.ShowInfo();

Console.WriteLine("------Prototype-----");
Console.WriteLine();
//Prototype end

//Singleton
Console.WriteLine("------Singleton-----");

CommandCenter hq = CommandCenter.GetInstance();
Console.WriteLine($"На зв'язку командувач верфі: {hq.GetCommander()}");

Console.WriteLine("------Prototype end-----");
Console.WriteLine();
//Singleton end