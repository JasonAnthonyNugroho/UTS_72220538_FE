using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using UTS_72220538.Components.Pages;


namespace UTS_72220538.Components.Pages
{
    public class CategoriesService
    {
        private readonly HttpClient _httpClient;

        public CategoriesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Categories>> GetCategoriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Categories>>("https://actualbackendapp.azurewebsites.net/api/v1/Categories");
        }

        public async Task<Categories> GetCategoryByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Categories>($"https://actualbackendapp.azurewebsites.net/api/v1/Categories/{id}");
        }

        public async Task CreateCategoryAsync(Categories category)
        {
            await _httpClient.PostAsJsonAsync("https://actualbackendapp.azurewebsites.net/api/v1/Categories", category);
        }

        public async Task UpdateCategoryAsync(Categories category)
        {
            await _httpClient.PutAsJsonAsync($"https://actualbackendapp.azurewebsites.net/api/v1/Categories/{category.categoryId}", category);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await _httpClient.DeleteAsync($"https://actualbackendapp.azurewebsites.net/api/v1/Categories/{id}");
        }
    }
}