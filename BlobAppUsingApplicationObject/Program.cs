using Azure.Identity;
using Azure.Storage.Blobs;


string tenantId = "dd393912-1b31-48f1-b206-c7273175d5b8";
string clientId = "652319c9-8aff-4520-8cfb-bd2afcd4dbc5";
string clientSecret = "-Rs8Q~YQq_cIiouIMnk7BzZQDexMRnS3ETgE3drT";


string blobURI = "https://anishstorage786.blob.core.windows.net/anishcontainer/AZ-900.txt";
string filePath = "C:\\ImagesFolder\\script.txt";

ClientSecretCredential clientCredential = new ClientSecretCredential(tenantId, clientId, clientSecret);

BlobClient blobClient = new BlobClient(new Uri(blobURI), clientCredential);

await blobClient.DownloadToAsync(filePath);

Console.WriteLine("The blob is downloaded");


