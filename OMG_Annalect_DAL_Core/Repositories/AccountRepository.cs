using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OMG_Annalect_DAL_Core.Data;
using OMG_Annalect_DAL_Core.Interface;
using OMG_Annalect_DAL_Core.Models;
using OMG_Annalect_DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMG_Annalect_DAL_Core.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<ApplicationUser> _entities;
        readonly string _errorMessage = string.Empty;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public AccountRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

        }

        public string GetUserRoleByUserId(string userId)
        {
            var roleId = _context.UserRoles.Where(t => t.UserId == userId).FirstOrDefault();
            return _context.Roles.FirstOrDefault(t => t.Id == roleId.RoleId).Name;

        }
        public async Task<LoginModel> Login(LoginModel model, string returnUrl = null)
        {

            if (model != null)
            {


                // This doesn't count login failures towards account lockout
           //     RegisterAdmin();
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.IsRemember, lockoutOnFailure: false);

                if (result.Succeeded)
                {


                    return model;
                }
            }

            return null;
        }


        public List<string> RolesList()
        {
            var rolesList = new List<string>();
            var roles = _roleManager.Roles;
            foreach (var item in roles)
            {
                rolesList.Add(item.ToString());
            }
            return rolesList;
        }

        public List<IdentityRole> UserRolesList()
        {
            var roles = _roleManager.Roles.ToList();
            return roles;
        }

        public async Task<RegisterViewModel> Register(RegisterViewModel model, string returnUrl = null)
        {


            if (model != null)
            {
                var user = new ApplicationUser { UserName = model.Username, Email = model.Email, PhoneNumber = model.PhoneNumber.ToString(), FirstName = model.FirstName, LastName = model.LastName, IsDocumentAccess = model.IsDocumentAccess };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, model.UserRoles);
                    return model;
                }
            }
            return null;
        }
        

    public async Task<bool> ForgotPassword(string userName)
    {
        if (!string.IsNullOrEmpty(userName))
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
            {
                // Don't reveal that the user does not exist or is not confirmed
                return false;
            }
            return true;

        }

        return false;
    }


    public async Task<bool> ResetPassword(string userName)
    {
        if (string.IsNullOrEmpty(userName))
        {

            return false;
        }
        var user = await _userManager.FindByNameAsync(userName);
        if (user == null)
        {
            // Don't reveal that the user does not exist
            return false;
        }

        return true;
    }
    public bool Logout()
    {
        _signInManager.SignOutAsync();
        return true;
    }


    public ClientModel CreateClient(ClientModel model, string returnUrl = null)
    {


        if (model != null)
        {

            var client = new Client
            {
                Name = model.Name,
                Email = model.Email,
                ContactNumber = model.ContactNumber,
                ContactPerson = model.ContactPerson,
                Address1 = model.Address1,
                Address2 = model.Address2,
                AddedBy = model.AddedBy,
                AddedTime = DateTime.Now,

            };
            _context.Add(client);
            _context.SaveChanges();
            //try
            //{
            //    var user = new ApplicationUser { UserName = model.Email, Email = model.Email, PhoneNumber = model.ContactNumber.ToString(), IsDocumentAccess = model.IsDocumentAccess, FirstName = model.Name, LastName = model.Name };
            //    var result = await _userManager.CreateAsync(user, password);
            //    if (result.Succeeded)
            //    {
            //        await _userManager.AddToRoleAsync(user, role);
            //        return model;
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw ex; 
            //}
            return model;

        }
        return null;
    }
    public List<ClientModel> ClientList()
    {
        var model = new List<ClientModel>();
        var clients = _context.Clients.Where(o => o.IsDeleted == false).ToList();
        foreach (var item in clients)
        {
            var client = new ClientModel
            {
                Name = item.Name,
                Email = item.Email,
                ContactNumber = item.ContactNumber,
                ContactPerson = item.ContactPerson,
                Address1 = item.Address1,
                Address2 = item.Address2,
                AddedBy = item.AddedBy,
                AddedTime = item.AddedTime,
                ClientId = item.Id

            };
            model.Add(client);
        }
        return model;
    }

    public bool DeleteClient(long Id)
    {
        try
        {
            var client = _context.Clients.Where(o => o.Id == Id).FirstOrDefault();
            _context.Remove(client);
            _context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
            throw;
        }

    }
}
}
