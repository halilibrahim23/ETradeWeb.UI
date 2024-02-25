using ETradeWeb.EntityLayer;
using ETradeWeb.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ETradeWeb.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
       
    {
        private readonly IService<User> _service;
        private readonly IService<Roles> _serviceRol;

        public UserController(IService<User> service, IService<Roles> serviceRol)
        {
            _service = service;
            _serviceRol = serviceRol;
        }

        // GET: UserController
        public async Task<ActionResult> Index()
        {
            var model = await _service.GetAllAsync();
            return View(model);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.RolesId = new SelectList(await _serviceRol.GetAllAsync(),"Id","Name");
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                   await _service.AddAsync(user);
                   await _service.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
                }


            }
            ViewBag.RolesId = new SelectList(await _serviceRol.GetAllAsync(), "Id", "Name");

            return View(user);
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
