namespace Homework2;

public interface IChair
{
    void HasLegs();
    void SitOn();
}
public class VictorianChair : IChair
{
    public void HasLegs() => Console.WriteLine("Has Legs");
    public void SitOn() => Console.WriteLine("Sit on VictorianChair");
}

public class ModernChair : IChair
{
    public void HasLegs() => Console.WriteLine("Has no Legs");
    public void SitOn() => Console.WriteLine("Sit on ModernChair");
}

public class ArtDecoChair : IChair
{
    public void HasLegs() => Console.WriteLine("Has Legs");
    public void SitOn() => Console.WriteLine("Sit on ArtDecoChair");
}

public interface ICoffeeTable
{
    void IsRound();
    void PlaceOn();
}

public class VictorianCoffeeTable : ICoffeeTable
{
    public void IsRound() => Console.WriteLine("Is Round");
    public void PlaceOn() => Console.WriteLine("Placed on Victorian");
}

public class ModernCoffeeTable : ICoffeeTable
{
    public void IsRound() => Console.WriteLine("Is Round");
    public void PlaceOn() => Console.WriteLine("Placed on {nameof(ModernCoffeeTable)}");
}


public class ArtDecoCoffeeTable : ICoffeeTable
{
    public void IsRound() => Console.WriteLine("Is Not Round");
    public void PlaceOn() => Console.WriteLine("Placed on ArtDecoCoffeeTable");
}

public interface ISofa
{
    void HasLegs();
    void SitOn();
}
public class VictorianSofa : ISofa
{
    public void HasLegs() => Console.WriteLine("Has Legs");
    public void SitOn() => Console.WriteLine("Sat on VictorianSofa");

}

public class ModernSofa : ISofa
{
    public void HasLegs() => Console.WriteLine("Has No Legs");
    public void SitOn() => Console.WriteLine("Sat on ModernSofa");
}

public class ArtDecoSofa : ISofa
{
    public void HasLegs() => Console.WriteLine("Has Legs");
    public void SitOn() => Console.WriteLine("Sat on ArtDecoSofa");

}

public abstract class FurnitureFactory
{
    public abstract IChair CreateChair();
    public abstract ISofa CreateSofa();
    public abstract ICoffeeTable CreateCoffeeTable();
}

public class VictorianFurnitureFactory : FurnitureFactory
{
    public override IChair CreateChair() => new VictorianChair();

    public override ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();

    public override ISofa CreateSofa() => new VictorianSofa();
}

public class ModernFurnitureFactory : FurnitureFactory
{
    public override IChair CreateChair() => new ModernChair();

    public override ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

    public override ISofa CreateSofa() => new ModernSofa();
}

public class ArtDecoFurnitureFactory : FurnitureFactory
{
    public override IChair CreateChair() => new ArtDecoChair();

    public override ICoffeeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();

    public override ISofa CreateSofa() => new ArtDecoSofa();
}

public class Program
{
    static void Main()
    {
        FurnitureFactory factory = new VictorianFurnitureFactory();
        factory.CreateChair().SitOn();

        factory = new ModernFurnitureFactory();
        factory.CreateChair().SitOn();

        factory = new ArtDecoFurnitureFactory();
        factory.CreateChair().SitOn();
    }
}