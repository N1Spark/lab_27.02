using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_27._02
{
    class Program
    {
        #region Зад 1
        static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                return a;
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                return b;
            else
                return c;
        }
        #endregion

        #region Зад 2
        static T Min<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) < 0 && a.CompareTo(c) < 0)
                return a;
            else if (b.CompareTo(a) < 0 && b.CompareTo(c) < 0)
                return b;
            else
                return c;
        }
        #endregion

        #region Зад 4
        public class Stack<T>
        {
            private List<T> list = new List<T>();
            public int Count { get { return list.Count; } }
            public void Push(T elem) => list.Add(elem);
            public T Pop()
            {
                T result = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return result;
            }
            public T Peek() { return list[list.Count - 1]; }
        }
        #endregion

        #region Зад 5
        public class Queue<T>
        {
            private List<T> list = new List<T>();
            public int count => list.Count;
            public void Enqueue(T elem) => list.Add(elem);
            public T Dequeue()
            {
                T elem = list[0];
                list.RemoveAt(0);
                return elem;
            }
            public T Peek() { return list[0]; }
        }
        #endregion
        static void Main(string[] args)
        {
            int task1 = Max(1, 2, 4);
            Console.WriteLine(task1);
            int task2 = Min(1, 2, 4);
            Console.WriteLine(task2);
            Stack<int> task4 = new Stack<int>();
            task4.Push(1);
            task4.Push(4);
            Console.WriteLine(task4.Count);
            Console.WriteLine(task4.Peek());
            task4.Pop();
            Console.WriteLine(task4.Count);
            Queue<int> task5 = new Queue<int>();
            task5.Enqueue(1);
            task5.Enqueue(4);
            Console.WriteLine(task5.Peek());
            Console.WriteLine(task5.Dequeue());
            Console.WriteLine(task5.Dequeue());
            Console.WriteLine(task5.count);
        }
    }
}
