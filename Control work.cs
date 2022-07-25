// Контрольная работа
int size;
Console.WriteLine("Сколько элементов массива вы хотите ввести");
while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
{
    Console.WriteLine("Ошибка ввода, попробуйте снова");
    Console.WriteLine("Введите целое число");
};

string[] array = new string[size];
