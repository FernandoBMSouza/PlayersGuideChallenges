Console.Write("Enter five values (,): ");
string answer = Console.ReadLine();

string[] texValues = answer.Split(',');
int[] oldArray = new int[texValues.Length];

for (int i = 0; i < texValues.Length; i++)
{
    oldArray[i] = Convert.ToInt32(texValues[i]);
}

int[] newArray = oldArray[0..];

//int[] newArray = new int[oldArray.Length];

//for (int i = 0; i < newArray.Length; i++)
//{
//    newArray[i] = oldArray[i];
//}

Console.WriteLine("\nOldArray: \n");
for (int i = 0; i < oldArray.Length; i++)
{
    Console.WriteLine($"\tIndex({i}): {oldArray[i]}");
}

Console.WriteLine("\nNewArray: \n");
for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine($"\tIndex({i}): {newArray[i]}");
}