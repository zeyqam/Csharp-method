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

//Task Lab
//int FindMax(int[] numbers)
//{
//    if(numbers== null || numbers.Length == 0)
//    {
//        Console.WriteLine("No numbers provided");

//    }
//    int max = numbers[0];
//    for(int i=1; i<numbers.Length; i++)
//    {
//        if (numbers[i] > max)
//        {
//            max = numbers[i];
//        }
//    }

//    return max;




//}
//int []arr = { 1, 3, 4, 5, 6 };
//Console.WriteLine(FindMax(arr));
//Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//int n = 21; 

//   if (CheckDivisibility(n))
//       {
//           Console.WriteLine(n + "  is divisible by 3 and/or 7");
//       }
//       else
//       {
//           Console.WriteLine(n +  "  is not divisible by 3 and/or 7");
//       }


//    bool CheckDivisibility(int n)
//   {

//       return n % 3 == 0 || n % 7 == 0;
//   }
// n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
//int CalculateSum(int n, int m)
//{
//    int sum=0; 
//    if (n %2==0 && m % 2 == 0)
//    {
//        sum= n + m;
//    }
//    else
//    {
//        Console.WriteLine("enter even numbers");
//    }
//    return sum;


//}
//int n=2; int m=6;
//Console.WriteLine(CalculateSum(n, m));

//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
// int CountOddNumbers(int n, int m)
//{
//    int count = 0;
//    for (int i = n + 1; i < m; i++)
//    {
//        if (i % 2 != 0)
//        {
//            count++;
//        }
//    }
//    return count;
//}
//int n = 1;
//int m = 10;
//Console.WriteLine(CountOddNumbers(n,m));
// Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
//int SumOfOddNumbers(int n, int m)
//{
//    int sum = 0;
//    for (int i = n + 1; i < m; i++)
//    {
//        if (i % 2 != 0)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}
//int n = 1;
//int m = 10;
//Console.WriteLine(SumOfOddNumbers(n,m));
//)Verilmish arrayin icindeki tek ededlerin cemini tapin.
//int SumOfOddNumbers(int[] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] != 2)
//        {
//            sum += arr[i];
//        }

//    }
//    return sum;
//}
//int[] arr = {1,2,3,4,5,6,7};
//Console.WriteLine(SumOfOddNumbers(arr));
//Verilmish arrayin icindeki cut ededlerin sayini tapin.
//int CountOfEvenNumbers(int[] arr)
//{
//    int count = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            count++;
//        }


//    }
//    return count;
//}
//int[] arr = {1,2,3,4,5,66,6};
//Console.WriteLine(CountOfEvenNumbers(arr));
//Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin
//bool IsPrime(int number)
//{
//    if (number <= 1) return false;

//    for (int i = 2; i <= Math.Sqrt(number); i++)
//    { 
//        if (number % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}
//int n = 2;
//if (IsPrime(n))
//{
//    Console.WriteLine(n +"  is simple");
//}
//else
//{
//    Console.WriteLine(n +" is Prime");
//}
// n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.Meselen: Cavablar ola  biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.
//bool IsPowerOf2()
//{
//    int n = 9;
//    for (int i = 1; i <= n; i *= 2)
//    {
//        if (i == n)
//        {
//            return true;
//        }
//    }
//    return false;


//}
//Console.WriteLine(IsPowerOf2() ? "quvvetidir":"quvveti deyil" );
//Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.
//int MultiplyNumbersBetween(int[] arr)
//{
//    int product = 1;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        int number= arr[i];
//        if(number>=1 && number <= 20)
//        {
//            product*= number;
//        }
//    }
//    return product;
//}
//int[] arr = { 2, 45, 6, 79, 34 };
//Console.WriteLine(MultiplyNumbersBetween(arr));
//Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
int SumOfSquareEvenNumbers(int[] arr)
{
    int sumOfEvenNumbers = 0;
    foreach (int number in arr)
    {
        if (number%2 == 0)
        {
            sumOfEvenNumbers += number;
        }
    }
    return sumOfEvenNumbers * sumOfEvenNumbers;
}
int[] arr = {1,2,34,5,6,7};
Console.WriteLine(SumOfSquareEvenNumbers(arr));

