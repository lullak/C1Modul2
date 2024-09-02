

int x = 3;
Assign3(ref x);
Console.WriteLine(x);
void Assign3(ref int x)
{
    x = x + 3;
}


int y;
Out3(out y);
Console.WriteLine(y);
void Out3(out int y)
{
    y = 3;
}


Console.ReadLine();