# CorePexel

CorePexel is a `dotnet core` wrapper for the [PexelsApi](https://www.pexels.com/api/).

Get it on nuget: https://www.nuget.org/packages/CorePexel/

Usage

```csharp

private static CorePexelClient client = new CorePexelClient("<your_api_key>");

public async Task<PhotoPageModel> GetPhotos() 
{
   return await client.GetPopularAsync();
}

```
