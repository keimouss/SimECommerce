using SimECommerce.Application.Repos;
using SimECommerce.Application.Services.Queries;
using SimECommerce.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimECommerce.Application.Services.Core
{
    public class SimECommerceRegistrationService : IRegistrationService
    {
        readonly IUserRepo _userRepo;
        readonly IUoW _uow;
        public SimECommerceRegistrationService(IUoW uoW, IUserRepo userRepo)
        {
            _userRepo = userRepo;
            _uow = uoW;

        }
        public async Task RegisterUser(NewUserViewModel newUserViewModel, CancellationToken cancellationToken = default)
        {
            var v = new ValidationContext(newUserViewModel);
            Validator.ValidateObject(newUserViewModel, v);
            var userList = await _userRepo.ListAsync(new UserExistQuery(newUserViewModel.UserName));
            if (userList.Count > 0)
            {
                throw new ValidationException("Ce Utilisateur existe déjà!");
            }
            else
            {
                var user = newUserViewModel.CreateUser();
                await _userRepo.AddAsync(user, cancellationToken);
                await _uow.SaveChangeAsync(cancellationToken);
            }

        }
    }
}
