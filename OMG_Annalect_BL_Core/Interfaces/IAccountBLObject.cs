using OMG_Annalect_DomainModels;

namespace OMG_Annalect_BL_Core.BusinessObject
{
    public interface IAccountBLObject
    {
        RegisterViewModel CreateUser(RegisterViewModel model);
        LoginModel Login(LoginModel model);
        bool Logout();
    }
}