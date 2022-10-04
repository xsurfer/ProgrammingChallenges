using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FIFOQueue
{
    public class Queue : IQueue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;
        private int count;

        public Queue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }

        public bool add(int element)
        {
            if (count == max)
            {                
                throw new InvalidOperationException();                
            }
            else
            {
                rear = (rear + 1) % max;
                ele[rear] = element;

                count++;
            }
            return true;
        }

        public int poll()
        {
            if (count == 0)
            {                
                throw new InvalidOperationException();
            }
            else
            {
                int temp = ele[front];
                Console.WriteLine("deleted element is: " + ele[front]);

                front = (front + 1) % max;

                count--;
                return temp;
            }
        }

    }
}
