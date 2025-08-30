using ECom.UI.Models;
using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    // GET: /User/Register
    public IActionResult Register()
    {
        return View();
    }

    // POST: /User/Register
    [HttpPost]
    public IActionResult Register(UserRegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            // ... Your registration logic ...
            return RedirectToAction("Login", "User");
        }

        return View(model);
    }

    

    // GET: /User/Login
    public IActionResult Login()
    {
        return View();
    }

    // POST: /User/Login
    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // You would add your authentication logic here
            // e.g., check credentials against a database

            if (model.UserId == "demo" && model.Password == "password")
            {
                // Redirect to a dashboard or home page on successful login
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt. Please try again.");
            }
        }

        // If something went wrong, return the view with the model to show errors
        return View(model);
    }
}
