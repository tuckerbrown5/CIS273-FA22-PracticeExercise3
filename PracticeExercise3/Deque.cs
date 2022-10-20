using System;
using System.Collections.Generic;

namespace PracticeExercise3
{
	public class Deque<T> : IDeque<T>
	{
        private LinkedList<T> linkedList;

		public Deque()
		{
		}

        public bool IsEmpty => throw new NotImplementedException();

        public int Length => throw new NotImplementedException();

        public T Front => throw new NotImplementedException();

        public T Back => throw new NotImplementedException();

        public void AddBack(T item)
        {
            throw new NotImplementedException();
        }

        public void AddFront(T item)
        {
            throw new NotImplementedException();
        }

        public T RemoveBack()
        {
            throw new NotImplementedException();
        }

        public T RemoveFront()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string result = "<Back> ";

            var currentNode = linkedList.Last;
            while (currentNode != null)
            {
                result += currentNode.Value;
                if (currentNode.Previous != null)
                {
                    result += " → ";
                }
                currentNode = currentNode.Previous;
            }

            result += " <Front>";

            return result;
        }
    }
}

