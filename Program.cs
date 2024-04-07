/* Примеры
{"Hello", "2", "world", ":-)"}
{"1234", "1567", "-2", "computer science"}
{"Russia", "Denmark”, "Kazan"}
*/

string[] starting_Array = { "Hello", "2", "world", ":-)" };
string[] final_Array;
PrintArray(starting_Array);

string[] PrintArray(string[] print_Array)
{
    int length_arr = 0;
    foreach (string i in print_Array)
    {
        Console.Write(i);
        if (length_arr != print_Array.Length - 1)
        {
            Console.Write(", ");
            length_arr++;
        }
    }
    return print_Array;
}
