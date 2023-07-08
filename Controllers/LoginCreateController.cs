using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MVC_Registration.Models;

namespace MVC_Registration.Controllers
{
    public class LoginCreateController : Controller
    {
        private readonly MVC_RegistrationContext _context;

        public LoginCreateController(MVC_RegistrationContext context)
        {
            _context = context;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void connectString()
        {
            con.ConnectionString = "data source=DESKTOP-GUNQO71\\SQLEXPRESS;Initial Catalog=MVC_Registration;Integrated Security=True";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // GET: LoginCreate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoginCreate/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Password")] SignUp signUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(signUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(signUp);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // GET: Login User
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login User
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(SignUp signUp)
        {
            connectString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from SignUp where Username= '" + signUp.Username +
                "' and Password='" + signUp.Password + "'";
            dr = com.ExecuteReader();
            if (dr.Read()) // if statement: if it reads the db, draw the username and password from db and send the user to anoher page
            {
                con.Close();
                return Redirect("https://localhost:44331/");
            }
            else
            {
                con.Close();
                //FlashMessage.Danger("");
                return Redirect("https://localhost:44331/Home/Privacy");
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    }
}
