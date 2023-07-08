# MVC-Registration
MVC - Login and Create User

![image](https://github.com/Jordan-of-the-Green/MVC-Registration/assets/101722700/a9bd779c-0541-454c-98b2-3bb601c3f973)

Scaffold the project with this:

- Scaffold-DbContext "Server=DESKTOP-GUNQO71\SQLEXPRESS;Database=MVC_Registration;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Download these dependencies

![image](https://github.com/Jordan-of-the-Green/MVC-Registration/assets/101722700/8001f243-4b64-49f7-8f5d-8e6e76b6c77e)

Add this to Startup.cs

![image](https://github.com/Jordan-of-the-Green/MVC-Registration/assets/101722700/afadfda7-67c2-494c-b767-05a0661c18f0)

services.AddDbContext<PROG7311Context>(options =>
     options.UseSqlServer("Server=DESKTOP-GUNQO71\\SQLEXPRESS;Database=MVC_Registration;Trusted_Connection=True;"));



