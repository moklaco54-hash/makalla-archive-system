using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/documents")]
public class DocumentsController : ControllerBase
{
    static List<Document> docs = new();

    [HttpGet]
    public IActionResult Get() => Ok(docs);

    [HttpPost]
    public IActionResult Add(Document d)
    {
        d.Id = docs.Count + 1;
        docs.Add(d);
        return Ok(d);
    }
}

public class Document
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
}
