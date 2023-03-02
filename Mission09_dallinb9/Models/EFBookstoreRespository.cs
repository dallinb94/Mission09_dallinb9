using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_dallinb9.Models
{
    public class EFBookstoreRespository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRespository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
