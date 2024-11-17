namespace testapi;

public class ApiResponse<T>
{
    public int Code { get; set; } = 1;
    public string CodeMsg { get; set; }
    public string RequestId { get; set; }
    public T Data { get; set; }

    public long DataCount { get; set; } = 1;
}