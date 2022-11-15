Arrow arrow = GetArrow();
Console.WriteLine("Price: " + arrow.Coast + " gold.");
Console.ReadKey();

// -------- METHODS ---------
Arrow GetArrow()
{
    Arrowhead head = GetArrowHead();
    Fletching fletching = GetFletching();
    float length = GetLengh();

    return new(head, fletching, length);
}
float GetLengh()
{
    float length;

    do
    {
        Console.Write("Enter length: ");
        length = Convert.ToSingle(Console.ReadLine());
    } while (length > 100 || length < 60);

    return length;

}
Fletching GetFletching()
{
    Console.Write("Enter fletching type: ");
    string input = Console.ReadLine().ToLower();

    return input switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers,
    };
}
Arrowhead GetArrowHead()
{
    Console.Write("Enter arrowhead: ");
    string input = Console.ReadLine().ToLower();

    return input switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian,
    };
}

// -------- CLASSES ---------
internal class Arrow
{
    public Arrowhead Head { get; }
    public Fletching Fletching { get; }
    public float Length { get; }

    public Arrow(Arrowhead head, Fletching fletching, float length)
    {
        this.Head = head;
        this.Fletching = fletching;
        this.Length = length;
    }

    public float Coast
    {
        get
        {
            (float headCost, float fletchingCost, float lengthCost) cost;

            cost.headCost = this.Head switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5
            };

            cost.fletchingCost = this.Fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeathers => 5,
                Fletching.GooseFeathers => 3
            };

            cost.lengthCost = this.Length * 0.05f;

            return cost.headCost + cost.fletchingCost + cost.lengthCost;
        }
    }
}

// -------- ENUMERATORS ---------
enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }