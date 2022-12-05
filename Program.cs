//Вид 1
/* void Method1()
{

Console.WriteLine("Автор ...");

}
Method1();

//Вид 2

/*void Method2(string msg)
{
    Console.WriteLine();
}
Method2(msg:"текст сообщения");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {

            Console.WriteLine(msg);
            i++;

    }


}
Method21(msg: "Текст ", count: 4);

//Вид 3

int Method3()
{

    return DateTime.Now.Year;

}
int year = Method3();
Console.WriteLine(year);
*/
//Вид 4

/*string Method4(int count, string c)
{


    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result + text;
    }
    return result;
}
*/
/*
    for (int i = 2; i <= 10; i++)
    {

        for (int j = 0; j <= 10; j++)
        {

            Console.WriteLine($"{i} x {j} = {i * j}");

        }

    }
Console.WriteLine();
*/
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
                + "ежели бы вас послали вместо нашего милого "
                + "Винценгероде, вы бы взяли приступом согласие"
                + "прусского короля. Вы так красноречивы. Вы"
                + "дадите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
        {
            if(text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
        }        
    return result;

}
Console.WriteLine();
string newText = Replace(text,'к', 'К' );
Console.WriteLine(newText);
*/

int[] arr = {1, 5, 8 ,6 ,4 ,7 ,4 ,2 ,4, 9, 4, 6, 7};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
        
    }
    Console.WriteLine();

}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if(array[j] < array [minPosition]) minPosition = j; 

        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }

}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);