using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OMG_Annalect_BL_Core.BusinessObject;
using OMG_Annalect_DAL_Core.Interface;
using OMG_Annalect_DAL_Core.Models;
using OMG_Annalect_DomainModels;

namespace OMG_Annalect_Assessment.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountController(IAccountRepository AccountRepository, UserManager<ApplicationUser> userManager)
        {
            _accountRepository = AccountRepository;
            _userManager = userManager;
        }
     

        public IActionResult CreateUser()
        {

            var list = _accountRepository.UserRolesList();
            ViewBag.UserRoles = new SelectList(list, "Name", "Name");
            return View(new RegisterViewModel());
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        [Authorize]
        [HttpGet]
        public IActionResult ViewProfile()
        {
            var id = this._userManager.GetUserId(User);
            var user = this._userManager.Users.Where(m => m.Id == id).FirstOrDefault();
            if (user == null)
                return View(new RegisterViewModel());

            var model = (new RegisterViewModel
            {

                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserRoles = _accountRepository.GetUserRoleByUserId(id)

            });
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var obj = await _accountRepository.Login(model);
            return RedirectToAction("Index", "Campaign");
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterViewModel model)
        {
            var obj = await _accountRepository.Register(model);
            return RedirectToAction("UserList", "Account");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            _accountRepository.Logout();
            return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public async Task<IActionResult> LoginAuthentication()
        {
            try
            {
                var model = new RegisterViewModel() {
                     Username = "Admin",
                    Email= "m_asifiqbal@outlook.com",
                    PhoneNumber= "0589562502",
                    FirstName= "Admin",
                    LastName= "OMG",
                    Password= "123456",
                    ConfirmPassword= "123456",
                    IsDocumentAccess= true,
                    UserRoles= "Admin"
                };
                var obj = await _accountRepository.Register(model);
                return Json(new { success = true });
            }
            catch (Exception)
            {

                return Json(new { success = false });
            }
           
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateClientUser(ClientModel model)
        {
            try
            {
                var modelRegister = new RegisterViewModel()
                {
                    Username = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.ContactNumber,
                    FirstName = model.Name,
                    LastName = model.Name,
                    Password = "123456",
                    ConfirmPassword = "123456",
                    IsDocumentAccess = true,
                    UserRoles = "Client"
                };
                var obj = await _accountRepository.Register(modelRegister);
                return Json(new { success = true });
            }
            catch (Exception)
            {

                return Json(new { success = false });
            }


        }
        public List<string> RolesList()
        {
            return _accountRepository.RolesList().ToList();
        }

        [Authorize(Roles = "Admin,Manager")]
        public IActionResult CreateClient()
        {

            return View(new ClientModel());
        }
        [HttpPost]
        public IActionResult CreateClient(ClientModel model)
        {
            if (ModelState.IsValid)
            {

                _accountRepository.CreateClient(model);
                
                return RedirectToAction("ClientList", "Account");
            }
            else return View(model);
        }

        [Authorize]
        public ActionResult ChangePassword()
        {
            ViewBag.StatusMessage = "dp-none";
            return View();
        }

        //
        // POST: /Manage/ChangePassword
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            ViewBag.StatusMessage = "dp-none";
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var id = this._userManager.GetUserId(User);
            var user = this._userManager.Users.Where(m => m.Id == id).FirstOrDefault();
            if (user == null)
                return View(new ChangePasswordViewModel());
            var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {

                if (user != null)
                {
                    var lognModel = new LoginModel()
                    {
                        Username = user.UserName,
                        Password = model.NewPassword,
                        IsRemember = false
                    };
                    await _accountRepository.Login(lognModel);
                }
                ViewBag.StatusMessage = "Your password has been changed.";

                return RedirectToAction("Index", "Campaign");
            }

            return View(model);
        }
        public IActionResult UserList()
        {
            var registerViewModels = new List<RegisterViewModel>();
            var users = this._userManager.Users.ToList();
            if (users == null)
                return View(new RegisterViewModel());
            foreach (var item in users)
            {
                var model = (new RegisterViewModel
                {

                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Username = item.UserName,
                    Email = item.Email,
                    PhoneNumber = item.PhoneNumber
                });
                registerViewModels.Add(model);
            }

            return View(registerViewModels);
        }
        public IActionResult ClientList()
        {
         
            var users= this._accountRepository.ClientList();
            if (users == null)
                return View(new ClientModel());
           
            return View(users);
        }

        [HttpPost]
        public ActionResult DeleteUser(string id)
        {
            if (id == null)
            {
                 return RedirectToAction("UserList", "Account"); 
            }
            var user = this._userManager.Users.Where(m => m.Email == id).FirstOrDefault();
            if (user == null)
                return View(new ChangePasswordViewModel());
            try
            {
                _userManager.DeleteAsync(user);
                return Json(new { success = true });
            }
            catch (Exception)
            {
                return Json(new { success = false });
                throw;
            }
           
        }
        [HttpPost]
        public ActionResult DeleteClient(long id)
        {
            if (id < 1)
            {
                return RedirectToAction("ClientList", "Account");
            }
           
            try
            {
                var user = _accountRepository.DeleteClient(id);
                if (user)
                    return Json(new { success = true });
                else
                    return Json(new { success = false });
            }
            catch (Exception)
            {
                return Json(new { success = false });
                throw;
            }

        }

        
    }
}