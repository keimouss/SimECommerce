using SimECommerce.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimECommerce.Application.Services
{
    public interface IRegistrationService
    {
        Task RegisterUser(NewUserViewModel newUserViewModel, CancellationToken cancellationToken = default);
    }
}
