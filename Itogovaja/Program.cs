//Программа из имеющегося массива строк формирует  массив из строк,
//длинна которых меньше или равна 3 символа.

string[] array = {"слово", "пёс", "вой", "крест", "бак", "сук", "троя", "дык", "прыг", "да", "а", " "};
string[] arrayizm = new string[array.Length];

FirstArray(array);
ArrayIzm(arrayizm, array);

void FirstArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"  [{ array[i]}]");        
    } 
    Console.WriteLine();
}

void ArrayIzm(string[] arrayizm, string[] array2)
{
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array[count] = array[i];
        count++;
         Console.Write($"  [{array[i]}]");
        }
    }
}