int[] array = {11, 12, 10, 4, 45, 98, 4, 5, 3};

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

index++;

}