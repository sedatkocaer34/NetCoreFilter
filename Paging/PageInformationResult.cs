using System.Linq;
using System;
using System.Collections.Generic;
namespace NetCoreFilter.Paging
{

    public class PageInformationResult<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
    }
}