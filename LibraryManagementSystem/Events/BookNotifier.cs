using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Events
{
    internal class BookNotifier
    {
        public static event Action _BookAdded;

        public static void _NewBookAdded()
        {
            _BookAdded?.Invoke();
        }
    }
}
