// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] IntArray = { 2, 29, 6, 77, 3, 11, 8, 88, 4, 99 };

//for (int i=0; i<=IntArray.Length-1; i++)
//{
//    for (int j=i+1; j<= IntArray.Length-1;j++)
//    {
//        if (IntArray[i]>IntArray[j])
//        {
//            int temp = IntArray[i];
//            IntArray[i] = IntArray[j];
//            IntArray[j] = temp;
//        }
//    }
//}
//IntArray = IntArray.OrderBy(c=> c).ToArray();
//Console.WriteLine(string.Join(',', IntArray));

//int[] array = { 1, 3, -1, 2, -4, 9, 11 };
int[] array = { 1, 3, -1, 5,-4 };
int max=0,max2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if(max<array[i])
    {
        max2 = max; // Assign the current max to max2 before updating max
        max = array[i];
    }
    else if (max2 < array[i] && max != array[i])
    {
        max2 = array[i];
    }
}
Console.WriteLine(max2);







Console.Read();







