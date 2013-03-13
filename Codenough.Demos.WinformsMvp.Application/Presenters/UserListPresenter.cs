using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Codenough.Demos.WinformsMvp.Core.Mvp;
using Codenough.Demos.WinformsMvp.Application.Models;

namespace Codenough.Demos.WinformsMvp.Application.Presenters
{
    public class UserListPresenter : Presenter<IUserListView>
    {
        public UserListPresenter(IUserListView view)
            : base(view)
        {
            this.View.UserSelected += OnUserSelected;

            var users = new List<UserModel> 
            {
                new UserModel { Name = "Robert Langley", LastLogin = DateTime.Now.AddDays(-1) },
                new UserModel { Name = "Laura Watson", LastLogin = DateTime.Now.AddDays(-3) }
            };

            this.View.LoadUsers(users);
        }

        public void OnUserSelected()
        {
            //TODO: Do something with selected user..
            Console.WriteLine("Selected user: " + this.View.SelectedUser.Name);
        }
    }
}
