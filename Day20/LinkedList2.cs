using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20
{
    //T, 제네릭
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }


    //노드를 추가하거나 삭제하는 걸 도와주는 관리 클래스
    //마치 아이템 클래스가 있고, 이를 관리하는 Inventory클래스가 있는 것과 같음
    //시작과 끝이 있어야함. 시작은 Head, 끝은 Tail, Count 노드 갯수
    internal class LinkedList2<T>
    {
        public Node<T> Head { get; private set; }//시작점 노드 하나 기억시킬 헤드
        public int Count { get; private set; } //노드 갯수 보관할 Count

        public LinkedList2()
        {
            Head = null;
            Count = 0;
        }


        //노드 추가
        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (Head == null)//최초 실행 시,Head가 null임
            {
                Head = newNode;//처음 추가한 노드는 머리가 됨
            }
            else
            {
                Node<T> current = Head;//일단 current 노드에 머리담음

                while (current.Next != null) //current 노드 다음 노드가 비지 않는다면
                {
                    current = current.Next;//current 노드는 다음 노드
                }
                current.Next = newNode;
            }
            Count++;
        }

        //node 제거
        //지정된 값을 가진 노드 제거
        //삭제 성공 실패 여부를 bool로 반환
        public bool Remove(T value)
        {
            if (Head == null) //하나도 없으면 그냥 false반환
            {
                return false;
            }

            if (Head.Value.Equals(value))
            {
                Head = Head.Next;//머리가 가리키고 있던 다음 대상이 이제 머리임
                Count--;//원래 카운트 1이엇다면 0으로
                return true; //삭제 성공
            }

            Node<T> current = Head;

            //넥스트가 비지 않았다면 게쏙 다음 노드 이동,
            //넥스트의 값이 내가 찾는 값과 같다 하면 멈춤
            while (current.Next != null && current.Next.Value.Equals(value))
            {
                current = current.Next;


            }
            if (current.Next == null)
            {
                return false; //while 다 돌아도 값이 없으면 false
            }

            current.Next = current.Next.Next;// 다음줄거를 => 다음다음한테 준다 //중간값 사라짐
            Count--;
            return true;
        }

        public Node<T> Find(T value)
        {
            Node<T> current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    return current;
                }
                current = current.Next;

            }
            return null;

        }


    }
}
