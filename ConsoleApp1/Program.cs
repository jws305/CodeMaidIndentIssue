namespace Test
{
    internal class Program
    {
        private static Lazy<int> Item { get; } = new Lazy<int>(() =>
        {
            return 1;
        });
    }
}