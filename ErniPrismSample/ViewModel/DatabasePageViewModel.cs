using ErniPrismSample.Base;
using ErniPrismSample.Entities;
using ErniPrismSample.Managers.User;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ErniPrismSample.ViewModel
{
    public class DatabasePageViewModel:BaseViewModel
    {
        private readonly IUserManager _userManager;

        private ObservableCollection<UserEntity> _ListOfUsers;
        public ObservableCollection<UserEntity> ListOfUsers
        {
            get {
                return _ListOfUsers;
            }
            set
            {
                SetProperty(ref _ListOfUsers, value);
            }
        }

        private string _user;
        public string User
        {
            get
            {
                return _user;
            }
            set
            {
                SetProperty(ref _user, value);
            }
        }

        private DelegateCommand _AddUserCommand;
        public DelegateCommand AddUserCommand =>
            _AddUserCommand ?? (_AddUserCommand = new DelegateCommand(ExecuteAddUser));

        private DelegateCommand _RefreshCommand;
        public DelegateCommand RefreshCommand =>
            _RefreshCommand ?? (_RefreshCommand = new DelegateCommand(ExecuteRefreshUser));

        private void ExecuteRefreshUser()
        {
            ListOfUsers = new ObservableCollection<UserEntity>(_userManager.RetrieveAllUser());
        }

        private void ExecuteAddUser()
        {
            _userManager.SaveUser(new UserEntity() { Name = User });
            User = string.Empty;
            ExecuteRefreshUser();
        }

        public DatabasePageViewModel(IUserManager userManager)
        {
            _userManager = userManager;
        }
    }
}
