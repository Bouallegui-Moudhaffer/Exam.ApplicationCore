namespace Exam.Web.Data
{
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;
    using Exam.ApplicationCore.Domain; // Ensure this is the correct namespace for your Utilisateur class
    using System.Collections.Generic;

    public class UtilisateurService
    {
        private readonly HttpClient _httpClient;

        public UtilisateurService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Utilisateur>> GetUtilisateursAsync()
        {
            var fullUri = new Uri("https://localhost:7165/api/Utilisateurs");
            return await _httpClient.GetFromJsonAsync<IEnumerable<Utilisateur>>(fullUri.ToString());
        }


        public async Task<Utilisateur> GetUtilisateurAsync(int id)
        {
            var fullUri = new Uri("https://localhost:7165/api/Utilisateurs");
            return await _httpClient.GetFromJsonAsync<Utilisateur>($"{fullUri.ToString}" + "/" + $"{id}");
        }

        public async Task<Utilisateur> AddUtilisateurAsync(Utilisateur utilisateur)
        {
            var fullUri = new Uri("https://localhost:7165/api/Utilisateurs");
            var response = await _httpClient.PostAsJsonAsync($"{fullUri.ToString}", utilisateur);
            return await response.Content.ReadFromJsonAsync<Utilisateur>();
        }

        public async Task UpdateUtilisateurAsync(Utilisateur utilisateur)
        {
            var fullUri = new Uri("https://localhost:7165/api/Utilisateurs");
            
            await _httpClient.PutAsJsonAsync($"{fullUri.ToString}" + "/" + $"{utilisateur.UtilisateurId}", utilisateur);
        }

        public async Task DeleteUtilisateurAsync(int id)
        {
            var fullUri = new Uri("https://localhost:7165/api/Utilisateurs");
            await _httpClient.DeleteAsync($"{fullUri.ToString}" + "/" + $"{id}");
        }
    }

}
