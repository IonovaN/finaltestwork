// сначала функция

void printArr (string[] arr) 
{
    int idx=0;
    Console.Write("[");    
    while (idx<arr.Length) 
    {
        if (idx == arr.Length-1) 
            Console.Write(arr[idx]);
        else 
            Console.Write(arr[idx]+",");
        idx++;
    }    
    Console.Write("]");    
}

