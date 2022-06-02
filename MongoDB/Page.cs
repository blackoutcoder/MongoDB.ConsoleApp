using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    internal class Page
    {
        public int PageId { get; set; }
        public string ContentProperties { get; set; }

        public Page(int pageId, string contentProperties)
        {
            PageId = pageId;
            ContentProperties = contentProperties;
        }
    }
}
