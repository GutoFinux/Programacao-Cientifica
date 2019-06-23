using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Node
{
    public Node previous = null;
    public int value;
    public Node next = null;

    public Node(int i)
    {
        value = i;
    }

    public Node(int i, Node n)
    {
        value = i;
        previous = n;
    }

}

public class Stack
{
    Node top = null;
    
    public void insert(int i)
    {
        if(isEmpty())
        {
            top = new Node(i);
        }
        else
        {
            top = new Node(i,top);
        }
        Console.WriteLine(i + " inserido com sucesso!");
    }

    public void remove()
    {
        if(isEmpty())
        {
            Console.WriteLine("Pilha vazia!");
        }
        else
        {
            Console.WriteLine(top.value + " removido com sucesso");
            if (top.previous == null)
            {
                top = null;
            }
            else
            {
                top = top.previous;
            }
        }
    }

    public bool isEmpty()
    {
        if(top == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void peek()
    {
        if (isEmpty())
        {
            Console.WriteLine("Pilha vazia!");
        }
        else
        {
            Console.WriteLine("Topo:" + top.value);
        }
    }

    public void clear()
    {
        top = null;
        Console.WriteLine("Pilha esvaziada com sucesso!");
    }

}

//-------------------------------------------------------------------------------------------------------------------

public class Queue
{
    Node first = null;
    Node last = null;

    public bool isEmpty()
    {
        if (first == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void insert(int i)
    {
        if (isEmpty())
        {
            first = new Node(i);
            last = first;
            first.next = last;
            last.previous = first;
        }
        else
        {
            Node n = new Node(i, last);
            last.next = n;
            last.previous = last;
            last = n;
        }
        Console.WriteLine(i + " inserido com sucesso!");
    }

    public void remove()
    {
        if (isEmpty())
        {
            Console.WriteLine("Fila vazia!");
        }
        else
        {
            Console.WriteLine(first.value + " removido com sucesso");
            if (first.next == null)
            {
                last = null;
                first = null;
            }
            else
            {
                first = first.next;
            }
        }
    }

    public void clear()
    {
        last = null;
        first = null;
        Console.WriteLine("Fila esvaziada com sucesso!");
    }
}

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue();
            fila.insert(2);
            fila.insert(3);
            fila.insert(64);
            fila.insert(18);
            fila.remove();
            fila.insert(30);
            fila.remove();
            fila.clear();
            fila.remove();

            /*
            Stack pilha = new Stack();
            pilha.insert(3);
            pilha.insert(4);
            pilha.insert(34);
            pilha.insert(52);
            pilha.insert(15);
            pilha.insert(9);
            pilha.remove();
            pilha.remove();
            pilha.remove();
            pilha.peek();
            pilha.remove();
            pilha.clear();
            pilha.remove();
            */
            Console.ReadKey();
        }
    }
}
