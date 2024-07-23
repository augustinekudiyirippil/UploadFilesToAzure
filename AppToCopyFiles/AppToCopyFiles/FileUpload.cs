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
        string filePathSecondPart;






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


        public List<string> listContainers(string azStorageConnString)
        {

            BlobServiceClient blobServiceClient = new BlobServiceClient(azStorageConnString);
            var containerNameList = blobServiceClient.GetBlobContainers();
            List<string> containerNames = new List<string>();
            foreach (var container in containerNameList)
            {
                var cName = container.Name;
                containerNames.Add(container.Name);
            }

            return containerNames;





        }



        public async Task<string> uploadFilesToAzureBlobAsync(string connectionString, string containerName,  string filePath , string sqlDatabase)
        {

  



            try             
            {

                _filePath = StringExtension.xSplit(  filePath, sqlDatabase+"\\");
                filePathSecondPart = _filePath[_filePath.Length - 1];

                BlobServiceClient _blobServiceClient = new BlobServiceClient(connectionString);
                var containerInstance = _blobServiceClient.GetBlobContainerClient(containerName);

               

                byte[] fileBytes = File.ReadAllBytes(filePath);
                Stream stream = new MemoryStream(fileBytes);

                var blobInstance = containerInstance.GetBlobClient(filePathSecondPart);
                var val = await blobInstance.UploadAsync(stream, true);



                return "Upload completed.";
            }
            catch(Exception ex)
            {
                return ex.Message.ToString(); 

            }

        }

        public async Task<string> uploadFilesToAzureBlobAsyncBackup(string connectionString, string containerName, string filePath)
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
            catch (Exception ex)
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
