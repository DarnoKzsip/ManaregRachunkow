namespace ManagerRachunkow.ModelsDTO;

public class ResponseAfterAutDTO:ResponseDTO
{
    public bool IsAdmin { get; set; }
    public string IdUser { get; set; }
    public string Mail {  get; set; }
}
