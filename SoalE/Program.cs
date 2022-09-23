string input;
string output;
string output2;

Console.WriteLine("Example Input: SeLamAT PAGi semua halOo");
Console.Write("Input: ");
input = Console.ReadLine();

output = String.Concat(input.Select((currentChar, index) => index == 0 ? Char.ToUpper(currentChar) : Char.ToLower(currentChar)));

int i = 0;
string temp = "";
string temp2;
output2 = input;

while (i+2 < output2.Length)
{
	if (i == 0)
	{
		char temp3 = char.ToUpper(output2[i]);
		temp2 = output2.Substring(i + 1).ToLower();
		output2 = string.Concat(temp3, temp2);
		i++;
	}
	if (output2[i].Equals(' '))
	{
		temp = output2.Substring(0, i);
		char alph = output2[i + 1];
		alph = char.ToUpper(alph);
		string temp4 = output2.Substring(i + 2).ToLower();
		output2 = string.Concat(temp, " ", alph.ToString(), temp4);
		i++;
	}
    i++;
}

Console.WriteLine("Format Judul: " + output2);
Console.WriteLine("Format Biasa: " + output);





