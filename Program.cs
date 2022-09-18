/* Задача: написать программу, которая из имеющегося массива строк фомирует массив из строк, 
длина которых меньше либо равна 3 символам.Первоначальный массив можгл ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/


//ввод набора строк с консоли через разделитель ","
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



//основной метод
string[] LeaveShorts(string[] messages)
{
    
    int shorts=0;
    string[] Shorts=new string[messages.Length];

    for (int i = 0; i < messages.Length; i++)
    {
        if (messages[i].Length<=3)
        {
            Shorts[shorts]=messages[i];
            shorts++;
        }
    }
    
    string[] result=new string [shorts];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]=Shorts[i];
    }

    return result;

}



//распечатка массива строк
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




string[] input=ParseArray("Введите строки через запятую:");
Console.WriteLine("Ваш массив строк:");
PrintArray(input);
Console.WriteLine("Получившийся массив строк с длиной не более 3 символов: ");
PrintArray(LeaveShorts(input));