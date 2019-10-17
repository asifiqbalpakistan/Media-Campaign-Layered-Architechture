using OMG_Annalect_DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OMG_Annalect_DAL_Core.Interface
{
    public interface IAccountRepository
    {
        Task<bool> ForgotPassword(string userName);
        Task<LoginModel> Login(LoginModel model, string returnUrl = null);
        Task<RegisterViewModel> Register(RegisterViewModel model, string returnUrl = null);
        Task<bool> ResetPassword(string userName);
         bool Logout();
        List<string> RolesList();
        List<Microsoft.AspNetCore.Identity.IdentityRole> UserRolesList();
        string GetUserRoleByUserId(string userId);
        ClientModel CreateClient(ClientModel model, string returnUrl = null);
        List<ClientModel> ClientList();
        bool DeleteClient(long Id);
      
    }
}
