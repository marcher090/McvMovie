using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;




public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();                                                                              // The index /action method/ calls the controller's view method. View templates are made using Razor and have a .cshtml file
                                                                                                    // extenstion and provide an elegant way of creating HTML output in c#
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");                                   
    }
    // GET: /HelloWorld/Test2/ 
    public string Test2()
    {
        return "This is the Test2 action method...";
    }
}


/*
public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");                                   //In this example the ID value is taken in from the URL. Note that because the routing is "{controller=Home}/{action=Index}/{id?}",
                                                                                                        //the url should be ending with "/HelloWorld/Welcome/3?name=Rick" and that the trailing ? after id makes it optional. 
    }
    // GET: /HelloWorld/Test2/ 
    public string Test2()
    {
        return "This is the Test2 action method...";
    }
}
*/





/*public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");                         //Takes in the values from the URL localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4. This is because the ? in the URL routes the
                                                                                                            //subsequent values after the to a query that then matches the name and numtimes values. Note that the caps doesn't matter. 
    }
    // GET: /HelloWorld/Test2/ 
    public string Test2()
    {
        return "This is the Test2 action method...";
    }
}*/




//public class HelloWorldController : Controller
//{
//    // 
//    // GET: /HelloWorld/
//    public string Index()
//    {
//        return "This is my default action...";
//    }
//    // 
//    // GET: /HelloWorld/Welcome/ 
//    public string Welcome()
//    {
//        return "This is the Welcome action method...";
//    }
//    // GET: /HelloWorld/Test2/ 
//    public string Test2()
//    {
//        return "This is the Test2 action method...";
//    }
//}

