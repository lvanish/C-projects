using System;
class Node
{
    public int value;
    public Node next;
    public Node(int val)
    {
        value = val;
        next = null;
    }
}
class MyStack
{
    private Node head;
    public void push(int val)
    {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
    }
    public int pop()
    {
        if (head == null) return -1;
        int val = head.value;
        head = head.next;
        return val;
    }
    public void peek()
    {
        if(head == null) Console.WriteLine("no element");
        
        Console.WriteLine(head.value);
    }
    public bool isEmpty(){
        return (head == null);
    }
    public void print(){
        Node newNode = head;
        // newNode.next = head;
        while(newNode != null){
            Console.Write(newNode.value + " ");
            newNode = newNode.next;
        }
    }
}

public class Test
{
    public static void Main()
    {
        MyStack stk = new MyStack();
        stk.push(10);
        stk.push(5);
        stk.push(20);
        // stk.print(); 
        stk.pop();
        stk.peek();
        
    }
}