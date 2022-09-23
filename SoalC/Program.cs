string val;
Console.WriteLine("Example Input: hello world");
Console.Write("Input: ");
val = Console.ReadLine();

string val2 = "";
val = val.Replace(" ", String.Empty);

for (int i = 0; i < val.Length; i++)
{
    int count = val.Split(val[i]).Length - 1;
    if (!val2.Contains(val[i]))
    {
        Console.WriteLine(val[i] + "-" + count);
    }
    val2 += val[i];
}
