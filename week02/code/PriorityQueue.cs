public class PriorityQueue
{
    private List<(string item, int priority)> _queue;

    public PriorityQueue()
    {
        _queue = new List<(string item, int priority)>();
    }

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        _queue.Add((value, priority));
    }

    public string Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        int highestPriorityIndex = 0;
        for (int i = 1; i < _queue.Count; i++)
        {
            if (_queue[i].priority > _queue[highestPriorityIndex].priority)
            {
                highestPriorityIndex = i;
            }
        }

        var item = _queue[highestPriorityIndex].item;
        _queue.RemoveAt(highestPriorityIndex);
        return item;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}