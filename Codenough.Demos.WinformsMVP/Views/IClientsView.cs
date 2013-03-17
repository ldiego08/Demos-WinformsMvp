using Codenough.Demos.WinFormsMVP.Models;
using System;
using System.Collections.Generic;

namespace Codenough.Demos.WinFormsMVP.Views
{
    public interface IClientsView
    {
        event Action ClientSelected;
        event Action Closed;

        IList<ClientModel> Clients { get; }

        ClientModel SelectedClient { get; }

        void LoadClients(IList<ClientModel> clients);

        void LoadClient(ClientModel client);
    }
}
