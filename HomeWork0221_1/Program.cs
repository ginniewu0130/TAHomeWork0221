using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork0221_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //序列倒置Linq
            //input:12,18,13,23,32 output:32,23,13,18,12

            Console.WriteLine("輸入一串以逗號分隔(,)的字串:");
            //使用者輸入
            var input=Console.ReadLine();
            //分開
            var inputWords=input.Split(',');
            //倒置
            var reverseWords=inputWords.Reverse();
            //結果輸出
            var result=string.Join(",", reverseWords);
            Console.WriteLine(result);

            Console.ReadLine();



        }
    }
}
