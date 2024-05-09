namespace MemoApi.Erorrs
{
    public class ApiResponse
    {
        public ApiResponse( int statusCode, string message = null)
        {
            
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad Request , You have made",
                401 => "Authorized you are not",
                404 => "Response found it was not",
                500 => "Server Error occured",
                _ => null
            };
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
