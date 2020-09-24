using System;
using System.Collections.Generic;
using System.Text;

namespace Q
{
    class Queue
    {
        private int[] Que;
        private int capacity = 1;
        public Queue()
            {
            Que = new int[capacity];
            }
        public void enQue(int newObject)
        {
            if (Que.Length == capacity)
            {
                increaseLength();
            }
            int[] tempArray = Que;
            Que = new int[capacity];
            for (int i = 1; i < tempArray.Length; i++)
            {
                Que[i] = tempArray[i - 1];
            }
            Que[0] = newObject;

        }
        public void deQue()
        {

            if (capacity < 1)
            {
                throw new IndexOutOfRangeException("shits broke");
            }
                decreaseLength();

            int[] tempArray = Que;
            Que = new int[capacity];
            
            for (int i = 0; i < Que.Length; i++)
            {
                Que[i] = tempArray[i];
            }
        }
        public void printQue()
        {
            Console.WriteLine(Que.Length);
        }
        private void increaseLength()
        {
            capacity++;
        }
        private void decreaseLength()
        {
            capacity--;
        }
    }
}
