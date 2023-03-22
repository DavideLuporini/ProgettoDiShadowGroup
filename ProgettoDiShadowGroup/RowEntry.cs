using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoDiShadowGroup
{
    internal class RowEntry
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string brandName { get; set; }
        public string categoryName { get; set; }
        public int modelYear { get; set; }
        public decimal listPrice { get; set; }
    }
}
