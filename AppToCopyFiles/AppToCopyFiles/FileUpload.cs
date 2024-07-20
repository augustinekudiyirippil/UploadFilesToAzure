using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppToCopyFiles
{
    class FileUpload
    {

        string[] _filePath;
        string _fileName;



 


        public string AddCompanyStorage(string subDomain, string connectionString)
        {
            try 
            {

          
                 BlobContainerClient container = new BlobContainerClient(connectionString, subDomain);
            container.CreateIfNotExists(PublicAccessType.Blob);

                return "Container created";
            }
            catch(Exception ex)
            {
                return ex.Message.ToString(); 

            }

        }


        public async Task<string> uploadFilesToAzureBlobAsync(string connectionString, string containerName,  string filePath)
        {
            try             
            {
                BlobServiceClient _blobServiceClient = new BlobServiceClient(connectionString);
                var blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
                _filePath = filePath.Split('\\');
                _fileName = _filePath[_filePath.Length - 1];
              //  AddCompanyStorage("TestContainer", connectionString);
                BlobClient blobClient = blobContainerClient.GetBlobClient(_fileName);
              await blobClient.UploadAsync(filePath);
                return "Upload completed.";
            }
            catch(Exception ex)
            {
                return ex.Message.ToString(); 

            }

        }


       






//public async Task<string> Upload(IFormFile _formFile, string _FileName)
//{
//    try
//    {
//        BlobServiceClient _blobServiceClient = new BlobServiceClient(connectionString);
//        var containerInstance = _blobServiceClient.GetBlobContainerClient(GetTenantCode());

//        var blobInstance = containerInstance.GetBlobClient(_FileName);
//        var val = await blobInstance.UploadAsync(_formFile.OpenReadStream(), true);
//        return blobInstance.Uri.AbsoluteUri;
//    }
//    catch (Exception Ex)
//    {
//        throw;
//    }
//}


public string uploadFilesToAzure(string connectionString, string containerName, string blobName, string filePath)
        {
            try 
            { 

                // Create a BlobServiceClient
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            // Get the container client
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);

            // Create the container if it doesn't exist
            containerClient.CreateIfNotExists(PublicAccessType.Blob);

            // Get a reference to the blob
            BlobClient blobClient = containerClient.GetBlobClient(blobName);

           

            // Open the file and upload its data
            FileStream uploadFileStream =  File.OpenRead(filePath);
            blobClient.Upload(uploadFileStream, true);
            uploadFileStream.Close();

            return "Upload completed.";


            }
            catch(Exception ex)
            {
                return ex.Message.ToString(); 

            }


}

    }
}
