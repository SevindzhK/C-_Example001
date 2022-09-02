int [] array = {11,22,53,84,45,76,77,58,69};

int n = array.Length; 
int find = 84; 

int index = 0;

while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
    }
    // index = index + 1
    index ++;
}


