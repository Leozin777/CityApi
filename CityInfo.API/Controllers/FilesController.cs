using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers;

[Route("api/files")]
[ApiController]
public class FilesController : ControllerBase
{
    private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

    public FilesController(FileExtensionContentTypeProvider p_fileEx)
    {
        _fileExtensionContentTypeProvider = p_fileEx ?? throw new System.ArgumentNullException(nameof(p_fileEx));
    }

    [HttpGet("{p_fileId}")]
    public ActionResult GetFile(string p_fileId)
    {
        //Caminho do arquivo
        var pathToFile = "LEO.png";

        if (! System.IO.File.Exists(pathToFile))
            return NotFound();

        if(! _fileExtensionContentTypeProvider.TryGetContentType(pathToFile, out var contentType))
        {
            contentType = "application/octet-stream";
        }

        var bytes = System.IO.File.ReadAllBytes(pathToFile);
        return File(bytes, contentType, Path.GetFileName(pathToFile));
    }
}
