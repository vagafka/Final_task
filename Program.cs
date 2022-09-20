// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите массив строк через пробел");
string N = Console.ReadLine();
int newarraylength = 0;

string[] array = N.Split(" ");

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newarraylength++;
    }
        
}
string[] newarray = new string[newarraylength];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newarray[j] = array[i];
        j++;
    }

}

for (int i = 0; i < newarraylength; i++)//цикл вывода нового массива 
{
    Console.WriteLine(newarray[i]);
}