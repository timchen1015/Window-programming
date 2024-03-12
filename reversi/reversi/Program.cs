using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace reversi
{
    class Program
    {
    public static int Printbox(char [,]a)
        {   int oo,i=0;
            for ( oo=0 ; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {   
                    Console.Write("{0} ", a[i, j]);
                    if (a[i, j] == 'o')
                    {
                        oo += 1;
                    }
                }
                Console.Write("\n");
            }
            return oo;
        }

        public static bool Puton(char [,]a,char f,char s,int num)
        {
            Char ent;
            
            if (num % 2 == 0) ent = 'o';
            else ent = 'x';
            int ss= s - '0';
            int column;
            column = ((int)f) - 64;
            int c1 = column; int c2=column;
            if (a[ss, column] != '-')
            {
                Console.Write("此位置已有棋子! 按任意鍵繼續遊戲");
                Console.ReadKey();
               
                return false;
            }
            else a[ss, column] = ent;
            for(int i = 8; i > ss; i--)           //向下
            {
                if (a[i, column] == ent)
                {
                    for (; i >ss; i--)
                    {
                        if (a[i, column] != ent&&a[i,column]!='-')
                            a[i, column] = ent;
                    }
                    goto up;
                }
            }
            up: for (int i = 1; i <ss; i++)           //向上
            {
             
                if (a[i, column] == ent)
                {
                    for (; i < ss; i++)
                    {
                        if (a[i, column] != ent && a[i, column] != '-')
                            a[i, column] = ent;
                    }
                    goto left;
                }
            }

            left: for (int i = 1; i <column; i++)       //向左
            {
                if (a[ss, i] == ent)
                {
                    for (; i < column; i++)
                    {
                        if (a[ss, i] != ent && a[ss, i] != '-')
                            a[ss, i] = ent;
                    }
                    goto right;
                }
            }
            right: for (int i = 8; i > column; i--)       //向右
            {
                if (a[ss, i] == ent)
                {
                    for (; i > column; i--)
                    {
                        if (a[ss, i] != ent && a[ss, i] != '-')
                            a[ss, i] = ent;
                    }
                        break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Char[,] box = new char[9, 9] { {' ', 'A','B','C','D','E','F','G','H' }, {'1','-','-','-','-','-','-','-','-'},
                {'2','-','-','-','-','-','-','-','-'}, {'3','-','-','-','-','-','-','-','-'},{'4','-','-','-','-','-','-','-','-'},
                {'5','-','-','-','-','-','-','-','-'}, {'6','-','-','-','-','-','-','-','-'},{'7','-','-','-','-','-','-','-','-'},
                {'8','-','-','-','-','-','-','-','-'}};
            Char result;
            
            for (int k=0;k<64 ;k++ )
            {

                Printbox(box);
                if (k % 2 == 0) Console.Write("輪到玩家o ");
                else Console.Write("輪到玩家x ");
                Console.WriteLine("請輸入要下的位子:");
                String pos = Console.ReadLine(); 
                Char pos1 = pos[0]; Char pos2 = pos[1];
                
                if (Puton(box, pos1, pos2, k) == false)
                {
                    k -= 1;
                }
             
                Console.Clear();
             }


            if (Printbox(box) > 32)
            {
                result = 'o';
            }
            else result = 'x';
            Console.Write("遊戲結束 玩家{0}獲勝!",result);
            Console.ReadKey();
        }
    }
}
