namespace AgroMarket.Helper;

public class ProductFileHelper
{
    private readonly IHostEnvironment _environment;

    public ProductFileHelper(IHostEnvironment environment)
    {
        _environment = environment;
    }

    public string UploadFile(IFormFile? file)
    {
        var path = "/uploads/default.jpg";
        if (file!=null)
        {
            var wwwPath = _environment.ContentRootPath;
            var mainPath = Path.Combine(wwwPath, "uploads");
            var filename = Path.Combine(Guid.NewGuid().ToString(),file.GetFileName);
            path = 
        }
        return path;
    }
}