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

void Task17()
{
    //17. Write a program which takes X and Y coordinates
    // and defines to which quarter they belong. X,Y!= 0

    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.WriteLine($"Point with coordinates ({x}, {y})");

    if (x > 0 && y > 0) Console.WriteLine($"The point with coordinates ({x}, {y}) belongs to the 1st quarter");
    else if (x < 0 && y > 0) Console.WriteLine($"The point with coordinates ({x}, {y}) belongs to the 2nd quarter");
    else if (x < 0 && y < 0) Console.WriteLine($"The point with coordinates ({x}, {y}) belongs to the 3rd quarter");
    else if (x > 0 && y < 0) Console.WriteLine($"The point with coordinates ({x}, {y}) belongs to the 4th quarter");
    else Console.WriteLine("Wrong coordinates");

}

void Task18()
{
    //18. Write a program which defines the possible coordinates range basing on the quarter number entered

    Console.WriteLine("Enter the quarter number");
    int quarterNumber = Convert.ToInt32(Console.ReadLine());

    if (quarterNumber == 1) 
    {
        Console.WriteLine("X from 1 to 999, Y from 1 to 999");
    }    
    else if (quarterNumber == 2) 
    {
        Console.WriteLine("X from -1 to -999, Y from 1 to 999");
    }
    else if (quarterNumber == 3) 
    {
        Console.WriteLine("X from -1 to -999, Y from -1 to -999");
    }
    else if (quarterNumber == 4) 
    {
        Console.WriteLine("X from 1 to 999, Y from -1 to -999");
    }

}

void Task21()
{
    //21. Write a program which takes 2 dots as input and finds the lenght between them
    Console.WriteLine("Enter the coordinates of the 1st dot");
    int firstDotX = Convert.ToInt32(Console.ReadLine());
    int firstDotY = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the coordinates of the 2nd dot");
    int secondDotX = Convert.ToInt32(Console.ReadLine());
    int secondDotY = Convert.ToInt32(Console.ReadLine());

    double length = Math.Sqrt(Math.Pow((secondDotX - firstDotX), 2) + Math.Pow((secondDotY - firstDotY), 2));

    Console.WriteLine("The length between two dots is " + length);


}

void Task22()
{
    //22. Write a program which takes a number N and returns the square roots of the numbers from 1 to N.
    /*int number = 1;
    Console.WriteLine("Enter a number");
    int finishNumber = Convert.ToInt32(Console.ReadLine());
    int ArrayA[];
    int ArrayB[];
    while (number <= finishNumber)
    {
        ArrayA[] = ArrayA[] + number;
        number ++;
    }
    Console.WriteLine ("The sequence is " + ArrayA[]);
    ArrayB[] = Math.Pow(ArrayA[], 2);
    Console.WriteLine ("Square root of the sequence is " + ArrayB[]);*/
}

void Task19()
{
    //19. Write a program that defines if the 5th digit number is a palindrome or not.

    Console.WriteLine("Enter a 5-digit number");
    int number = Convert.ToInt32(Console.ReadLine());

    int fifthDigit = number%10;
    int fourthDigit = (number%100) / 10;
    int thirdDigit = (number%1000) / 100;
    int secondDigit = (number%10000) / 1000;
    int firstDigit = number/10000;

    int numberTwo = (fifthDigit*10000 + fourthDigit*1000 + thirdDigit*100 + secondDigit*10 + firstDigit);

    if (numberTwo == number) 
    {
        Console.WriteLine ("The number is a palindrome");
    }    
    else 
    {
        Console.WriteLine ("The number is not a palindrome");
    }
}

void Task21A()
{
   //21A. Write a program which takes 2 dots as input and finds the lenght between them in 3D.
   Console.WriteLine("Enter the coordinates of the 1st dot");
    int firstDotX = Convert.ToInt32(Console.ReadLine());
    int firstDotY = Convert.ToInt32(Console.ReadLine());
    int firstDotZ = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the coordinates of the 2nd dot");
    int secondDotX = Convert.ToInt32(Console.ReadLine());
    int secondDotY = Convert.ToInt32(Console.ReadLine());
    int secondDotZ = Convert.ToInt32(Console.ReadLine());

    double length = Math.Sqrt(Math.Pow(secondDotX - firstDotX, 2) + Math.Pow(secondDotY - firstDotY, 2) + Math.Pow(secondDotZ - firstDotZ, 2));

    Console.WriteLine("The length between two dots is " + Math.Round(length, 2));

}

void Task23()
{
    int number = 1;
    
    Console.WriteLine("Enter a number");
    int finishNumber = Convert.ToInt32(Console.ReadLine());

    while (number < finishNumber)
    {
        Console.Write(Math.Pow(number, 3) + ", ");
        number++;
    }

    Console.Write(Math.Pow(number, 3));

}
//Task9();
//Task11();
//Task12();
//Task14();
//Task16();
//ExtraTask1();
//Task13();
//Task15();
//for (int i = 1; i < 10; i++)
//Task17();
//Task18();
//Task21();
//Task22();
//Task19();
//Task21A();
Task23();