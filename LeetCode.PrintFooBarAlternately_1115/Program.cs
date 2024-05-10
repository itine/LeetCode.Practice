static void Main(string[] args)
{
    Console.WriteLine("Hello world");
}

public class FooBar
{
    private readonly int n;
    private readonly Semaphore _semaphore1;
    private readonly Semaphore _semaphore2;

    public FooBar(int n)
    {
        this.n = n;
        _semaphore1 = new Semaphore(0, 1);
        _semaphore2 = new Semaphore(0, 1);
    }

    public void Foo(Action printFoo)
    {
        for (int i = 0; i < n; i++)
        {
            if (i != 0)
                _semaphore2.WaitOne();
            // printFoo() outputs "foo". Do not change or remove this line.
            printFoo();
            _semaphore1.Release();
        }
    }

    public void Bar(Action printBar)
    {
        for (int i = 0; i < n; i++)
        {
            _semaphore1.WaitOne();
            // printBar() outputs "bar". Do not change or remove this line.
            printBar();
            _semaphore2.Release();
        }
    }
}