using MyPointOfSale.DataAccessSQLServer;
using MyPointOfSale.Models;
using MyPointOfSale.ViewModels;
using System;
using System.Collections.Generic;

namespace MyPointOfSale.Controllers
{
    public class UserController
    {
        private readonly UserDao _userDao;

        public UserController()
        {
            _userDao = new UserDao();
        }

        public UserController(UserDao userDao)
        {
            _userDao = userDao;
        }

        public IReadOnlyList<UserViewModel> GetUsers()
        {
            List<UserViewModel> users = new List<UserViewModel>();
            foreach (User user in _userDao.GetUsers())
            {
                users.Add(new UserViewModel()
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    PositionName = user.Position.PositionName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DocumentName = user.DocumentType.DocumentName,
                    DocumentNumber = user.DocumentNumber,
                    Email = user.Email
                });
            }
            return users.AsReadOnly();
        }

        public IReadOnlyList<PositionsViewModel> GetPositions()
        {
            List<PositionsViewModel> positions = new List<PositionsViewModel>();
            foreach (Position position in _userDao.GetPositions())
            {
                positions.Add(new PositionsViewModel()
                {
                    PositionId = position.PositionId,
                    PositionName = position.PositionName
                });
            }
            return positions.AsReadOnly();
        }

        public IReadOnlyList<DocumentTypeViewModel> GetDocumentTypes()
        {
            List<DocumentTypeViewModel> documentTypes = new List<DocumentTypeViewModel>();
            foreach (DocumentType documentType in new DocumentDao().GetDocuments())
            {
                documentTypes.Add(new DocumentTypeViewModel()
                {
                    DocumentID = documentType.DocumentID,
                    DocumentName = documentType.DocumentName
                });
            }

            return documentTypes.AsReadOnly();
        }

        public bool Login(UserLoginViewModel userViewModel)
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

        public void CrearUsuario(UsuarioCreateViewModel usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser nulo");
            }

            User user = new User()
            {
                Username = usuario.Username,
                Password = usuario.Password,
                Email = usuario.Email,
                FirstName = usuario.FirstName,
                LastName = usuario.LastName,
                Position = new Position()
                {
                    PositionId = usuario.PositionId
                },
                DocumentType = new DocumentType()
                {
                    DocumentID = usuario.DocumentTypeId
                },
                DocumentNumber = usuario.DocumentNumber
            };

            _userDao.CrearUsuario(user);

        }

        public void ActualizarUsuario(UsuarioUpdatedViewModel usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser nulo");
            }

            User user = new User()
            {
                UserId = usuario.UserId,
                Username = usuario.Username,
                Password = usuario.Password,
                Email = usuario.Email,
                FirstName = usuario.FirstName,
                LastName = usuario.LastName,
                Position = new Position()
                {
                    PositionId = usuario.PositionId
                },
                DocumentType = new DocumentType()
                {
                    DocumentID = usuario.DocumentTypeId
                },
                DocumentNumber = usuario.DocumentNumber
            };

            _userDao.ActualizarUsuario(user);
        }

        public void EliminarUsuario(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del usuario debe ser mayor que cero", nameof(id));
            }

            _userDao.EliminarUsuario(id);
        }
    }
}
