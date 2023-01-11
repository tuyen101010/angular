namespace I3T.CRM.Common
{
    public class AppResponseDto
    {
        public bool Status { set; get; }
        public string Message { set; get; }

        public AppResponseDto(bool _Status = true, string _Message = "Success")
        {
            Status = _Status;
            Message = _Message;
        }
    }

    public class ApiResponseDto
    {
        public bool Status { set; get; }
        public string Message { set; get; }
        public object Data { set; get; }

        public ApiResponseDto(bool _Status = true, string _Message = "Success", object _Data = null)
        {
            Status = _Status;
            Message = _Message;
            Data = _Data;
        }
    }

    public class AppImportResponseDto
    {
        public bool? Status { set; get; }
        public int? Total { set; get; }
        public int? Success { set; get; }
        public int? Fail { set; get; }
        public string Message { set; get; }

        public AppImportResponseDto(bool _Status, string _Message)
        {
            Status = _Status;
            Message = _Message;
        }
    }
}