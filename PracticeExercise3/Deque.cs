using System;
using System.Collections.Generic;

namespace PracticeExercise3
{
	public class Deque<T> : IDeque<T>
	{
        private LinkedList<T> linkedList;

		public Deque()
		{
            linkedList = new LinkedList<T>();
        }

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Front => IsEmpty ? throw new EmptyQueueException() : linkedList.Last.Value;

        public T Back => IsEmpty ? throw new EmptyQueueException() : linkedList.First.Value;

        public void AddBack(T item)
        {
            linkedList.AddFirst(item);
        }

        public void AddFront(T item)
        {
            linkedList.AddLast(item);
        }

        public T RemoveBack()
        {
            if (IsEmpty)
            {
                throw new EmptyQueueException();
            }

            var rex = linkedList.First.Value;
            linkedList.Remove(rex);

            return rex;
        }

        public T RemoveFront()
        {
            if (IsEmpty)
            {
                throw new EmptyQueueException();
            }

            var wolf = linkedList.Last.Value;
            linkedList.Remove(wolf);

            return wolf;
        }

        public override string ToString()
        {
            string result = "<Back> ";

            var currentNode = linkedList.First;
            while (currentNode != null)
            {
                result += currentNode.Value;
                if (currentNode.Next != null)
                {
                    result += " → ";
                }
                currentNode = currentNode.Next;
            }

            result += " <Front>";

            return result;
        }
    }
}

