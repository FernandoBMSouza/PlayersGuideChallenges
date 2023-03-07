#region Point
//Point p1 = new Point(2, 3);
//Point p2 = new Point(-4, 0);

//Console.WriteLine(p1);
//Console.WriteLine(p2);
#endregion

#region Color
//Color darkBlue = new Color(0, 128, 255);
//Color yellow = Color.Yellow;

//Console.WriteLine("darkBlue: " + darkBlue);
//Console.WriteLine("yellow: " + yellow);
#endregion

#region Card
//CardColor[] cardColors = new CardColor[] { CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow };
//CardRank[] cardRanks = new CardRank[] { CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.DollarSign, CardRank.Percent, CardRank.Caret, CardRank.Ampersand };
//int count = 0;

//foreach (CardColor color in cardColors)
//    foreach (CardRank rank in cardRanks)
//    {
//        count++;
//        Card card = new Card(color, rank);
//        Console.WriteLine(count + " - " + card);
//    }
#endregion


internal class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point() : this(0, 0) { }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

internal class Color
{
    public int R { get; }
    public int G { get; }
    public int B { get; }

    public Color(byte red, byte green, byte blue)
    {
        R = red;
        G = green;
        B = blue;
    }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);

    public override string ToString()
    {
        return $"R: {R} G: {G} B: {B}";
    }
}

internal class Card
{
    public CardColor Color { get; }
    public CardRank Rank { get; }

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }

    public bool isSymbol =>
        Rank == CardRank.DollarSign || Rank == CardRank.Percent || Rank == CardRank.Caret || Rank == CardRank.Ampersand;

    public bool isNumber => !isSymbol;

    public override string ToString()
    {
        return $"The {Color} {Rank}";
    }
}

enum CardColor { Red, Green, Blue, Yellow }

enum CardRank
{
    One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
    DollarSign, Percent, Caret, Ampersand
}