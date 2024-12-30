using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Day22___수업
{
    public class Node<T>
    {
        public T Value {  get; set; }   
        public List<Node<T>> Neighbors { get; private set; }
        public Node (T value)
        {
            Value = value;
            Neighbors = new List<Node<T>>();

        }
    }

    public class SimleGraph<T>
    {
        //노드 추가x
        List<Node<T>> _nodes = new List<Node<T>>();//노드 관리하는 리스트 할당

        //노드 추가하는 기능
        public Node<T> AddNode(T value)
        {
            Node<T> node = new Node<T>(value);
            _nodes.Add(node);
            return node;
        }

        //단방향 간선 추가
        public void AddEdge(Node<T> from, Node<T> to)
        {
            //출발점 노드 가진 리스트에, 목적지 노드 추가
            from.Neighbors.Add(to);
        }

        //양방향 간선 추가

        public void AddUndirectedEdge(Node<T> from, Node<T> to)
        {
            from.Neighbors.Add(to);
            to.Neighbors.Add(from);
        }

        public void PrintGraph()
        {
            foreach (Node<T> ele in _nodes)
            {
                Console.Write(ele.Value + "=> ");
                foreach(var a in ele.Neighbors)
                {
                    Console.Write(a.Value + " ");
                }
                Console.WriteLine();

            }
        }

        //큐를 사용하여 탐색
        //시작 노드를 큐에 담고 탐색 시작
        public void BFS(Node<T> start, Node<T> target)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();    
            List<Node<T>> visited = new List<Node<T>>(); //방문기록용

            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();

                if (visited.Contains(current))
                {
                    continue;
                }
                Console.WriteLine($"{current.Value}");
                visited.Add(current);

                if(current.Equals(target))
                {
                    Console.WriteLine($"목적지 {target.Value} 도달");
                    return;
                }

                foreach(var ele in current.Neighbors)
                {
                    if (!visited.Contains(ele))
                    {
                        queue.Enqueue(ele); 
                    }
                }
            }
            Console.WriteLine("경로 탐색 실패");




        }

        public void DFS(Node<T> start, Node<T> target)
        {
            Stack<Node<T>> queue = new Stack<Node<T>>();
            List<Node<T>> visited = new List<Node<T>>(); //방문기록용

            queue.Push(start);
            while (queue.Count > 0)
            {
                Node<T> current = queue.Pop();

                if (visited.Contains(current))
                {
                    continue;
                }
                Console.WriteLine($"{current.Value}");
                visited.Add(current);

                if (current.Equals(target))
                {
                    Console.WriteLine($"목적지 {target.Value} 도달");
                    return;
                }

                foreach (var ele in current.Neighbors)
                {
                    if (!visited.Contains(ele))
                    {
                        queue.Push(ele);
                    }
                }
            }
            Console.WriteLine("경로 탐색 실패");




        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {
            //원소들이 순차적으로 혹은 선형으로 앞뒤로 연결된 구조
            //선형구조

            //linkedlist  .next
            //배열, list
            //스택
            //큐

            //BFS => B first search //넓이 stack비슷
            //DFS => Depth first search//깊이 큐비슷


            SimleGraph<string> graph = new SimleGraph<string>();

            var nodeA =  graph.AddNode("천호");
            var nodeB = graph.AddNode("강동");
            var nodeC = graph.AddNode("광나루");
            var nodeD = graph.AddNode("올림픽공원");

            graph.AddEdge(nodeA, nodeB);
            graph.AddEdge(nodeA, nodeC);
            graph.AddEdge(nodeA, nodeD);
            graph.AddEdge(nodeB, nodeD);




            graph.PrintGraph();












        }
    }
}
