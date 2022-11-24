Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] array = new string[num];
int arrayLength = 0;
for (int i = 0; i < num; i++)
{
    Console.Write($"Введите {i + 1} элемент: ");
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3)
        arrayLength++;
}

if (arrayLength > 0)
{
    string[] arrayNew = new string[arrayLength];
    Console.WriteLine("Массив из элементов длина которого меньше или равно трём: ");
    int indexNew = 0;

    for (int i = 0; i < num; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[indexNew] = array[i];
            Console.WriteLine($"Это {i + 1} элемент, со значением: {array[i]}");
            indexNew++;
        }

    }
}
else Console.WriteLine("Не было ни одного элемента длина которого меньше или равно трём");