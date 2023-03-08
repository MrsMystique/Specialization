Console.Clear();
Console.Write("Введите данные через пробел: ");
string item = Console.ReadLine();
string[] sourceArray = item.Split(' ');
Console.WriteLine("Исходный массив данных: [{0}]", string.Join(", ", sourceArray));

string[] targetArray = new string[sourceArray.Length];
int targetIndex = 0;

for (int i = 0; i < sourceArray.Length; i++)
{
    if (sourceArray[i].Length <= 3)
    {
        targetArray[targetIndex] = sourceArray[i];
        targetIndex++;
    }
}

Array.Resize(ref targetArray, targetIndex);

Console.WriteLine("Итоговый массив данных: [{0}]", string.Join(", ", targetArray));
