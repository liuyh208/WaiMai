using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiMai.Common
{
    public class PagedResult<T>
    {
        public PagedResult(IEnumerable<T> lst, int total)
        {
            this.rows = lst;
            this.total = total;
        }
        public IEnumerable<T> rows { get; private set; }

        public int total { get; private set; }
    }
}
