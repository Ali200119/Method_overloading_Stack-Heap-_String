#region Method Overloading

//using Heap_Stack;

//Overloading.Test();

//Overloading.Test("Hello P135");

//Overloading.Test("Run", 7);

#endregion



#region Heap-Stack

//int a = 5;
//int b = a;
//b = 7;

//Console.WriteLine(a);
//Console.WriteLine(b);

//int[] array = { 10, 23, 16, 8 };
//int[] array2 = array;
//array[0] = 7;

//Console.WriteLine(array[0]);

#endregion



#region Task

Console.BackgroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("Hi. Please, enter a word yo want to reverse:");

string show = Reverse(Console.ReadLine());

Console.WriteLine(show);

static string Reverse(string word)
{
    char[] array = word.Trim().ToCharArray();

    string result = "";

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result += array[i];
    }

    return result;
}

#endregion