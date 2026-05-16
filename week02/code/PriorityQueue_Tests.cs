using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a prioritQqueue with the following value and priority: Task A (2), Task B (5), Task C (10). 
    //           Verify the highest priority (Task C) is chosen first.
    // Expected Result: Dequeue() should return Task C.
    // Defect(s) Found: 1."TestPriorityQueue_1" failed. Error: "Assert.AreEqual" failed. Expected: <Task C>. Actual: <Task B>.
    //                  2. Possible bug (Check in PriorityQueue.Dequeue): Loop boundary was "Count -1", skipping the last element.
    //                  3. Defect 1 fixed: Loop now includes the last element (index < _queue.Count)

    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task A", 2);
        priorityQueue.Enqueue("Task B", 5);
        priorityQueue.Enqueue("Task C", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Task C", result);

        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Create a prioritQueue with the following value and priority: Task A (2), Task B (5), Task C (10). 
    //           Verify after the highest priority (Task C) is removed, and the next Dequeue() returns the second priority (Task B).
    // Expected Result: First Dequeu returns "Task C", second Dequeue returns "Task B".
    // Defect(s) Found: 1."TestPriorityQueue_2" failed. Error: "Assert.AreEqual" failed. Expected: <Task B>. Actual: <Task C>.
    //                  2. Possible bug (Check in PriorityQueue.Dequeue): The second result is not as expected. So, the highest priority (Task C) is not removed.
    //                  3. Defect 2 fixed: Remove the highest priority element after finding it.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task A", 2);
        priorityQueue.Enqueue("Task B", 5);
        priorityQueue.Enqueue("Task C", 10);

        var firstResult = priorityQueue.Dequeue();
        var secondResult = priorityQueue.Dequeue();

        Assert.AreEqual("Task C", firstResult);
        Assert.AreEqual("Task B", secondResult);

        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Create a priorityQueue with the following value and priority: Task A (2), Task B (5), Task C (10), Task D (10). 
    //           Verify if there are multiple values with the same high priority, then the first one is removed first.
    // Expected Result: First Dequeue returns "Task C", second Dequeue returns "Task D".
    // Defect(s) Found: 1."TestPriorityQueue_3" failed. Error: "Assert.AreEqual" failed. Expected: <Task C>. Actual: <Task D>.
    //                  2. Possible bug (Check in PriorityQueue.Dequeue): Loop makes the last one with the same priority the highest priority.
    //                  3. Defect 3 fixed: Now loop through the values, making the first one with the same priority the highest priority.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task A", 2);
        priorityQueue.Enqueue("Task B", 5);
        priorityQueue.Enqueue("Task C", 10);
        priorityQueue.Enqueue("Task D", 10);

        var firstResult = priorityQueue.Dequeue();
        var secondResult = priorityQueue.Dequeue();

        Assert.AreEqual("Task C", firstResult);
        Assert.AreEqual("Task D", secondResult);

        // Assert.Fail("Implement the test case and then remove this.");
    }
}