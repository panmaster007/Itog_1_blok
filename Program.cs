// Функция принимает число из консоли и обходит ошибку ввода
int IntInput(string intName) // функция принимает число из консоли, преобразуя его в целое                   
{
    int num;

    Console.Write($"Введите число {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ерунда какая-то... Ощущение, что введено не целое число.");
        Console.Write($"Ну-ка, еще разок! {intName} = ");
    }
    return  num;
}

// Функция создает массив целых элементов, введенных пользователем
int[] createArr(int size)
{
    int[] arr = new int[size];
    for (int i=0; i < size; i++)
    {
        arr[i] = IntInput("arr[" + i + "]");
        //Console.WriteLine($"arr[{i}] = {arr[i]}");
        //Console.WriteLine(string.Join(" ",arr));
    }
    return arr;
}

// Функция распечатывает содержимое массива
void printArr(int[] array)
{
    string str = "";
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (i != array.Length-1 )
        {
            str = str  + array[i] + ", ";
        }
        else str = str  + array[i] + ".";
    }
    Console.WriteLine(str);
}