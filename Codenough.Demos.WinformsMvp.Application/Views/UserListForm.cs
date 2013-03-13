using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Codenough.Demos.WinformsMvp.Application.Models;

namespace Codenough.Demos.WinformsMvp.Application.Views
{
    public partial class UserListForm : Form, IUserListView
    {
        public event Action UserSelected;
        public event Action Cancel;

        public UserModel SelectedUser
        {
            get { return this.usersListBox.SelectedItem as UserModel; }
        }

        public IList<UserModel> Model
        {
            get { return this.usersListBox.DataSource as IList<UserModel>; }
        }

        public UserListForm()
        {
            this.InitializeComponent();
        }

        public void LoadUsers(IList<UserModel> users)
        {
            this.usersListBox.DataSource = users;
        }

        private void OnUsersListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.UserSelected != null)
            {
                this.UserSelected();
            }
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            if (this.Cancel != null)
            {
                this.Cancel();
            }
        }
    }
}
