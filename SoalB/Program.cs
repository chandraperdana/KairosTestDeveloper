string val;
Console.WriteLine("Example Input: 1225441");
Console.Write("Input: ");
val = Console.ReadLine();
for (int i = 0; i < val.Length; i++)
{
    int b = val.Length - i;
    string c = "";

    for (int j = 0; j < b - 1; j++)
    {
        c = c + "0";
    }
    Console.WriteLine(val[i] + c);
}
