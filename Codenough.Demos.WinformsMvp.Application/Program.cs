using System;
using Codenough.Demos.WinformsMvp.Application.Presenters;
using Codenough.Demos.WinformsMvp.Application.Views;
using Forms = System.Windows.Forms;

namespace Codenough.Demos.WinformsMvp.Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Forms.Application.EnableVisualStyles();
            Forms.Application.SetCompatibleTextRenderingDefault(false);

            var userListForm = new UserListForm();
            var userListPresenter = new UserListPresenter(userListForm);

            userListForm.Cancel += () =>
            {
                Forms.Application.Exit();
            };

            Forms.Application.Run(userListForm);
        }
    }
}
