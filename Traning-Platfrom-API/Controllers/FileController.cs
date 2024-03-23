using Amazon.S3.Model;
using Amazon.S3;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Traning_Platfrom_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        public async Task<string> UploadFile(IFormFile file)
        {
            return await UploadFileContaboS3Async(file);
        }
        private async Task<string> UploadFileContaboS3Async(IFormFile file)
        {
            try
            {
                var accessKey = "1a0545ccf0f738390364c344e40bde6f";
                var secretKey = "a67bde4d6114fa7d8d7db8cfd7699e20";
                var bucketName = "demo-test";

                AmazonS3Config config = new AmazonS3Config();
                config.ServiceURL = "https://eu2.contabostorage.com";
                config.DisableHostPrefixInjection = true;
                config.ForcePathStyle = true;


                AmazonS3Client s3Client = new AmazonS3Client(
                        accessKey,
                        secretKey,
                        config
                        );

                //ListBucketsResponse response = await s3Client.ListBucketsAsync();
                var fileName = $"{file.FileName}UUU-{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                using (var newMemoryStream = new MemoryStream())
                {
                    file.CopyTo(newMemoryStream);
                    PutObjectRequest request = new PutObjectRequest();
                    request.BucketName = bucketName;
                    request.Key = fileName;
                    request.ContentType = file.ContentType;
                    request.InputStream = newMemoryStream;
                    request.CannedACL = S3CannedACL.PublicRead;
                    await s3Client.PutObjectAsync(request);
                    string url = $"https://eu2.contabostorage.com/9970579dc911485db9363cf382a0f253:demo-test/{fileName}";
                    return url;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Some Thing Went Wrong When Upload Attachement");
            }
        }
    }
}
