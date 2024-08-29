namespace DesignPatterns.BehavioralDesignPatterns.IteratorPattern.Main
{

    /// <summary>
    /// ListConcreteIterator<T> class follows the Open/Closed Principle (SOLID) by being open for extension through the use of generics.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListConcreteIterator<T> : IIterator<T>
    {
        /// <summary>
        /// Encapsulation (OOP): _list is private fields.
        /// </summary>
        private readonly List<T> _list;
        /// <summary>
        /// Encapsulation (OOP): _index is private fields.
        /// </summary>
        private int _index;

        /// <summary>
        /// Constructor Dependency Injection: Dependency Injection Principle (SOLID), _list is injected via the constructor.
        /// </summary>
        /// <param name="list"></param>
        public ListConcreteIterator(List<T> list)
        {
            _list = list;
            Reset();
        }
        /// <summary>
        /// Property for Current element follows Encapsulation (OOP).
        /// </summary>
        public T Current => _list[_index];


        /// <summary>
        /// Single Responsibility Principle (SOLID): Checks if there is a next element.
        /// </summary>
        /// <returns></returns>
        public bool HasNext()
        {
            return _index < _list.Count - 1;
        }
        /// <summary>
        /// Single Responsibility Principle (SOLID): Moves to the next element.
        /// </summary>
        /// <returns></returns>
        public T Next()
        {
            if (HasNext())
            {
                return _list[++_index];
            }
            // Liskov Substitution Principle (SOLID): Returning default value if no next element.
            return default;
        }

        /// <summary>
        /// Single Responsibility Principle (SOLID): Resets the iterator.
        /// </summary>
        public void Reset()
        {
            _index = -1;
        }
    }
}
