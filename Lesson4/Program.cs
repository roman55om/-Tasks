void Task24()
{
    //24. Write a program that calculates the sum of numbers from 1 to N

    Console.WriteLine("Enter a number:");
    int finishNumber = Convert.ToInt32(Console.ReadLine());
    int startNumber = 1;
    int sum = 0;

    while (startNumber <= finishNumber)
    {
        sum = sum + startNumber;
        startNumber++;
    }

    Console.WriteLine("The result is " + sum);
}

void Task26()
{
    //26. Write a program which takes an input number and defines the quantity of digits in it.

    Console.WriteLine("Enter a number");
    int num = Convert.ToInt32(Console.ReadLine());
    num = Math.Abs(num);
    int comparisonNumber = 1;
    int digitsNumber = 0;

    if (num == 0)
    {
        Console.WriteLine($"The number of digits in number {num} = 1");
    }

    else 
    {
        while (num >= comparisonNumber)
        {
            comparisonNumber*=10;
            digitsNumber++;
        }

        Console.WriteLine($"The number of digits in number (-){num} = {digitsNumber}");
    }
}

void Task28()
{
    //28. Write a program which takes an input number (N)
    //and calculates the multiplication from 1 to N.

    Console.WriteLine("Enter a number");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    double multiplication = 1;

    while (count <= num)
    {
        multiplication = multiplication*count;
        count ++;
    }

    Console.WriteLine("The multiplication = " + multiplication);
}

void Task30()
{
    //30. Write a program that returns the array of 8 elements filled with 1s and 0s in a random order

    int size = 10;
    Random random = new Random();
    int[] array = new int[size]; 
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);

    }

    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ExtraTask1()
{
    //ET1. There are 2 arrays. The amount of game scored goals is written to the 1st array.
    // The amount of game missed goals is written to the 2nd array.
    // A) For each game type the result: win, tie game or loss.
    // B) Define the amount of wins and losses for the team.
    // C) Define the amount of points acquired by the team (W - 3, T - 1, L - 0).

    Random random = new Random();
    int size = random.Next(6, 10);
    int[] scoredGoals = new int [size];
    int[] missedGoals = new int [size];

    FillArray(scoredGoals);
    FillArray(missedGoals);

    Console.WriteLine("Scored goals");
    PrintArray(scoredGoals);

    Console.WriteLine("Missed goals");
    PrintArray(missedGoals);

    int wins = 0;
    int losses = 0;
    int tieGames = 0;
    int points = 0;

    for (int i = 0; i < scoredGoals.Length; i++)
    {

        int goal = scoredGoals[i];
        int miss = missedGoals[i];
        Console.Write($"{goal}:{miss}");
        if (goal > miss) 
        {
            Console.WriteLine($" - Win");
            wins++;
            points +=3;
        }
        else if  (goal < miss) 
        {
            Console.WriteLine($" - Loss");
            losses++;
        }     
        else 
        {
            Console.WriteLine($" - Tie game");
            tieGames++;
            points+=1;
        }
    }

    Console.WriteLine($"Number of wins - {wins}, number of losses - {losses}, number of tie games - {tieGames}");
    Console.WriteLine("Number of points = " + points);

}

void FillArray(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Task25()
{
    //25. Write a program that takes 2 numbers (A,B) and rises A to the B degree.

    Console.WriteLine("Enter the A number:");
    int numberA = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the B number:");
    int numberB = Convert.ToInt32(Console.ReadLine());

    int count = 1;
    int result = 1;

    while (count <= numberB)
    {
        result *= numberA;
        count++;
    }

    Console.WriteLine("The result is: " + result);

}

void Task27()
{
    //27. Write a program that takes an input number and
    // calculates the digits sum in it.

    Console.WriteLine("Enter the number:");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (number != 0)
    {
        sum += number%10;
        number /=10;
    }

    Console.WriteLine("The result is: " + sum);

}

void Task29()
{
    //29. Write a program that creates the array of 8 random numbers 
    // and returns the array sorted on modulus.

    int size = 8;
    int[] array = new int [size];

    FillArray(array);

    Console.WriteLine("Unsorted array");
    PrintArray(array);

    int j = 0;

    while (j < size-1)
    {
        int i = 0;
        int posMax = 0;
        int help = 0;

        for (; i<size-j; help = array[posMax],
        array[posMax] = array[size-1-j],
        array[size-1-j] = help)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[posMax]))
            {
                posMax = i;
                i++;
            }  
            else 
            {
                i++;
            }
  
        }
        
        j+=1;
    }

    PrintArray(array);

}
//FillArray();
//Task24();
//Task26();
//Task28();
//Task30();
//ExtraTask1();
//Task25();
//Task27();
Task29();