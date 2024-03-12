using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accounting2
{
    class Program
    {
    class LinkedListNode
    {
        public LinkedListNode next;
        public String data;
        public int value=0;

        public LinkedListNode(String x)
        {
            data = x;
            next = null;
        }
    }

    class LinkedList
        {
            public LinkedListNode head;

            public void printAllNodes()
            {   int i = 1;
                LinkedListNode current = head;
                while (current != null)
                {
                    Console.Write("({0}){1} ",i,current.data);
                    current = current.next;
                    i += 1;
                }
            }

            public void printAllNodes2()
            {
                
                LinkedListNode current = head;
                int i = 1,all=0; double divide;       //double or float

                if (current == null)
                {
                    Console.Write("\n\n");
                    return;
                }
                while (current != null)
                {
                    all += current.value;
                    current = current.next;
                }
                
                current = head;
             
                while (current != null)
                {   if (all == 0 || current.value == 0) divide = 0;
                    else divide =(double) current.value / all;
                    Console.Write("({0}){1}:  {2}%\n", i, current.data,((divide)*100));
                    current = current.next;
                    i += 1;
                }
                Console.Write("\n");
            }
            public int CalAllCostNodes()
            {
                int all=0;
                LinkedListNode current = head;
                while (current != null)
                {
                    all += current.value;
                    current = current.next;
                    
                }
                 return all;
            }

            public void AddLast(String data)
            {
                if (head == null)
                {
                    head = new LinkedListNode(data);
                    head.next = null;
                }
                else if (head != null)
                {
                    LinkedListNode node = new LinkedListNode(data);
                    LinkedListNode current = head;

                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }
            }
            public int  Cal(int a, int b,int c)
            {
              LinkedListNode current = head;
              for(int i = 1; i < a; i++)
                {
                    current = current.next;
                }
                if (c < b)
                {
                    Console.Write("存款不足\n\n");

                }
                else
                {
                    c -= b;
                    current.value += b;

                }
                return c;

            }
            public Boolean Del(String target)
            {
                LinkedListNode current = head;
                LinkedListNode toDelete =null;
                if (current.data == target && current.next == null)
                {
                    current = toDelete;
                    head = toDelete;
                    return true;
                }
                else if (current.data == target && current.next != null)
                {
                   
                    head= current.next;
                    current = head;
                    return true;
                }
                else if (current.data != target && current.next == null)
                {
                    return false;
                }
                

                while (current.next!= null)
                {
                    if (current.next.data == target && current.next != null)
                    {
                        toDelete = current.next;
                        current.next = toDelete.next;
                        return true;
                    }
                    else if (current.next.data == target && current.next == null){
                        current.next = toDelete;
                        return true;
                    }
                    else
                    current = current.next;
                }
                return false;

            }
             public void FindAndPrint(String target)
            {
                
                for(LinkedListNode current = head;current!=null; )
                {
                    if (current.data == target)
                    {
                        Console.Write("{0}: {1}\n\n", current.data, current.value);
                        return;
                    }
                    else current = current.next;
                }
                Console.Write("此項目不存在\n\n");
            }
        }
        static void Main(string[] args)
        {
            LinkedList mylist = new LinkedList();
            int money = 0,itemLeftNum=0;
            
            
            running: for (; ; )
            {
                Console.Write("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式\n");
                Console.Write("輸入數字選擇功能: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)             //可以輸入非1-8的數字嗎
                {
                    case 1:                 //輸入收入
                        Console.Write("輸入金額: ");
                        Boolean full = true;
                        int earn = 0;
                        full = int.TryParse(Console.ReadLine(), out earn);
                        if (full == false)
                        {
                            Console.Write("請輸入數字\n\n");
                            break;
                        }
                        else if (earn < 0)
                        {
                            Console.Write("收入不可為負數\n\n");
                            break;
                        }
                        money += earn;
                        Console.Write("\n");
                        break;

                    case 2:               //輸入支出
                        if(itemLeftNum==0)
                        {
                            Console.Write("請新增支出項目\n\n");
                            break;
                        }
                        mylist.printAllNodes();
                        Console.Write("\n輸入數字選擇支出項目: ");
                        int cashOpt = int.Parse(Console.ReadLine());
                        if (cashOpt > itemLeftNum||cashOpt<=0)
                        {
                            Console.Write("此數字不再範圍中\n\n");
                            break;
                        }
                     
                        Console.Write("輸入支出金額: ");
                        int cash = int.Parse(Console.ReadLine());
                        money=mylist.Cal(cashOpt, cash,money);
                        Console.Write("\n");
                        break;
                       
                        case 3:                 //新增
                        if (itemLeftNum >= 5)
                        {
                            Console.Write("已無法再新增支出項目\n\n");
                            break;
                        }
                        else
                        {
                            itemLeftNum += 1;
                             Console.Write("輸入項目名稱: ");
                            String name = Console.ReadLine();
                            for(LinkedListNode runLink=mylist.head;runLink!=null; runLink = runLink.next)
                            {
                                if (name == runLink.data)
                                {
                                    Console.Write("支出項目已存在\n\n");
                                    itemLeftNum -= 1;
                                    goto running;
                                }
                            }

                            mylist.AddLast(name);
                            Console.Write("\n");
                            break;
                        }





                    case 4:                       //刪除
                        if (itemLeftNum <= 0)
                        {
                            Console.Write("已無法再刪除支出項目\n\n");
                            break;
                        }
                        
                        Console.Write("輸入項目名稱: ");
                        String name2 = Console.ReadLine();
                        if (mylist.Del(name2) == true)
                        {
                            itemLeftNum -= 1;
                            if (mylist.head == null)
                            {
                                Console.Write("\n\n");
                                break;
                            }
                            mylist.Del(name2);
                        }
                       else
                        {
                            Console.Write("此項目不存在");
                        }
                        Console.Write("\n\n");
                        break;
                        
                    case 5:
                        mylist.printAllNodes2();        //沒支出時會錯
                        break;

                    case 6:
                        Console.Write("目前總支出: {0}\n\n",mylist.CalAllCostNodes());
                        Console.Write("輸入要查詢的項目: ");
                        String wantknow=Console.ReadLine();
                        mylist.FindAndPrint(wantknow);
                        break;
                    case 7:
                        Console.Write("剩餘金額為: {0}\n\n", money);
                        break;

                    case 8:
                        System.Environment.Exit(0);
                        break;
                }
            }




        }


    }
}
