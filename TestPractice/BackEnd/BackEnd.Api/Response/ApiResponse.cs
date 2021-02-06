namespace BackEnd.Api.Response
{
    public class ApiResponse<TResult>
    {
        public bool IsSuccess { get; set; } 
        public TResult Result { get; set; }
    }
}
