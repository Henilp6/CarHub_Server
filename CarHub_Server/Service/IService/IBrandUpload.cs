using Microsoft.AspNetCore.Components.Forms;


namespace CarHub_Server.Service.IService
{
    public interface IBrandUpload
    {
        Task<string> UploadFile(IBrowserFile file);

        bool DeleteFile(string filePath);

    }
}
