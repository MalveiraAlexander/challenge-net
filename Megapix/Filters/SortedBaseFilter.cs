using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapix.Filters
{
    public class SortedBaseFilter
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string? Order { get; set; }
    }
}
