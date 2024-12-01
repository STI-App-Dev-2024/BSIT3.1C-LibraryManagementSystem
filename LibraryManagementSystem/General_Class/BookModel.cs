using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.General_Class
{
    internal class BookModel
    {
        public int CopyID { get; set; }
        public string AccessionNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
    }
}
