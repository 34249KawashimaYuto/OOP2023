using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4, };
            //Console.WriteLine(numbers.Average());

            var books = Books.GetBooks();
            //500円以上の本のタイトルをすべて出力
            //foreach (var item in books.Where(x => x.Title.Contains("物語")).OrderByDescending(x => x.Price)) {
            //Console.WriteLine("{0}：{1}円",item.Title,item.Price);
            //}
            //Console.WriteLine(books.Max(x => x.Price));

            var question1 = books.Where(x => x.Title.Contains("物語")).Average(x => x.Pages);
            Console.WriteLine("「物語」をタイトルに含む本の平均ページ数：{0}", question1);

            //question2
            Console.WriteLine();
            foreach (var item in books.OrderByDescending(x => x.Title.Length)) {
                Console.WriteLine("{0}：{1}円", item.Title, item.Price);
            }
        }
    }
}
