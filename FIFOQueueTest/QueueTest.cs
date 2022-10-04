using FIFOQueue;
using System;
using System.Collections.Immutable;
using Xunit;

namespace FIFOQueueTest
{
    public class QueueTest
    {
        [Fact]
        public void add_addToEmptyQueue_returnTrue()
        {
            Assert.False(true);
        }

        [Fact]
        public void add_addToFullQueue_throwsException()
        {
            Assert.False(true);
        }
    }
}
