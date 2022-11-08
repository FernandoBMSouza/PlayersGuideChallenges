int[] array = new[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int minimumValue = int.MaxValue;
int total = 0;
foreach (int item in array)
    if(item < minimumValue) minimumValue = item;

Console.WriteLine("Minimum: " + minimumValue);

foreach (int value in array)
    total += value;

float avarage = (float)total / array.Length;
Console.WriteLine($"Avarage: {avarage:#.##}");