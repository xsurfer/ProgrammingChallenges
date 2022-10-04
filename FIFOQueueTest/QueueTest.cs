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
            Queue queue = new Queue(3);

            Assert.True(queue.add(1));
            Assert.True(queue.add(2));
            Assert.True(queue.add(3));          
        }

        [Fact]
        public void add_addToFullQueue_throwsException()
        {
            Queue queue = new Queue(3);

            Assert.True(queue.add(1));
            Assert.True(queue.add(2));
            Assert.True(queue.add(3));
            Assert.Throws<InvalidOperationException>(() => queue.add(4));
        }

        [Fact]
        public void add_addAndPollEntireQueue()
        {
            Queue queue = new Queue(3);

            Assert.True(queue.add(1));
            Assert.True(queue.add(2));
            Assert.True(queue.add(3));
            Assert.Equal(1, queue.poll());
            Assert.Equal(2, queue.poll());
            Assert.Equal(3, queue.poll());
            Assert.True(queue.add(4));
            Assert.True(queue.add(5));
            Assert.True(queue.add(6));
            Assert.Equal(4, queue.poll());
            Assert.Equal(5, queue.poll());
            Assert.Equal(6, queue.poll());            
        }
    }
}
