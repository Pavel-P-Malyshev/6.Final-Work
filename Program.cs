/* Задача: написать программу, которая из имеющегося массива строк фомирует массив из строк, 
длина которых меньше либо равна 3 символам.Первоначальный массив можгл ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/


//ввод набора чисел с консоли строкой
string[] ParseArray(string message)
{
    Console.WriteLine(message);
    string[] nums = Console.ReadLine().Split(new char[] { ',' });
    string[] strArray = new string[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        strArray[i] = nums[i];
    }
    return strArray;

}




//ввод значения с клавиатуры
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


//распечатка массива
void PrintArray (string[] col)
{

    int count=col.Length;
    int position=0;

    Console.Write("[ ");
    while(position<count) 
    {
        if(position==count-1)  {Console.Write($" \"{col[position]}\"");}
        else {Console.Write($"\"{col[position]}\", ");}
        
        position++;
    }
    Console.WriteLine("] ");

}

string[] input=ParseArray("ВВедите массив строк через запятую");
PrintArray(input);