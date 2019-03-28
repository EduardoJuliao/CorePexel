using System;
using System.Net.Http;
using System.Threading.Tasks;
using CorePexel.Models;
using CorePexel.Models.Video;
using Newtonsoft.Json;

namespace CorePexel
{
   public class CorePexelClient
   {
      private const string BaseUrl = "http://api.pexels.com/v1/";
      private static readonly HttpClient client = new HttpClient();

      /// <summary>
      /// Creates a new client
      /// </summary>
      /// <param name="apiKey">your pexel api key</param>
      public CorePexelClient(string apiKey)
      {
         client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", apiKey);
      }

      /// <summary>
      /// Get photos based on a search query
      /// </summary>
      /// <param name="query">search term</param>
      /// <param name="page">page number</param>
      /// <param name="perPage">items per page</param>
      /// <returns></returns>
      public async Task<PhotoPageModel> SearchAsync(string query, int page = 1, int perPage = 15)
      {
         var url = $"{BaseUrl}?search={Uri.EscapeDataString(query)}&per_page={perPage}&page={page}";
         var response = await client.GetAsync(url).ConfigureAwait(false);
         var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
         if (!response.IsSuccessStatusCode)
         {
            throw new CorePexelException(response.StatusCode, body);
         }

         return JsonConvert.DeserializeObject<PhotoPageModel>(body);
      }

      /// <summary>
      /// Get the most popular photos
      /// </summary>
      /// <param name="page">page number</param>
      /// <param name="perPage">items per page</param>
      /// <returns></returns>
      public async Task<PhotoPageModel> GetPopularAsync(int page = 1, int perPage = 15)
      {
         var url = $"{BaseUrl}popular?per_page={perPage}&page={page}";
         var response = await client.GetAsync(url).ConfigureAwait(false);
         var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
         if (!response.IsSuccessStatusCode)
         {
            throw new CorePexelException(response.StatusCode, body);
         }

         return JsonConvert.DeserializeObject<PhotoPageModel>(body);
      }

      /// <summary>
      /// Get curated photos
      /// </summary>
      /// <param name="page">page number</param>
      /// <param name="perPage">items per page</param>
      /// <returns></returns>
      public async Task<PhotoPageModel> GetCuratedPhotos(int page = 1, int perPage = 15)
      {
         var url = $"{BaseUrl}curated?per_page={perPage}&page={page}";
         var response = await client.GetAsync(url).ConfigureAwait(false);
         var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
         if (!response.IsSuccessStatusCode)
         {
            throw new CorePexelException(response.StatusCode, body);
         }

         return JsonConvert.DeserializeObject<PhotoPageModel>(body);
      }

      /// <summary>
      /// Get one photo by it's Id
      /// </summary>
      /// <param name="photoId">Photo Id</param>
      /// <returns></returns>
      public async Task<PhotoModel> GetPhotoAsync(string photoId)
      {
         var url = $"{BaseUrl}photos/{photoId}";
         var response = await client.GetAsync(url).ConfigureAwait(false);

         var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
         if (!response.IsSuccessStatusCode)
         {
            throw new CorePexelException(response.StatusCode, body);
         }

         return JsonConvert.DeserializeObject<PhotoModel>(body);
      }

      /// <summary>
      /// Search for videos based on a query
      /// </summary>
      /// <param name="query">search term</param>
      /// <param name="page">page number</param>
      /// <param name="perPage">items per page</param>
      /// <returns></returns>
      public async Task<VideoPageModel> SearchVideosAsync(string query, int page = 1, int perPage = 15)
      {
         var url = $"{BaseUrl}videos/popular?query={Uri.EscapeDataString(query)}&per_page={perPage}&page={page}";
         var response = await client.GetAsync(url).ConfigureAwait(false);

         var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
         if (!response.IsSuccessStatusCode)
         {
            throw new CorePexelException(response.StatusCode, body);
         }

         return JsonConvert.DeserializeObject<VideoPageModel>(body);
      }

      /// <summary>
      /// Get the most popular videos
      /// </summary>
      /// <param name="page">page number</param>
      /// <param name="perPage">items per page</param>
      /// <returns></returns>
      public async Task<VideoPageModel> GetPopularVideosAsync(int page = 1, int perPage = 15)
      {
         var url = $"{BaseUrl}videos/popular?per_page={perPage}&page={page}";
         var response = await client.GetAsync(url).ConfigureAwait(false);

         var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
         if (!response.IsSuccessStatusCode)
         {
            throw new CorePexelException(response.StatusCode, body);
         }

         return JsonConvert.DeserializeObject<VideoPageModel>(body);
      }
   }
}