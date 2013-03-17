using Codenough.Demos.WinFormsMVP.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Codenough.Demos.WinFormsMVP.Views
{
    public partial class ClientsForm : Form, IClientsView
    {
        public event Action ClientSelected;
        public event Action Closed;

	    public ClientsForm() 
        {
            this.InitializeComponent();
            this.BindComponent();
	    }

        public IList<ClientModel> Clients
        {
            get { return this.clientsListBox.DataSource as IList<ClientModel>; }
        }

        public ClientModel SelectedClient
        {
            get { return this.clientsListBox.SelectedItem as ClientModel; }
        }

        public void LoadClients(IList<ClientModel> clients)
        {
            this.clientsListBox.DataSource = clients;
        }

        public void LoadClient(ClientModel client)
        {
            this.clientNameTextBox.Text = client.Name;
            this.clientEmailTextBox.Text = client.Email;
            this.clientGenderTextBox.Text = client.Gender;
            this.clientAgeTextBox.Text = client.Age.ToString();
        }

        private void BindComponent()
        {
            this.closeButton.Click += OnCloseButtonClick;

            this.clientsListBox.DisplayMember = "Name";
            this.clientsListBox.SelectedIndexChanged += OnClientsListBoxSelectedIndexChanged;
        }

        private void OnClientsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ClientSelected != null)
            {
                this.ClientSelected();
            }
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            if (this.Closed != null)
            {
                this.Closed();
            }   
        }
    }
}
