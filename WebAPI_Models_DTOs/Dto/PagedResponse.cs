namespace WebAPI_Models_DTOs.Dto
{
    public class PagedResponse<T>
    {

        public PagedResponse()
        {     
        }

        public List<T> data { get; set; } 
        public int pageNumber { get; set; }
        public int pageSize { get; set; }
        public int totalCount { get; set; }

        public int totalPages { get; set; }


        public PagedResponse(List<T> data, int pageNumber, int pageSize, int totalCount)
        {
            this.data = data;
            this.pageNumber = pageNumber;
            this.pageSize = pageSize;
            this.totalCount = totalCount;
            this.totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
        }

    }
}
