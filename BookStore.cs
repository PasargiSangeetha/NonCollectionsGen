using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    internal class BookStore
    {
        public static void Books() {
            int Id=0;
            string Book = "";
            Hashtable Books = new();
            
                for (int i = 0; i < 5; i++)
            {
                Id=Convert.ToInt32(Console.ReadLine());
                Book= Console.ReadLine();
                Books.Add(Id, Book);
            }

            Console.WriteLine("Display Book details");
            foreach (var k in Books.Keys)
                Console.WriteLine("BookId:{0} BookName:{1}", k, Books[k]);          
        }
    }
}
