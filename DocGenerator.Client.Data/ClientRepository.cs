namespace DocGenerator.Client.Data
{
    public class ClientRepository: IClientRepository
    {
        private List<ClientModel> _listOfClients;
        public ClientRepository()
        {
            _listOfClients = new List<ClientModel>
            {
                new ClientModel
                {
                    IdClient = new Guid("12345678-1234-1234-1234-1234567890AB"),
                    Name = "Jhon",
                    Document = "12345678912",
                    Address = "Rua das ruas na rua 123"
                }
            };
        }

        public async Task<ClientModel> GetClient(Guid idClient)
        {
            return _listOfClients.FirstOrDefault(x => x.IdClient.Equals(idClient));
        }
    }
}
