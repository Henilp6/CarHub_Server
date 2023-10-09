using Microsoft.AspNetCore.Components.Forms;


namespace CarHub_Server.Service.IService
{
    public interface ICarUpload
    {
        Task<string> UploadFile(IBrowserFile file);

        bool DeleteFile(string filePath);

    }
}
