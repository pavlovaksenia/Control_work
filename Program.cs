Console.Write("Введите колличество элементов массива: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите элементы массива: ");
string[] array = new string[number];
for (int value = 0; value < number; value++)
{
    Console.Write(value + 1 + ". ");
    array[value] = Console.ReadLine();
}

string[] newArray = new string[number];
int new_value = 0;

for (var value = 0; value < number; value++)
{
    if (array[value].Length < 4 && array[value].Length > 0)
    {
        newArray[new_value] = array[value];
        new_value++;
    }
}

Array.Resize(ref newArray, new_value);

if (newArray.Length > 0)
{
    Console.WriteLine("Новый массив: ");
    for (var value = 0; value < newArray.Length; value++)
    {
        Console.WriteLine(value + 1 + ". " + newArray[value]);
    }
}
else
{
    Console.WriteLine("Новый массив пуст");
}