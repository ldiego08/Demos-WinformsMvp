using Codenough.Demos.WinFormsMVP.Models;
using System.Collections.Generic;

namespace Codenough.Demos.WinFormsMVP.Data
{
    public class ClientRepository
    {
        private IList<ClientModel> clients = new List<ClientModel>() 
		{
			new ClientModel { Id = 1, Name = "Matt Dylan", Age = 28, Gender = "Male", Email = "mattd@none.com" },
			new ClientModel { Id = 2, Name = "Anna Stone", Age = 22, Gender = "Female", Email = "ann@none.com" }
		};

        public virtual ClientModel GetById(int id)
        {
            foreach (ClientModel client in this.clients)
            {
                if (client.Id == id)
                {
                    return client;
                }
            }

            return null;
        }

        public virtual IList<ClientModel> FindAll()
        {
            return this.clients;
        }
    }
}
