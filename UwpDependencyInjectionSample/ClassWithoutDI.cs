namespace UwpDependencyInjectionSample
{
    /// <summary>
    /// Edutcation purposes only.
    /// This is a class that doesn't use any dependency injection.
    /// </summary>
    public class ClassWithoutDI
    {
        public string GetGreeting()
        {
            var prefixMaker = new PrefixMaker();

            var result = $"{prefixMaker.PreFix()} + Vancouver";

            return result;  
        }
    }

    public class PrefixMaker
    {
        public string PreFix() => "Hello";
    }
}
