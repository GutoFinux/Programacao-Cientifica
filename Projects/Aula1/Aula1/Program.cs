using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Queue
{
    private int ini;                                                          //posição do inicio da fila
    private int end;                                                          //posição do final da fila (próximo a ser preenchido)
    private int size;                                                         //tamanho da vila
    private int amount;                                                       //quantidade de itens na fila
    private int[] q;                                                          //fila propriamente dita (ainda indefinida)

    public Queue(int i)
    {
        ini = 0;
        end = 0;
        size = i;
        amount = 0;
        q = new int[i];                                                       //instancia o tamanho da fila
    }

    public bool isEmpty()
    {
        if (amount == 0)                                                       //dverifica se não tem nada, ou seja, vazia
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isFull()
    {
        if (amount == size)                                                     //verifica se a quantidade de itens é o tamanho da fila, ou seja, cheia
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
        if (isFull())
        {
            Console.WriteLine("Fila cheia.");                                  //se tiver cheia é impossível adicionar outro item
        }
        else
        {
            q[end] = i;                                                        //se não estiver cheia adiciona o novo item
            end++;                                                             //avança o fim da fila
            amount++;                                                          //atualiza a quantidade
            if (end == size)                                                   //ajusta caso o final esteja em uma posição antes do inicial no vetir fila
            {
                end = 0;
            }
            Console.WriteLine(i + " adicionado com sucesso.");                 //Avisa ao usuário que deu tudo certo
        }
    }

    public void remove()
    {
        if (isEmpty())
        {
            ini = 0;                                                           //se estiver vazia reposiciona o inicio (apenas a título de organização)
            end = 0;                                                           //se estiver vazia reposiciona o fim (apenas a título de organização)
            Console.WriteLine("Fila Vazia.");                                  //avisa ao usuário
        }
        else
        {
            Console.WriteLine(q[ini] + " removido com sucesso.");              //mostra o item removido
            ini++;                                                             //atualiza a posição inicial
            amount--;                                                          //atualiza a quantidade
            if (ini == size)                                                   //ajusta caso a posição inicial passe da última para a primeira posição do vetor
            {
                ini = 0;
            }
        }

    }

    public void show()
    {
        if (isEmpty())
        {
            Console.WriteLine("Fila vazia.");                                 //Avisa se estiver vazia
        }
        else
        {
            Console.Write("Fila atual: ");                                    //linhas 96 a 99 exibem o primeiro da fila
            int i = ini;
            Console.Write(q[i] + " ");
            i++;
            if (i >= size) i = 0;                                             //ajusta caso i tenha exibido a última posição do vetor e agora precisa passar para a primeira
            while (i != end)                                                  //exibe os demais itens (foi necessário fazer assim para não envolver o ini num loop e nem precisar ajustá-lo pra -1)
            {
                Console.Write(q[i] + " ");
                i++;
                if (i >= size) i = 0;
            }
            Console.Write("\n");
        }
    }

    public void clear()
    {
        ini = 0;
        end = 0;
        amount = 0;
        Console.WriteLine("Fila esvaziada com sucesso!");                     //nada é apagado, apenas as referências são resetadas
    }
}

//------------------------------------------------------------------------------------------------------------------------------

class Stack
{
    private int size;                                                         //tamanho da pilha
    private int top;                                                          //posição do topo
    private int amount;                                                       //quantidade de itens na pilha
    private int[] s;                                                          //pilha propriamente dita

    public Stack(int i)
    {
        size = i;
        top = 0;
        amount = 0;
        s = new int[i];                                                       //instancia as posições do tamanho da pilha
    }

    public bool isEmpty()
    {
        if (amount == 0)                                                      //verifica se não tem nada (vazia)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isFull()
    {
        if (amount == size)                                                   //verifica se tem a mesma quantidade de itens do tamanho da pilha (cheia)
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
        if (isFull())                                                         //verifica se está cheia
        {
            Console.WriteLine("Pilha cheia!");                                //avisa ao usuário
        }
        else
        {
            s[top] = i;                                                       //armazena o item na posição indicada pelo topo
            top++;                                                            //atualiza o topo
            amount++;                                                         //atualiza a quantidade
            Console.WriteLine(i + " adicionado com sucesso!");                //avisa ao usuário
        }
    }

    public void remove()
    {
        int n;
        if (isEmpty())                                                        //verifica se está vazia
        {
            Console.WriteLine("Pilha vazia!");                                //avisa ao usuário
        }
        else
        {
            n = s[top - 1];                                                   //revome o topo (a variável "top" marca o próximo a ser preenchido)
            Console.WriteLine(s[top - 1] + " removido com sucesso!");         //avisa ao usuario
            top--;                                                            //atualiza o topo
            amount--;                                                         //atualiza a quantidade
        }
    }

    public void show()
    {
        if (isEmpty())                                                        //verifica se está vazia
        {
            Console.Write("Pilha vazia!");                                    //avisa ao usuário
        }
        else
        {
            Console.Write("Pilha atual: ");
            for (int i = 0; i < top; i++)
            {
                Console.Write(s[i] + " ");                                    //exipe a pilha em sequencia item por item
            }
        }

        Console.Write("\n");
    }

    public void clear()                                                       //Reposiciona o índice, atualiza a quantidade e avisa ao usuário
    {
        top = 0;
        amount = 0;
        Console.WriteLine("Pilha esvaziada com sucesso!");
    }

    public void peek()
    {
        if (isEmpty())                                                        //verifica se está vazia
        {
            Console.WriteLine("Pilha vazia!");                                //avisa ao usuário
        }
        else
        {
            Console.WriteLine("O topo é: " + s[top - 1]);                     //mostra o topo (a variável "top" marca o próximo a ser preenchido, por isso -1)
        }
    }
}

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue(3);
            fila.insert(4);
            fila.insert(5);
            fila.insert(7);
            fila.insert(2);
            fila.show();
            fila.remove();
            fila.insert(1);
            fila.show();
            fila.remove();
            fila.show();
            fila.remove();
            fila.show();
            fila.remove();
            fila.show();


            Stack pilha = new Stack(3);
            pilha.insert(2);
            pilha.insert(4);
            pilha.insert(7);
            pilha.insert(9);
            pilha.show();
            pilha.remove();
            pilha.show();
            pilha.insert(15);
            pilha.show();
            pilha.remove();
            pilha.remove();
            pilha.remove();
            pilha.remove();

            Console.ReadKey();
        }
    }
}
