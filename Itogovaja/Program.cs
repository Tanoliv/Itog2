//Программа из имеющегося массива строк формирует  массив из строк,
//длинна которых меньше или равна 3 символа.

string[] array = {"слово", "пёс", "вой", "крест", "бак", "сук", "троя", "дык", "прыг", "да", "а", " "};

FirstArray(array);

void FirstArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"  [{ array[i]}]");        
    } 
    Console.WriteLine();
}

