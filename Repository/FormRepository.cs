using CosmosAPI.Models;
using Microsoft.Azure.Cosmos;

namespace CosmosAPI.Repository
{
    public class FormRepository
    {
        private readonly Container _container;

        public FormRepository(CosmosClient cosmosClient, string dbName, string containerName)
        {
            _container = cosmosClient.GetContainer(dbName, containerName);
        }

        public async Task<Form> CreateFormAsync(Form form)
        {
            var response = await _container.CreateItemAsync(form, new PartitionKey(form.Id));
            return response;
        }

        public async Task<Form> UpdateFormAsync(string id, Form form)
        {
            var response = await _container.UpsertItemAsync(form, new PartitionKey(id));
            return response;
        }
    }
}
