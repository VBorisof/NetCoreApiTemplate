using System.Collections.Generic;

namespace NetCoreApiTemplate.ViewModels
{
    public class PaginationViewModel<T>
    {
        public int TotalPages { get; set; }
        public IEnumerable<T> Page { get; set; }
    }
}
