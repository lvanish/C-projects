using System;

MyMap map = new MyMap();

map.insert(1, "one");
map.insert(2, "two");
map.insert(3, "three");

map.print();

map.delete(1);
map.print();

public class MyMap
{

    private class Node
    {
        public int key;
        public string value;
        public Node next;
        public Node(int key, string value)
        {
            this.key = key;
            this.value = value;
            next = null;
        }
    }
    int bucketsize = 10;
    private Node[] Buckets;

    public MyMap()
    {
        Buckets = new Node[bucketsize];
    }

    public int hashindex(int key)
    {
        return Math.Abs(key) % bucketsize;
    }

    public void insert(int key, string value)
    {
        int idx = hashindex(key);
        Node head = Buckets[idx];

        Node tmp = head;
        while (tmp != null)
        {
            if (tmp.key == key)
            {
                tmp.value = value;
                return;
            }
            tmp = tmp.next;
        }

        Node node = new Node(key, value);
        node.next = head;
        Buckets[idx] = node;
    }

    ///---------------------------------------------------------------------------------
    public void delete(int key)
    {
        int idx = hashindex(key);
        Node head = Buckets[idx];
        Node prev = null;
        Node curr = head;

        while (curr != null)
        {
            if (curr.key == key)
            {
                if (prev == null)
                {
                    Buckets[idx] = curr.next;
                }
                else
                {
                    prev.next = curr.next;
                }
                return;
            }
            prev = curr;
            curr = curr.next;
        }
    }

    public bool containsKey(int key)
    {
        int idx = hashindex(key);
        Node head = Buckets[idx];
        //Node tmp = head;
        while (head != null)
        {
            if (head.key == key)
            {
                return true;
            }
            head = head.next;
        }
        return false;
    }

    public bool containsValue(string val)
    {
        foreach (Node head in Buckets)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == val)
                {
                    return true;
                }
                node = node.next;
            }

        }
        return false;
    }

    public void print()
    {
        for (int i = 0; i < bucketsize; i++)
        {
            Node node = Buckets[i];
            while (node != null)
            {
                Console.WriteLine(node.key + " " + node.value);
                node = node.next;
            }
        }
    }
}