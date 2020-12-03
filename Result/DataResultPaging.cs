using System.Text.Json;
using System.Text.Json.Serialization;
namespace NetCoreFilter.Result
{
    public class DataResultPaging<T>
    {
         public DataResultPaging(T data, int currentPage, int totalPages, int pageSize,int totalCount)
        {
            resultData=data;
            CurrentPage=currentPage;
            TotalPages=totalPages;
            PageSize=pageSize;
            TotalCount=totalCount;
        }
        [JsonInclude]
        public T resultData;
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
    }
}