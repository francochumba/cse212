using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three people with different priorities.
    // Expected Result: The person with the highest priority is returned.
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", result);
        
    }

    [TestMethod]
    // Scenario: Enqueue 3 persons where two have the same priority
    // Expected Result: the person with the highest priority and first added to the queue
    // Defect(s) Found: none
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 5);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", result);
        
    }

    [TestMethod]
    // Scenario: Enqueue four people with the high priorities mixed
    // Expected Result: The person with the highest priority is returned respecting the FIFO order.
    // Defect(s) Found: none
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Sam", 3);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 5);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", result);
        
    }
    
    [TestMethod]
    // Scenario: three persons with the same priority
    // Expected Result: the first person added to the queue
    // Defect(s) Found: The result value is returning "Tim" instead of "Bob"
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 1);
        priorityQueue.Enqueue("Sue", 1);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", result);

    }

    [TestMethod]
    // Scenario: three persons with the same priority and two dequeued
    // Expected Result: The first two people are dequeued in FIFO order
    // Defect(s) Found: repetition of the same person dequeued for not being removed.
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 1);
        priorityQueue.Enqueue("Sue", 1);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", result);

        result = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", result);

    }

    [TestMethod]
    // Scenario: four persons with various priority all dequeued
    // Expected Result: all persons dequeued according to its priority and order
    // Defect(s) Found: none
    public void TestPriorityQueue_6()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("Sam", 5);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", result);

        result = priorityQueue.Dequeue();
        Assert.AreEqual("Sam", result);

        result = priorityQueue.Dequeue();
        Assert.AreEqual("Sue", result);

        result = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", result);

    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: dequeue an empty list and throw an exception.
    // Defect(s) Found: none
    public void TestPriorityQueue_7()
    {
        var priorityQueue = new PriorityQueue();

        var result = Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
        
        Assert.AreEqual("The queue is empty.", result.Message);

    }
}