using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var maxPrice = Library.Books.Max(b => b.Price);
            var maxPriceBook = Library.Books.Where(b => b.Price == maxPrice);
            foreach (var book in maxPriceBook) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_3() {
            var category = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(b => b.Key);
            foreach (var book in category) {
                Console.WriteLine("{0}年",book.Key);
                Console.WriteLine("{0}冊",Library.Books.Count(b => b.PublishedYear == book.Key));
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books.Join(Library.Categories, book => book.CategoryId, category => category.Id, (book, category) => new { PublishedYear = book.PublishedYear, Price = book.Price, Title = book.Title, Category = category.Name }).OrderBy(b => b.PublishedYear).OrderByDescending(b => b.PublishedYear).ThenByDescending(b => b.Price);
            foreach (var book in books) {
                Console.WriteLine($"{book.PublishedYear}年 {book.Price}円 {book.Title} ({book.Category})");
            }
        }

        private static void Exercise1_5() {
            var books = Library.Books.Join(Library.Categories, book => book.CategoryId, category => category.Id, (book, category) => new { PublishedYear = book.PublishedYear, Category = category.Name }).Where(b=>b.PublishedYear == 2016).Distinct();
            foreach (var book in books) {
                Console.WriteLine(book.Category);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Books.Join(Library.Categories, book => book.CategoryId, category => category.Id, (book, category) => new { Title = book.Title, Category = category.Name }).GroupBy(b => b.Category).OrderBy(b => b.Key);
            foreach (var g in groups) {
                Console.WriteLine($"#{g.Key}");
                foreach (var book in g) {
                    Console.WriteLine($"   {book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var groups = Library.Books.Join(Library.Categories, book => book.CategoryId, category => category.Id, (book, category) => new { PublishedYear = book.PublishedYear, Title = book.Title, Category = category.Name }).Where(b=>b.Category.Equals("Development")).GroupBy(b => b.PublishedYear).OrderBy(b => b.Key);
            foreach (var g in groups) {
                Console.WriteLine($"#{g.Key}");
                foreach (var book in g) {
                    Console.WriteLine($"   {book.Title}");
                }
                    
            }
        }

        private static void Exercise1_8() {
            var groups = Library.Categories.GroupJoin(Library.Books, c => c.Id, b => b.CategoryId, (c, books) => new { Category = c.Name ,Count = books.Count()});
            foreach (var item in groups) {
                if (item.Count >= 4) {
                    Console.WriteLine(item.Category);
                }
            }
        }
    }
}
