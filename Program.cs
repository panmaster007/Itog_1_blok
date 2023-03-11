// Функция принимает число из консоли и обрабатывает ошибку ввода
int IntInput(string argument)
{
	int num;

	Console.Write($"Введите {argument}: ");
	while (!int.TryParse(Console.ReadLine(), out num))
	{
		Console.WriteLine("Error! it's not an integer!");
		Console.Write($"Try again! Введите {argument} = ");
	}
	return num;
}

// Функция принимает строку из консоли
string ReadString(string argument)
{
	Console.Write($"Введите {argument}: ");
	return Console.ReadLine();
}

// Функция создает массив целых элементов, введенных пользователем
string[] GetArrayString(int length)
{
	string[] array = new string[length];

	for (int i = 0; i < length; i++)
	{
		array[i] = ReadString("элемент массива");
	}

	return array;
}

// Функция распечатывает содержимое строчного массива через запятую кроме последнего элемента
void PrintArr(string[] array)
{
	for (int i = 0; i <= array.Length - 1; i++)
	{
		if (i == array.Length - 1)
		{
			Console.Write($"{array[i]}");
		}
		else
		{
			Console.Write($"{array[i]}, ");
		}
	}
}

// Функция записывает массив из коротких значений
string[] GetArrayShortStrings(int length, string[] arr)
{
	string[] array = new string[GetCountShortStrings(length, arr)];
	int z = 0;

	for (int j = 0; j < arr.Length; j++)
	{
		if (arr[j].Length < length + 1)
		{
			array[z] = arr[j];
			z++;
		}
	}

	return array;
}

// Функция считает количество коротких значений
int GetCountShortStrings(int length, string[] arr)
    {
      int count = 0;

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i].Length < length + 1) count++;
      }

      return count;
    }

// Вызов на исполнение модулей(методов) программы
Console.Clear();
int numbLetters = IntInput("до какого максимум количества символов отсортировывать элементы ");
string[] array = GetArrayString(IntInput("длину массива"));
PrintArr(array);
Console.WriteLine();
string[] arr = GetArrayShortStrings(numbLetters, array);
PrintArr(arr);