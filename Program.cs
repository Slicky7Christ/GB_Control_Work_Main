/* Примеры
{"Hello", "2", "world", ":-)"}
{"1234", "1567", "-2", "computer science"}
{"Russia", "Denmark", "Kazan"}
*/

string[] starting_Array = {"Russia", "Denmark", "Kazan"};
string[] final_Array = GenNewArray(starting_Array);
PrintArray(starting_Array);
PrintArray(final_Array);

string[] PrintArray(string[] print_Array)
{
    int length_arr = 0;
    foreach (string item in print_Array)
    {
        Console.Write(item);
        if (length_arr != print_Array.Length - 1)
        {
            Console.Write(", ");
            length_arr++;
        }
    }
    Console.WriteLine();
    return print_Array;
}

string[] GenNewArray(string[] Array)
{
    string[] new_Array = new string[CountThreeItems(Array)];
    int i = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            new_Array[i] = item;
            i++;
        }
    }
    return new_Array;
}

int CountThreeItems(string[] Array)
{
    int count = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    return count;
}