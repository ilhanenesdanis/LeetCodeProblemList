static bool IsPalindrome(int x)
{
    int originalNumber = x;
    int reversedNumber = 0;
    while (x > 0)
    {
        int remainder = x % 10;
        reversedNumber = reversedNumber * 10 + remainder;
        x /= 10;
    }
    return originalNumber == reversedNumber;
}



var asd = IsPalindrome(12321);

Console.ReadLine();