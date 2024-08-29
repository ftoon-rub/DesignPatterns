using System;
using DesignPatterns.BehavioralDesignPatterns.IteratorPattern.Solution;

namespace DesignPatterns.BehavioralDesignPatterns.IteratorPattern
{
    internal class TestIterator : ITestState
    {
        public void Test()
        {
            BrowseHistory history = new();
            history.pushListUrls("a");
            history.pushListUrls("b");
            history.pushListUrls("c");

            IIterator<string> iterator = history.createIteratorListUrls();
            Console.WriteLine("createIteratorListUrls");
            while (iterator.hasNext())
            {
                var url = iterator.current();
                Console.WriteLine(url);
                iterator.next();
            }

            iterator = history.createIteratorArrayUrls();
            Console.WriteLine("createIteratorArrayUrls");
            while (iterator.hasNext())
            {
                var url = iterator.current();
                Console.WriteLine(url);
                iterator.next();
            }
        }
    }
}
