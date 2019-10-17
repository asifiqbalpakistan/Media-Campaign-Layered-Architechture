using OMG_Annalect_DAL_Core.Interface;
using OMG_Annalect_DAL_Core.Models;
using OMG_Annalect_DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_Annalect_BL_Core.BusinessObject
{


    public class AccountBLObject : BaseBL, IAccountBLObject
    {
        private readonly IAccountRepository _accountRepository;
        public AccountBLObject(IAccountRepository AccountRepository)
        {
            _accountRepository = AccountRepository;
        }

        public RegisterViewModel CreateUser(RegisterViewModel model)
        {
            using (UnitOfWork.BeginTransasction())
            {
                try
                {
                    _accountRepository.Register(model);
                    UnitOfWork.Commit();
                    return model;
                }
                catch
                {
                    UnitOfWork.Rollback();
                    return null;
                }
            }
        }
        public ClientModel CreateClient(ClientModel model)
        {
            using (UnitOfWork.BeginTransasction())
            {
                try
                {
                    _accountRepository.CreateClient(model);
                    UnitOfWork.Commit();
                    return model;
                }
                catch
                {
                    UnitOfWork.Rollback();
                    return null;
                }
            }
        }
        public LoginModel Login(LoginModel model)
        {
            try
            {
              
                _accountRepository.Login(model);
               
                return model;
            }
            catch
            {
                
                return null;
            }
        }
        public bool Logout()
        {
            try
            {
                _accountRepository.Logout();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
