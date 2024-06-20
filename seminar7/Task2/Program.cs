// n = 5 -> 1 2 3 4 5

void OneToN(int n)
{
    if (n > 0)
    {
        OneToN(n - 1);
        System.Console.Write(n + " ");
    }

}
OneToN(5);