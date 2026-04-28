using Microsoft.AspNetCore.Mvc;

namespace CoreMVCDay1.Controllers
{
    public class SampleController : Controller
    {
      public String First()
        {
            return "Welcome to ASP.NET Core MVC";
        }
        public String Second()
        {
            return "This is the second action method";
        }

        public String Square(int id)
        {
            int a = id * id;
            return $"Square of {id} is {a}";
        }

        public String Cube(int num)
        {
            int a = num * num * num;
            return $"Cube Of {num} is {a}";
        }

        public String Multiplication(int a,int b)
        {
            int c = a * b;
            return $"Multiplication of {a} and {b} is {c}";
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
