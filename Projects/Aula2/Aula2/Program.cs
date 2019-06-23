using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Node
{
    public Node previous = null;                                         //Armazena o nó anterior
    public int value;                                                    //Armazena valor do nó atual
    public Node next = null;                                             //Armazena o próximo nó (usado somente em filas)

    public Node(int i)                                                   //Se for iniciado só com o valor ele seta só o valor
    {
        value = i;
    }

    public Node(int i, Node n)                                           //Se for iniciado com valor e um nó ele seta esse nó como anterior
    {
        value = i;
        previous = n;
    }

}

public class Stack
{
    Node top = null;                                                     //Trabalhar apenas com o topo é suficiente, pois o nó topo armazena o valor e um outro né anterior a ele
    
    public void insert(int i)
    {
        if(isEmpty())
        {
            top = new Node(i);                                           //Se for o primeiro nó, não seta os o anterior
        }
        else
        {
            top = new Node(i,top);                                       //Se não for o primeiro nó ele manda o último pra ser setado como anterior ao novo nó
        }
        Console.WriteLine(i + " inserido com sucesso!");
    }

    public void remove()
    {
        if(isEmpty())
        {
            Console.WriteLine("Pilha vazia!");                           //Se a pilha estiver vazia avisa ao usuário
        }
        else
        {
            Console.WriteLine(top.value + " removido com sucesso");
            if (top.previous == null)
            {
                top = null;                                              //Se não tiver anterior então só há um nó na pilha, sendo assim a piljha fica vazia
            }
            else
            {
                top = top.previous;                                      //Se a pilha não estiver vazia então o anterior vira o novo topo e o topo anterior deixa de ser usado
            }
        }
    }

    public bool isEmpty()
    {
        if(top == null)                                                  //Se o top for NULL significa que a pilha está vazia
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
            Console.WriteLine("Pilha vazia!");                           //Informa pilha vazia
        }
        else
        {
            Console.WriteLine("Topo:" + top.value);                      //Informa o topo sem desempilhar
        }
    }

    public void clear()
    {
        top = null;                                                      //anular o topo descarta toda a pilha
        Console.WriteLine("Pilha esvaziada com sucesso!");
    }

}

//-------------------------------------------------------------------------------------------------------------------

public class Queue
{
    Node first = null;                                                   //armazena o primeiro nó (que possui o próximo e assim sucessivamente)
    Node last = null;                                                    //armazena o último nó (que possui o anterior e assim sucessivamente)

    public bool isEmpty()
    {
        if (first == null)                                               //se não houver um primeiro nó, então está vazia
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
            first = new Node(i);                                         //se a fila estiver vazia o novo nó é salvo no primeiro e também no último
            last = first;
            //first.next = last;                                         //O primeiro armazena o último e o último armazena o primeiro, necessário pra ir relacionando a ortem da fila (removido pois não usei essa lógica)
            last.previous = first;
        }
        else
        {
            Node n = new Node(i, last);                                  //Um novo nó é instanciado tendo o último nó atual como o anterior dele
            last.next = n;                                               //Esse novo nó é posicionado como o próximo nó depois do último
            last.previous = last;                                        //O atual último nó passa a ser o penúltimo
            last = n;                                                    //o novo nó é posicionado como o último
        }
        Console.WriteLine(i + " inserido com sucesso!");
    }

    public void remove()
    {
        if (isEmpty())
        {
            Console.WriteLine("Fila vazia!");                            //se estiver vazia apenas avisa ao usuário
        }
        else
        {
            Console.WriteLine(first.value + " removido com sucesso");
            if (first.next == null)                                      //se não houver next significa que só tem um nó, então a pilha é exvaziada
            {
                last = null;
                first = null;
            }
            else
            {
                first = first.next;                                      //faz o segundo nó ser o primeiro e assim o primeiro sai da fila
            }
        }
    }

    public void clear()                                                  //anula todo mundo, assim a fila esvazia de novo
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
            fila.insert(6);
            fila.remove();
            fila.clear();
            fila.remove();
            fila.remove();
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
