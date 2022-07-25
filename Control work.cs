// Контрольная работа
int size;
Console.WriteLine("Сколько элементов массива вы хотите ввести");
while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
{
    Console.WriteLine("Ошибка ввода, попробуйте снова");
    Console.WriteLine("Введите целое число");
};

string[] array = new string[size];
FillArray(array);
int NewSize = CountNewSize(array);

// функция заполняет массив

void FillArray(string[] arr)
{
    for (int x = 0; x < size; x++)
    {
        Console.WriteLine("Введите элемент ");
        while (String.IsNullOrEmpty(arr[x]=Console.ReadLine()))
            Console.WriteLine("Ошибка ввода, попробуйте снова");
    }

}

// функция высчитывает новый размер массива

int CountNewSize(string[] arr)
{
    int Count = 0;
    for (int y = 0; y < size; y++)
    {
        if (arr[y].Length <= 3)
        {
            Count = Count + 1;

        }

    }
    return Count;
}