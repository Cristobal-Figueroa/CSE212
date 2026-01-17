using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Encolar un único elemento y luego desencolarlo.
    // Expected Result: Se debe devolver ese mismo elemento.
    // Defect(s) Found: 
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Encolar varios elementos con prioridades distintas.
    // Expected Result: El elemento con mayor prioridad (Task2) debe salir primero.
    // Defect(s) Found: 
    public void TestPriorityQueue_HighestPriorityWins()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 5);
        priorityQueue.Enqueue("Task3", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Task2", result);
    }

    [TestMethod]
    // Scenario: Encolar dos elementos con la misma prioridad máxima.
    // Expected Result: Debe regresar el que llegó primero (FirstHigh).
    // Defect(s) Found: 
    public void TestPriorityQueue_TieKeepsFifoOrder()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("FirstHigh", 10);
        priorityQueue.Enqueue("SecondHigh", 10);
        priorityQueue.Enqueue("Lower", 1);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("FirstHigh", result);
    }

    [TestMethod]
    // Scenario: Desencolar de una cola vacía.
    // Expected Result: Debe lanzar InvalidOperationException con el mensaje requerido.
    // Defect(s) Found: 
    public void TestPriorityQueue_EmptyThrows()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Should have thrown an exception.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    [TestMethod]
    // Scenario: Encolar múltiples elementos y desencolar consecutivamente para verificar que se eliminen.
    // Expected Result: Después de remover la prioridad más alta, la siguiente llamada debe devolver la segunda prioridad más alta.
    // Defect(s) Found: 
    public void TestPriorityQueue_RemovesFromQueue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Mid", 3);
        priorityQueue.Enqueue("Low", 1);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();

        Assert.AreEqual("High", first);
        Assert.AreEqual("Mid", second);
    }
}