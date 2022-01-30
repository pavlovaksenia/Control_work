Console.Write("Введите колличество элементов массива: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите элементы массива: ");
string[] array = new string[number];
for (int i = 0; i < number; i++)
{
    Console.Write(i + 1 + ". ");
    array[i] = Console.ReadLine();
}

string[] newArray = new string[number];
int j = 0;

for (var i = 0; i < number; i++)
{
    if (array[i].Length < 4 && array[i].Length > 0)
    {
        newArray[j] = array[i];
        j++;
    }
}

Array.Resize(ref newArray, j);

if (newArray.Length > 0)
{
    Console.WriteLine("Новый массив: ");
    for (var i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine(i + 1 + ". " + newArray[i]);
    }
}
else
{
    Console.WriteLine("Новый массив пуст");
}