Console.WriteLine("Введите строку");
string input = Console.ReadLine();
string output = "";
for (int i = 0; 1 < input.Length; i++)
{
    char symbol = input[i];
    if (1 % 2 == 0)
    {
        output += output + Char.ToLower(symbol);
    }
    else
    {
        output += output + Char.ToLower(symbol);
    }
    Console.WriteLine(output);
    Console.ReadKey();
}

Console.WriteLine("Введите число:");
int temp = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < temp && i < 1000; i++)
{
    Console.Write(i + "");
}
Console.ReadKey();

Console.WriteLine("Введите число:");
int[] temp = new int[5];
for (int i = 0; i < 5; i++)
{
    temp[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вывод в обратном порядке:");
for (int i = 4; i >= 0; i--)
{
    Console.WriteLine(temp[i] + "");
}
Console.ReadKey();
