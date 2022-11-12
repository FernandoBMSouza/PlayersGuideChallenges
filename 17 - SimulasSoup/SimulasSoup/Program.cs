(Food Food, Ingredient Ingredient, Seasoning Seasoning)[] pots = new (Food, Ingredient, Seasoning)[3];

for (int i = 0; i < pots.Length; i++)
    pots[i] = GetSoup();

foreach (var pot in pots)
    Console.WriteLine($"{pot.Seasoning} {pot.Ingredient} {pot.Food}");

(Food, Ingredient, Seasoning) GetSoup()
{
    Food food = GetSoupType();
    Ingredient ingredient = GetIngredient();
    Seasoning seasoning = GetSeasoning();
    return (food, ingredient, seasoning);
}

Food GetSoupType()
{
    Console.Write("Enter type: ");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "soup" => Food.Soup,
        "stew" => Food.Stew,
        "gumbo" => Food.Gumbo
    };
}

Ingredient GetIngredient()
{
    Console.Write("Enter main ingredient: ");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "mushrooms" => Ingredient.Mushrooms,
        "chicken" => Ingredient.Chicken,
        "carrots" => Ingredient.Carrots,
        "potatoes" => Ingredient.Potatoes
    };
}

Seasoning GetSeasoning()
{
    Console.Write("Enter seasoning: ");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet
    };
}

enum Food { Soup, Stew, Gumbo }
enum Ingredient { Mushrooms, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }