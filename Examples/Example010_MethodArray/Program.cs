int[] array = { 11, 25, 38, 47, 94, 65, 76, 47, 58 };

int n = array.Length;
int find = 47;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}