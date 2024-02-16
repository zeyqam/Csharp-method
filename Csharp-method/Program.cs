//Task1
//Temp qebul eden method yazin return type olan.Temp 20 den boyukdurse isti, kicikdirse soyuq, beraberdirse mulayim yazsin. 
//string TempControl(int temp)
//{
//    if (temp > 20)
//    {
//        return "hot";
//    }
//    else if (temp < 20)
//    {
//        return "Cold";
//    }
//    else
//    {
//        return "Mild";
//    }



//}
//int temp = 20;
//Console.WriteLine(TempControl(temp));
//Task2
//methoda ave b edeleri gelecek,method a ve be arasindaki edelerin sayin qaytarsin
//int CountNumbers(int a,int b)
//{
//    int count = 0;
//    if (a < b)
//    {
//        for(int i = a+1; i < b; i++)
//        {
//            count++;
//        }

//    }
//    else if (a > b)
//    {
//        for( int i = b+1;i < a; i++)
//        {
//            count++;
//        }
//    }
//    return count;
//}
//int a = 5;
//int b = 10;
//Console.WriteLine(CountNumbers( a, b));
//Task3
//Method reqemlerden ibaret 2 array qebul edecek,her iki array elemetlerin cemini geri qaytarsin
//int SumOfArray(int[] arr1, int[] arr2)
//{
//    int sum = 0;
//    for (int i = 0; i < arr1.Length; i++)
//    {
//        sum += arr1[i];
//    }
//    for (int i = 0; i < arr2.Length; i++)
//    {
//        sum += arr2[i];
//    }
//    return sum;
//}
//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 5, 6 };
//Console.WriteLine(SumOfArray(arr1,arr2));
//Task4
//methoda eded gelir ,hemin method ededin kvadratin geri qaytarsin
//int Square(int number)
//{
//    return number * number;
//}
//int number = 5;
//Console.WriteLine(Square(number));
//Task5
//methoda eded gelir,hemin method 1 den gelen edede qeder olan cut ededlerin cemini geri qaytarsin
//int SumOfEvenNumbers(int num)
//{
//    int sum = 0;
//    for(int i = 1; i <= num; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}
//int num = 10;
//Console.WriteLine(SumOfEvenNumbers(num));
int FindMax(int[] numbers)
{
    if(numbers== null || numbers.Length == 0)
    {
        Console.WriteLine("No numbers provided");

    }
    int max = numbers[0];
    for(int i=1; i<numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }

    return max;

    

    
}
int []arr = { 1, 3, 4, 5, 6 };
Console.WriteLine(FindMax(arr));