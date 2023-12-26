using GasPipeLine.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPipeLine.VM
{
    public class AppVM:BaseVM
    {
        private User _selectedUser;
        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged(nameof(SelectedUser));
            }
        }
        private ObservableCollection<User> _users; 
        public ObservableCollection<User> Users
        {
            get => _users;
            set 
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }

        }

        public AppVM()
        {
            Users = new ObservableCollection<User>();
            LoadDate();

        }
        public void LoadDate()
        {
            Users.Clear();
            using (GasPipelineDB db = new GasPipelineDB())
            {
                var userList = db.User.Include("Role").ToList();   
                userList.ForEach(p => Users.Add(p));
            }
        }
    }
}
