/*
Queues are a Fifo data structure, literally how lines work in real life, the person who got there first gets through the fastest.
Priority queue will come later.
*/
using System.Collections;
public class Queue<T> : IEnumerable<T>{

    public Node<T>? head {get; protected set;}
    public Queue(){
        head = null;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<T> GetEnumerator(){
        Node<T> current = head;
        while(current != null){
            yield return current.Item;
            current = current.Next;
        }
    }

    public void Enqueue(Node<T> node){
        if(head == null){
            head = node;
            return;
        }

        Node<T> current = head;
        while(current.Next != null){
            current = current.Next;
        }

        current.Next = node;
    }

    public void Dequeue(){
        if(head == null){
            throw new InvalidOperationException("The list is empty lmaoo");
        } else if(head.Next == null){
            head = null;
            return;
        }
        Node<T> current = head;
        head = current.Next;

    }

    public T Peek(){

        return head.Item;
     }

     public bool IsEmpty(){
        if(head == null){
            return true;
        }
        return false;
     }

     public int Size(){
        int Count = 1;
        if(head == null){
            return 0;
        }
        if(head != null){
            Node<T> current = head;
            while(current.Next != null){
            current = current.Next;
            Count++;
        }
        }
        return Count;

        
     }

}