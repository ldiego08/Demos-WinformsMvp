using Codenough.Demos.WinFormsMVP.Data;
using Codenough.Demos.WinFormsMVP.Presenters;
using Codenough.Demos.WinFormsMVP.Views;
using System;
using System.Windows.Forms;

namespace Codenough.Demos.WinFormsMVP 
{
    public static class Program 
    {
	    [STAThread]
	    public static void Main() 
        {
	        Application.EnableVisualStyles();
	        Application.SetCompatibleTextRenderingDefault(false);

            var clientsForm = new ClientsForm();
            var clientsRepository = new ClientRepository();
            var clientsPresenter = new ClientsPresenter(clientsForm, clientsRepository);

            clientsForm.Closed += () =>
            {
                Application.Exit();
            };

	        Application.Run(clientsForm);
	    }
    }
}
