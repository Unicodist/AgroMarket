namespace AgroMarket.Helper;

public class ProductFileHelper
{
    private readonly IHostEnvironment _environment;

    public ProductFileHelper(IHostEnvironment environment)
    {
        _environment = environment;
    }

    public async Task<string> UploadFile(IFormFile? file)
    {
        var ext = Path.GetExtension(file.FileName);
        string path = "/uploads/default.jpg";
        if (file == null) return path;
        var wwwPath = Path.Combine(_environment.ContentRootPath,"wwwroot","uploads");
        path = (Guid.NewGuid().ToString())+ Path.GetExtension(file.FileName);
        var fullPath = Path.Combine(wwwPath, path);
        await using var stream = new FileStream(fullPath, FileMode.Create);
        await file.CopyToAsync(stream);
        return path;
    }
}