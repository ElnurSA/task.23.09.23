//Task 2 

//Console.WriteLine("Add your word : ");

//string word = Console.ReadLine();

//static void Reverser(string word)
//{
//    word.ToCharArray();


//    foreach(char chars in word.Reverse())
//    {
//        Console.WriteLine(chars);
//    }
//}

//Reverser(word);


//Task 3:

// 1)

//int m = 42;

//static void Divide(int m)
//{
//    if(m % 3 == 0 && m % 7 == 0)
//    {
//        Console.WriteLine("Bolunur");
//    }
//    else
//    {
//        Console.WriteLine("Bolunmur");
//    }
//}

//Divide(m);

// 2)

//int m = 6;
//int n = 7;


//static void EvenMultiplier(int a, int b)
//{
//    int multiply = 1;
//    if (a % 2 == 0 && b % 2 == 0)
//    {
//        multiply = a * b;
//        Console.WriteLine(multiply);
//    }
//    else
//    {
//        Console.WriteLine("hansisa reqem 2 bolunmur");
//    }
//}

//EvenMultiplier(m, n);

//3)

//int n = 3;
//int m = 9;


//static void NumOfOdds(int a, int b)
//{
//    int count = 0;
//    for(int i = a; i <= b; i++)
//    {
//        if(i % 2 == 1)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}


//NumOfOdds(n, m);

// 4)

//int n = 3;
//int m = 5;

//static void SumOfOdds(int a, int b)
//{
//    int sum = 0;
//    for (int i = a; i <= b; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += i;
//        }
//    }
//    Console.WriteLine(sum);
//}


//SumOfOdds(n, m);

// 5)

//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

//static void SumOfOddsArray(int[] arr)
//{
//    int sum = 0;
//    foreach(int num in arr)
//    {
//        if(num % 2 == 1)
//        {
//            sum += num;
//        }
//    }
//    Console.WriteLine(sum);
//}

//SumOfOddsArray(arr);

// 6)

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//static void CountOfOddsArray(int[] arr)
//{
//    int count = 0;
//    foreach (int num in arr)
//    {
//        if (num % 2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//CountOfOddsArray(arr);

// 7)

//int n = 8;


//static void PrimeOrSimple(int n)
//{
//    int count = 0;
//    if (n < 0)
//    {
//        Console.WriteLine("enter possitive number");
//    }
//    else
//    {
//      for(int i = 2; i <=7; i++)
//      {
//        if(n % i == 0)
//        {
//            count++;
//        }
//      }
//      if(count > 1)
//      {
//        Console.WriteLine("number is simple");
//      }
//      else
//      {
//        Console.WriteLine("number is prime");
//      }
//    }


//}

//PrimeOrSimple(n);


// 8)

//int n = 64;

//static void PowersOf2(int n)
//{

//    int divider;
//    while(n % 2 == 0)
//    {
//        n /= 2;
//        if(n == 2)
//        {
//            break;
//        }
//    }

//    if(n == 2)
//    {
//        Console.WriteLine("number is a root of 2");
//    }
//    else
//    {
//        Console.WriteLine("number is not a root of 2");
//    }

//}

//PowersOf2(n);

// 9)

//int[] arr = { 2, 5, 3, 234, 145, 56, 34, 67, 89 };

//static void MultiplyOfNums(int[] arr)
//{

//    int multiply = 1;

//    foreach(int nums in arr)
//    {
//        if (nums <= 20)
//        {
//            multiply *= nums;
//        }
//    }
//    Console.WriteLine(multiply);
//}

//MultiplyOfNums(arr);

// 10)

//int[] arr = { 1, 2, 3, 4 };

//static void SquareOfOddNums(int[] arr)
//{
//    int sum = 0;
//    foreach(int num in arr)
//    {
//        if(num % 2 != 0)
//        {
//            sum += num;
//        }
//    }
//    sum *= sum;
//    Console.WriteLine(sum);
//}

//SquareOfOddNums(arr);