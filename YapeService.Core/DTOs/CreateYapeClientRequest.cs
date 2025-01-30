namespace YapeService.Core.DTOs;

public class CreateYapeClientRequest
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string CellPhoneNumber { get; set; }
    public string DocumentType { get; set; }
    public string DocumentNumber { get; set; }
    public string ReasonOfUse { get; set; }
}
