using Codenough.Demos.WinFormsMVP.Data;
using Codenough.Demos.WinFormsMVP.Views;
using System.Linq;

namespace Codenough.Demos.WinFormsMVP.Presenters
{
    public class ClientsPresenter
    {
        private readonly IClientsView view;
        private readonly ClientRepository clientsRepository;

        public ClientsPresenter(IClientsView view, ClientRepository clientsRepository)
        {
            this.view = view;
            this.clientsRepository = clientsRepository;

            var clients = clientsRepository.FindAll();

            this.view.ClientSelected += OnClientSelected;
            this.view.LoadClients(clients);

            if (clients != null)
            {
                this.view.LoadClient(clients.First());
            }
        }

        public void OnClientSelected()
        {
            if (this.view.SelectedClient != null)
            {
                var id = this.view.SelectedClient.Id;
                var client = this.clientsRepository.GetById(id);

                this.view.LoadClient(client);
            }
        }
    }
}
