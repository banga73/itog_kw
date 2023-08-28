void PrintArray(string[] Array) // print 1-dim array
{
	for (int i = 0; i < Array.Length; i++)
	{
		Console.Write($"{Array[i]} ");
	}
}
string[] OurData = {"IPhone", "123", "My", "irene", "kwa", "?:", "5"};
int i_new = 0;
for (int i = 0; i < OurData.Length; i++)
{
	if (OurData[i].Length <= 3)
	{
		i_new += 1;
	}
}
string[] NewData = new string [i_new];
int j = 0;
for (int i = 0; i < OurData.Length; i++)
{
	if (OurData[i].Length <= 3)
	{
		NewData[j] = OurData[i];
		j += 1;
	}
}
PrintArray(NewData);