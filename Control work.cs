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