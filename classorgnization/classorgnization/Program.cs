using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classorgnization
{  

    class Program
    { public static void printchart(String[,] a)
    {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0}", a[i, j]);
                }Console.Write("\n");

            }
            Console.Write("\n");
    }

       public static Boolean JaggedAryIndexOf(String[,] ary, String target)
        {
         for (int i = 1; i < 9; i++)
            {
                for(int j = 1; j < 8;j++)
                {
                    if (String.Equals(ary[i, j] , String.Format("{0,-6 }", target))==true)
                        return true;
                }
              }
            return false;
        }
        public static int Del(String [,] ary,String target)
        {
            int count=0;
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    if (String.Equals(ary[i, j], String.Format("{0,-6 }",target))==true)
                    {
                        ary[i,j]= String.Format("{0,-6}", " ");
                        count+=1;
                    }
                        
                }
            }
            if (count == 0)
            {
                Console.Write("課程 {0} 不在課表中\n\n", target);
                return count;
            }
            else Console.Write("成功刪除課程: {0}\n\n",target);
            return count;
        }
        static void Main(string[] args)
        {   String [,]classchart = new String[9,8];
            for(int i = 0; i < 9; i++)
            {
                for(int j=0; j < 8; j++)
                {
                    classchart[i,j]= String.Format("{0,-6}", " ");
                }
            }
          
            
            classchart[0,1]= String.Format("{0,-6 }", "Sun");
            classchart[0,2]= String.Format("{0,-6 }", "Mon");
            classchart[0,3]= String.Format("{0,-6 }", "Tue");
            classchart[0,4]= String.Format("{0,-6 }", "Wen");
            classchart[0,5]= String.Format("{0,-6 }", "Thu");
            classchart[0,6]= String.Format("{0,-6 }", "Fri");
            classchart[0,7]= String.Format("{0,-6 }", "Sat");
            for(int i = 1; i <= 8; i++)
            {
                classchart[i,0] = String.Format("{0,-6}",i.ToString());
            }

            int point = 0;
            running: for (; ; )
            {
                //printchart(classchart);
                Console.Write("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式\n");
                Console.Write("請輸入數字選擇功能:");
                int opt;
                opt=int.Parse(Console.ReadLine());
                //printchart(classchart);
                switch(opt){
                    case 1:
                        { 
                        String text = Console.ReadLine();
                        String text1 = text.Substring(0, 5);
                        int daybugg = (int)Char.GetNumericValue(text[6]);
                        int day;
                            if (daybugg == 7) day = 0;
                            else day = daybugg; 
                        int classstart=(int)Char.GetNumericValue(text[8]);
                        int classend =(int)Char.GetNumericValue(text[10]);
                            point += (classend - classstart) ;
                            point += 1;
                          
                            for (int i = classstart; i <= classend; i++)
                            {   
                                if (classchart[i + 1, day + 1] != String.Format("{0,-6}", " "))
                                {
                                    
                                    Console.Write("課程衝堂!\n\n");
                                    goto running;

                                }
                            }
                            if (JaggedAryIndexOf(classchart, text1) == true)
                                {
                                    Console.Write("課程重複!\n\n");
                                    goto running;
                                }
                            else for (int i = classstart; i <= classend; i++)
                                    {
                                    
                                    classchart[i,day+1 ] = String.Format("{0,-6 }", text1); ;

                                    } Console.Write("成功加入課程!\n\n");
                                break;
                            }
                    case 2:
                        Console.Write("請輸入要刪除的課程代號:");
                        String textdel = Console.ReadLine();
                        textdel = textdel.Substring(0, 5);
                        
                        point -= Del(classchart, textdel);
                        
                        break;
                    case 3:
                        printchart(classchart);
                        break;
                    case 4:
                        Console.Write("{0}\n\n", point);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                }



            }

        }
    }
}
