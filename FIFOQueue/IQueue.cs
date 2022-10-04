using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOQueue
{
    public interface IQueue
    {
        public Boolean add(int element);

        public int poll();
    }
}
