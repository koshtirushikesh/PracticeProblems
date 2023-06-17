namespace WebApplicationSample
{
    internal class LinkedList
    {
        Node headNode;
        Node tailNode;

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if (headNode == null)
            {
                this.headNode = this.tailNode = newNode;
            }
            else
            {
                newNode.next = headNode;
                headNode = newNode;
            }
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (headNode == null)
            {
                this.headNode = this.tailNode = newNode;
            }
            else
            {
                tailNode.next = newNode;
                tailNode = newNode;
            }
        }
    }

    public class Node
    {
        public int Data;
        public Node next;

        public Node(int data)
        {
            Data = data;
        }
    }
}
