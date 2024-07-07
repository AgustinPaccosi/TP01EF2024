using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01EF2024.Windows.Helpers
{
    public static class FormHelpers
    {
        public static int CalcularPaginas(int records, int pageSize)
        {
            if (records < pageSize) { return 1; }
            if (records % pageSize == 0) { return records / pageSize; }
            return records / pageSize + 1;
        }
    }
}
