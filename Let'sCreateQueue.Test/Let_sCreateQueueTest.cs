using Let_sCreateQueueGenerics;
using NPOI.SS.Formula.Functions;

namespace Let_sCreateQueue.Test
{
    public class Let_sCreateQueueTest
    {
        public readonly MyQueue<int> queueList;

        public Let_sCreateQueueTest()
        {
            queueList = new MyQueue<int>();
        }
        
        
        [Theory]
        [InlineData(10, 20, 2)]
        public void Enqueue_AddsElementInTheCustomQueueList(int firstElement, int secondElement, int result)
        {
            queueList.Enqueue(firstElement);
            queueList.Enqueue(secondElement);
          
            Assert.Equal(result, queueList.Count());
        }


        [Theory]
        [InlineData(10, 20, 1)]
        public void Dequeue_DeleteElementInTheCustomQueueList_CheckingExceptionsIfTheQueueIsEmpty(int firstElement, int secondElement, int result)
        {
            Assert.Throws<InvalidOperationException>(() => queueList.Dequeue()); 

            queueList.Enqueue(firstElement);
            queueList.Enqueue(secondElement);
            queueList.Dequeue();

            Assert.Equal(result, queueList.Count());
        }

        [Theory]
        [InlineData(10, 20)]
        public void Peek_PeekFirstElementInTheCustomQueueList_CheckingExceptionsIfTheQueueIsEmpty(int firstElement, int secondElement)
        {
            Assert.Throws<InvalidOperationException>(() => queueList.Peek());

            queueList.Enqueue(firstElement);
            queueList.Enqueue(secondElement);

            Assert.Equal(firstElement, queueList.Peek());
            
        }
    }
}