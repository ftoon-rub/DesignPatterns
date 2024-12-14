using DesignPatterns.CreationalDesignPatterns.SingletonPattern.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.SingletonPattern
{
    public class TestSingletonPattern : TestCreationalDesignPatternsTemplate
    {
        protected override void Ex1()
        {
            Console.WriteLine("\n");
        }

        protected override void OopUsedInPattern()
        {
            Console.WriteLine("\n");
        }

        protected override void PatternComponents()
        {
            Console.WriteLine("\n");
        }

        protected override void PatternDescription()
        {
            Console.WriteLine("\n");
        }

        protected override void SolidUsedInPattern()
        {
            Console.WriteLine("\n");
        }

        protected override void TestDesignPatternMain()
        {
            TestSyncSingleton();
            TestAsyncSingletonLock();
            TestAsyncSingletonLazy();
        }

        private void TestSyncSingleton()
        {
            Console.WriteLine("Start testing Sync Singleton:");
            Console.WriteLine("There is a race conditions in multi-threaded environments,the different hash codes initially suggest that separate instances might be created in a multi-threaded environment.");

            Parallel.For(0, 10, _ =>
            {
                // Access the singleton instance
                var instance = Singleton.Instance;
                Console.WriteLine($"Hash Code: {instance.GetHashCode()}");
            });
        }
        private void TestAsyncSingletonLock()
        {
            Console.WriteLine("\nStart Testing Async Singleton Using Lock:");

            Parallel.For(0, 10, _ =>
            {
                // Access the singleton instance
                var instance = SingletonLockThreadSafe.Instance;
                Console.WriteLine($"Hash Code: {instance.GetHashCode()}");
            });
        }
        private void TestAsyncSingletonLazy()
        {
            Console.WriteLine("\nStart Testing Async Singleton Using Lazy:");

            Parallel.For(0, 10, _ =>
            {
                // Access the singleton instance
                var instance = SingletonLazyThreadSafe.Instance;
                Console.WriteLine($"Hash Code: {instance.GetHashCode()}");
            });
        }
    }
}
