using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOQueue
{
    public interface IQueue<T>
    {
        public Boolean add(T element);

        public T poll();
    }
}
