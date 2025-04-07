using MyPointOfSale.DataAccessSQLServer;
using MyPointOfSale.Models;
using MyPointOfSale.ViewModels;
using System;

namespace MyPointOfSale.Controllers
{
    public class UserController
    {
        private readonly UserDao _userDao;

        public UserController()
        {
            _userDao = new UserDao();
        }

        public bool Login(UserViewModel userViewModel)
        {
            if (string.IsNullOrEmpty(userViewModel.Username) || string.IsNullOrEmpty(userViewModel.Password))
            {
                throw new ArgumentException("Usuario y contraseña son obligatorios");
            }
            // Here you would typically call a method from your data access layer
            // to check the credentials against a database.
            // For example:
            // return userDao.Login(new User { Username = username, Password = password });
            // For the sake of this example, let's assume the login is always successful.

            return _userDao.Login(new User
            {
                Username = userViewModel.Username,
                Password = userViewModel.Password
            });
        }
    }
}
