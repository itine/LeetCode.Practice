public class Foo
{
    private readonly Semaphore _secondSemaphore = new (0,1);
    private readonly Semaphore _thirdSemaphore = new (0,1);

    public Foo() {
        
    }

    public void First(Action printFirst)
    {
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        _secondSemaphore.Release();
    }

    public void Second(Action printSecond)
    {
        _secondSemaphore.WaitOne();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        _thirdSemaphore.Release();
    }

    public void Third(Action printThird)
    {
        _thirdSemaphore.WaitOne();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}