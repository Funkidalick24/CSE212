using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue an item and then dequeue it.
    // Expected Result: The dequeued item should be the same as the enqueued item.
    // Defect(s) Found: None.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        var dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("Task1", dequeuedItem, "The dequeued item should match the enqueued item.");
    }

    [TestMethod]
    // Scenario: Enqueue multiple Items then deque them by priority the higher the number the higer the priority.
    // Expected Result: Returns task 2 first then task three then task 1
    // Defect(s) Found: Incorrect implementation of the priority code so it was not returning task 2 first
    public void TestPriorityQueue_2()
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

    // Add more test cases as needed below.
}