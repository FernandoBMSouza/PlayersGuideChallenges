Arrow arrow = GetArrow();
Console.WriteLine("Price: " + arrow.GetCost() + " gold.");
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
    private Arrowhead head;
    private Fletching fletching;
    private float length;

    public Arrow(Arrowhead head, Fletching fletching, float length)
    {
        this.head = head;
        this.fletching = fletching;
        this.length = length;
    }

    public Arrowhead GetArrowHead() => this.head;
    public float GetLength() => this.length;
    public Fletching GetFletching() => this.fletching;

    public float GetCost()
    {
        (float headCost, float fletchingCost, float lengthCost) cost;

        cost.headCost = this.head switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5
        };

        cost.fletchingCost = this.fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };

        cost.lengthCost = this.length * 0.05f;

        return cost.headCost + cost.fletchingCost + cost.lengthCost;
    }
}

// -------- ENUMERATORS ---------
enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }