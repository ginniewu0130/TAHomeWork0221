using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork0221_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //奇偶判斷Linq
            //input: 8,7,9,3,11,6,2,18
            Console.WriteLine("請輸入一串以逗號分隔(,)的整數數字字串");
            //輸入
            var input=Console.ReadLine();
            //分開
            var intputWords=input.Split(',');
            //轉成int
            var numbers=intputWords.Select((x)=>int.Parse(x));
            //排列OrderBy()由小到大排列
            var sortNumbers = numbers.OrderBy((x) => x);
            //奇數判斷
            var oddResult=sortNumbers.Where((x)=>x%2!=0);
            //偶數判斷
            var evenResult=sortNumbers.Where((x)=>x%2==0);
            //輸出結果             
            Console.WriteLine($"奇數：{string.Join(",", oddResult)}");
            Console.WriteLine($"偶數：{string.Join(",", evenResult)}");

            Console.ReadLine();
        }
    }
}
