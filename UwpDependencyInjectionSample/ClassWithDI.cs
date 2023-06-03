using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpDependencyInjectionSample
{
    public class ClassWithDI
    {
        private readonly IPrefixMaker _prefixMaker;

        public ClassWithDI(IPrefixMaker prefixMaker)
        {
            _prefixMaker = prefixMaker;
        }

        public string GetGreeting()
        {
            var result = $"{_prefixMaker.PreFix()} + Vancouver";

            return result;
        }
    }

    public interface IPrefixMaker
    {
        string PreFix();
    }

    public class EnglishPrefixMaker : IPrefixMaker
    {
        public string PreFix() => "Hello";
    }

    public class FrenchPrefixMaker : IPrefixMaker
    {
        public string PreFix() => "Bonjour";
    }
}
