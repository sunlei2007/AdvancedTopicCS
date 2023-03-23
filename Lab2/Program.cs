LinkedList<int> list = new LinkedList<int>();
list.AddNode(1);
list.AddNode(2);
list.AddNode(3);

list.ShowListValue();

public class LinkedList<T>
{
    public Node<T> HeadNode { get; set; }

    public void AddNode(T arg)
    {
        Node<T> newNode = new Node<T>(arg);
        newNode.Next = HeadNode;
        HeadNode = newNode;
    }
    public void ShowListValue()
    {
        Node<T> currentNode = HeadNode;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode.Data);
            currentNode = currentNode.Next;
        }
    }

}

public class Node<T>
{
    public T Data { get;  set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
     
}


