// Функция принимает число из консоли и обходит ошибку ввода
int IntInput(string argument) // функция принимает число из консоли, преобразуя его в целое                   
{
	int num;

	Console.Write($"Введите число {argument}: ");
	while (!int.TryParse(Console.ReadLine(), out num))
	{
		Console.WriteLine("Error! it's not an integer!");
		Console.Write($"Try again! {argument} = ");
	}
	return num;
}

// Функция создает массив целых элементов, введенных пользователем
int[] createArr(int size)
{
	int[] arr = new int[size];
	for (int i = 0; i < size; i++)
	{
		arr[i] = IntInput("arr[" + i + "]");
		//Console.WriteLine($"arr[{i}] = {arr[i]}");
		//Console.WriteLine(string.Join(" ",arr));
	}
	return arr;
}

// Функция распечатывает содержимое строчного массива через запятую кроме последнего элемента
void PrintArr(string[] array)
{
	for (int i = 0; i <= array.Length - 1; i++)
	{
		if (i == array.Length - 1)
		{
			Console.WriteLine($"{array[i]}");
		}
		else
		{
			Console.WriteLine($"{array[i]}, ");
		}
	}
}

// Вызов и исполнение модулей(методов) программы
Console.WriteLine();
int maxLength = 4;

string[] array = GetFilledArrayOfString(IntInput());
PrintArr(array);

string[] arr = GetArrayOfStringLessThanLength(maxLength, array);
PrintArr(arr);
Console.WriteLine();