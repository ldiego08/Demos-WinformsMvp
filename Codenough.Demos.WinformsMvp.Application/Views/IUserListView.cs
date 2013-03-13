using System;
using System.Collections.Generic;
using Codenough.Demos.WinformsMvp.Application.Models;
using Codenough.Demos.WinformsMvp.Core.Mvp;

namespace Codenough.Demos.WinformsMvp.Application
{
    public interface IUserListView : IView<IList<UserModel>>
    {
        event Action UserSelected;
        event Action Cancel;

        UserModel SelectedUser { get; }

        void LoadUsers(IList<UserModel> users);
    }
}
