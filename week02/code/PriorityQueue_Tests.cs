using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue an item and then dequeue it.
    // Expected Result: The dequeued item should be the same as the enqueued item.
    // Defect(s) Found: None.
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        var dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("Task1", dequeuedItem, "The dequeued item should match the enqueued item.");
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities and dequeue them
    // Expected Result: Items should be dequeued in order of highest to lowest priority
    // Defect(s) Found: Items not being dequeued in correct priority order
    public void TestPriorityQueue_MultiplePriorities()
    { 
         var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("Task1", 1);
    priorityQueue.Enqueue("Task2", 3);
    priorityQueue.Enqueue("Task3", 2);

    var firstDequeuedItem = priorityQueue.Dequeue();
    var secondDequeuedItem = priorityQueue.Dequeue();
    var thirdDequeuedItem = priorityQueue.Dequeue();

    Assert.AreEqual("Task2", firstDequeuedItem, "The first dequeued item should be the one with the highest priority.");
    Assert.AreEqual("Task3", secondDequeuedItem, "The second dequeued item should be the one with the next highest priority.");
    Assert.AreEqual("Task1", thirdDequeuedItem, "The third dequeued item should be the one with the lowest priority.");


    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority and dequeue them
    // Expected Result: Items with same priority should be dequeued in FIFO order
    // Defect(s) Found: Items with same priority not following FIFO order
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Third", 2);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();
        var third = priorityQueue.Dequeue();

        Assert.AreEqual("First", first, "Items with same priority should follow FIFO order");
        Assert.AreEqual("Second", second, "Items with same priority should follow FIFO order");
        Assert.AreEqual("Third", third, "Items with same priority should follow FIFO order");
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue
    // Expected Result: Should throw InvalidOperationException
    // Defect(s) Found: No exception thrown when queue is empty
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Mix of different priorities with some same priorities
    // Expected Result: Should dequeue highest priority first, then follow FIFO for same priorities
    // Defect(s) Found: Not handling combination of priority ordering and FIFO correctly
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low1", 1);
        priorityQueue.Enqueue("High1", 3);
        priorityQueue.Enqueue("Mid1", 2);
        priorityQueue.Enqueue("High2", 3);
        priorityQueue.Enqueue("Mid2", 2);

        Assert.AreEqual("High1", priorityQueue.Dequeue(), "Should get first high priority item");
        Assert.AreEqual("High2", priorityQueue.Dequeue(), "Should get second high priority item");
        Assert.AreEqual("Mid1", priorityQueue.Dequeue(), "Should get first medium priority item");
        Assert.AreEqual("Mid2", priorityQueue.Dequeue(), "Should get second medium priority item");
        Assert.AreEqual("Low1", priorityQueue.Dequeue(), "Should get low priority item last");
    }
}