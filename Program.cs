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
//работа с массивом
string [] arrIn = {"Hello", "2", "world", ":-)"};
string [] arrOut = {};
Console.WriteLine("Исходный массив: ");
printArr(arrIn);
int idx = 0;
while (idx<arrIn.Length) {
    if (arrIn[idx].Length<=3) {
        //arrOut = addToArr(arrOut,arrIn[idx]);
        arrOut=arrOut.Concat(new string[] {arrIn[idx]}).ToArray();
    }
    idx++;
}    
Console.WriteLine("Обработанный массив:");
printArr(arrOut);
