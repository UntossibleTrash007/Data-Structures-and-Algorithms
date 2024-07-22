/*
Stacks are a last in first out data structure. In the wise words of that one guy on youtube I watch a lot:
imagine it like a stack of video games, you don't want to pull the bottom one out because you risk the rest of the
stack falling apart.
*/
using System.Transactions;
using System.Collections;

public class Stacks<T> : IEnumerable<T>{
    public Node<T>? first{get; protected set;}

    public Stacks(){
        first = null;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

     public IEnumerator<T> GetEnumerator(){
        Node<T>? curr = first;
        while(curr != null){
            yield return curr.Item;
            curr = curr.Next;
        }
     }

//Push() adds an item to the top of the stack
     public void Push(Node<T> node){
        if(first == null){
            first = node;
            return;
        }

        Node<T> current = first;
        while(current.Next != null){
            current = current.Next;
        }
        if(current.Next == null){
            current.Next = node;
        }
     }

     public void Pop(){
        if (first == null)
        {
            Console.WriteLine("List is empty. Nothing to remove.");
            return;
        }
        else if (first.Next == null)
        {
            first = null;
            return;
        }

        Node<T> temp = first;
        while (temp.Next.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = null;
     }

     public T Peek(){
        Node<T> current = first;
        while(current.Next != null){
            current = current.Next;
        }

        return current.Item;
     }

     public bool IsEmpty(){
        if(first == null){
            return true;
        }
        return false;
     }

     public int Size(){
        int Count = 1;
        if(first == null){
            return 0;
        }
        if(first != null){
            Node<T> current = first;
            while(current.Next != null){
            current = current.Next;
            Count++;
        }
        }
        return Count;

        
     }

}