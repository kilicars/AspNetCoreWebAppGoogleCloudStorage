# AspNetCoreWebAppGoogleCloudStorage
This is a "My Favourite Tv Shows App" written in ASP.NET Core with EF Core and SQL Server. This app is the modified version of the AspNetCoreWebApp found in [this repository](https://github.com/kilicars/AspNetCoreWebApp). In this modified version, user can upload the image of the TV show from her computer. Google Cloud Storage is used for storing and serving of the images.

You can find a detailed explanation about the development process of this application [in this post](https://medium.com/net-core/using-google-cloud-storage-in-asp-net-core-74f9c5ee55f5).

Before using the application you need to change the following lines in `appsettings.json` with your credential file path and GCS bucket name.

```
  "GoogleCredentialFile": "your-credential-json-file",
  "GoogleCloudStorageBucket": "your-bucket-name"
  ```
