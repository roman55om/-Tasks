void Task9()
{
    //9. Write a program that takes a random number from massive [10,99]
    // and shows the maximum digit of the number

    Random rand = new Random();
    int number = rand.Next(10, 100);
    Console.WriteLine(number);
    //84 8 4
    int digitOnes = number%10;
    int digitTens = number/10;
    int max = digitTens;
    
    if (digitOnes > digitTens) max = digitOnes;

    Console.WriteLine("Наибольшая цифра числа: " + max);

}


void Task11()
{
    //11. Write a program that returns the random
    // 3 digits number and deletes the 2nd digit.

    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine(number);
    
    int digitHundreds = number/100;
    int digitOnes = number%10;
    int digitTens = number/10;
    
    Console.WriteLine("The new number is: " + digitHundreds + digitOnes);
}


void Task12()
{
    //12. Write a program that takes two numbers and decides if the 2nd is divisible to the 1st
    // If it is not divisible, print out the remnant

    Random rand = new Random();
    int FirstNumber = rand.Next(1, 10);
    int SecondNumber = rand.Next(1, 10);
    int result = SecondNumber % FirstNumber;

    if (result != 0)
    {
        Console.WriteLine("The remnant is: " + result);
    }

    else
    {
        Console.WriteLine("The 2nd number is divisible to the 1st number");
    }
}

void Task14()
{
    //14. Write a program that takes an input number and checks
    // if it is divisible to both 7 and 23.

    Console.WriteLine ("Enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number%23 == 0)
    {
        if (number%7 == 0)
        {
            Console.WriteLine("The number is divisible to both 7 and 23");  
        }
        else
        { 
        Console.WriteLine("The number is not divisible to both 7 and 23");
        }
    }    
    else
    { 
        Console.WriteLine("The number is not divisible to both 7 and 23");
    }
}

void Task16()
{
    //16. Write a program which takes 2 input number and checks
    // if the one of them is a square root of another one
    Console.WriteLine("Enter the first number");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (number2>number1 && number2 == number1 * number1)
    {
        Console.WriteLine("The one number is a square root of another one");
    }
    
    else if (number1>number2 && number1 == number2 * number2)
    {
        Console.WriteLine("The one number is a square root of another one");
    }

    else
    {
        Console.WriteLine("The one number is not a square root of another one");
    }
}

void ExtraTask1()
{
    //1.Write a program that defines if a triangle is isosceles or not
    Console.WriteLine("Enter the A side length");
    int sideA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the B side length");
    int sideB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the C side length");
    int sideC = Convert.ToInt32(Console.ReadLine());

    bool triangle = sideA == sideB && sideA + sideB > sideC || sideB == sideC && sideB + sideC > sideA || sideA == sideC && sideC + sideA > sideB;

    if(triangle)
    {
        Console.WriteLine("The triangle is isosceles");
    }
    else if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideC + sideA <= sideB)
    {
        Console.WriteLine("This is not a triangle");
    }
    else
    {
        Console.WriteLine("The triangle is not isosceles");
    }
}

void Task13()
{
    //13. Write a program which defines the 3rd digit of the number using division
    //or reports that it does not exist.

    Console.WriteLine("Enter a number");
    int number = Convert.ToInt32(Console.ReadLine());
    int numberLength = 1;
    int check = 10;
    int extraNumber;
    int thirdDigit;
    while (number/check > 0)
    {
        check = check * 10;
        numberLength ++;
    }
    if (numberLength > 2)
    {
        int degree = numberLength - 3;
        extraNumber = (number / Convert.ToInt32(Math.Pow(10, degree)))%100;
        thirdDigit = extraNumber%10;
        Console.WriteLine("The 3rd digit is " + thirdDigit);
    }
    else
    {
        Console.WriteLine("The third digit does not exist ");
    }
   
}

void Task15()
{
    //15. Write a program that takes a day of the week number and defines if
    //it is a weekend or not.
    Console.WriteLine("Enter a number from 1 to 7");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number <= 7)
    {
        if (number == 6 || number == 7)
        {
            Console.WriteLine("It's a weekend whoo-hoo!");
        }
        else
        {
            Console.WriteLine("Go do some work dude!");
        }
    }
    else
    {
        Console.WriteLine("Enter a correct number!");
    }


}
//Task9();
//Task11();
//Task12();
//Task14();
//Task16();
//ExtraTask1();
//Task13();
//Task15();
