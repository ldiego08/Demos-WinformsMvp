using Codenough.Demos.WinFormsMVP.Data;
using Codenough.Demos.WinFormsMVP.Models;
using Codenough.Demos.WinFormsMVP.Presenters;
using Codenough.Demos.WinFormsMVP.Views;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Codenough.Demos.WinFormsMVP.Tests
{
    [TestFixture]
    public class WhenClientsWindowLoads
    {
        private Mock<IClientsView> clientsViewMock;
        private Mock<ClientRepository> clientsRepositoryMock;
        
        [SetUp]
        public void SetUp()
        {
            this.clientsViewMock = new Mock<IClientsView>();
            this.clientsRepositoryMock = new Mock<ClientRepository>();
        }

        [Test]
        public void ItShouldLoadAllClients()
        {
            // Act
            var clientsPresenter = new ClientsPresenter(clientsViewMock.Object, clientsRepositoryMock.Object);

            // Assert
            clientsViewMock.Verify(view => view.LoadClients(It.IsAny<IList<ClientModel>>()), "Expected clients to be loaded on initialization.");
        }

        [Test]
        public void ItShouldShowFirstClientOnListDetails()
        {
            // Arrange
            var clients = new List<ClientModel>() 
		    {
			    new ClientModel { Id = 1, Name = "Matt Dylan", Age = 28, Gender = "Male", Email = "mattd@none.com" },
			    new ClientModel { Id = 2, Name = "Anna Stone", Age = 22, Gender = "Female", Email = "ann@none.com" }
		    };

            clientsRepositoryMock.Setup(repository => repository.FindAll()).Returns(clients);
            
            // Act
            var clientsPresenter = new ClientsPresenter(clientsViewMock.Object, clientsRepositoryMock.Object);

            // Assert
            clientsViewMock.Verify(view => view.LoadClient(clients.First()), "Expected first client to be loaded on initialization.");
        }

        [Test]
        public void ItShouldShowClientDetailsOnListItemSelected()
        {
            // Arrange
            var clients = new List<ClientModel>() 
		    {
			    new ClientModel { Id = 1, Name = "Matt Dylan", Age = 28, Gender = "Male", Email = "mattd@none.com" },
			    new ClientModel { Id = 2, Name = "Anna Stone", Age = 22, Gender = "Female", Email = "ann@none.com" }
		    };

            clientsRepositoryMock.Setup(repository => repository.FindAll()).Returns(clients);
            clientsRepositoryMock.Setup(repository => repository.GetById(1)).Returns(clients.First());

            clientsViewMock.SetupGet(view => view.SelectedClient).Returns(clients.First());

            var clientsPresenter = new ClientsPresenter(clientsViewMock.Object, clientsRepositoryMock.Object);

            // Act
            clientsViewMock.Raise(view => view.ClientSelected += null);

            // Assert
            clientsViewMock.Verify(view => view.LoadClient(clients.First()), "Expected first client to be loaded on initialization.");
        }
    }
}
