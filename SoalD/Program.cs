int val1;
int val2;
Console.WriteLine("Example Input: From: 1 To:19");

Console.Write("From: ");
val1 = Convert.ToInt32(Console.ReadLine());

Console.Write("To: ");
val2 = Convert.ToInt32(Console.ReadLine());

int a = 5;
int b = 6;

for (int i = val1; i < val2 + 1; i++)
{
    string c = "IDIC";
    string d = "LPS";

    if (i != a && (i % a) == 0)
    {
        Console.Write(c + " ");
    }
    else if (i != b && (i % b) == 0)
    {
        Console.Write(d + " ");
    }
    else
    {
        Console.Write(i + " ");
    }
}