Sword sword = new Sword(Material.Iron, Gemstone.None, 32.5f, 10f);
Sword rareSword = sword with { material = Material.Binarium, gemstone = Gemstone.Bitstone };
Sword ancientSword = sword with { material = Material.Bronze, gemstone = Gemstone.Diamond, lenght = 22f };

Console.WriteLine($"{sword}\n{rareSword}\n{ancientSword}");

public record Sword(Material material, Gemstone gemstone, float lenght, float crossguardWidth);
public enum Material { Wood, Bronze, Iron, Steel, Binarium }
public enum Gemstone { None, Emerald, Sapphire, Diamond, Bitstone }