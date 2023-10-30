using Microsoft.AspNetCore.Mvc;

public class RandomCodeController : Controller
{
    public static int codeCount = 0;

    public ActionResult Index()
    {
        codeCount++;
        string randomCode = RandomCodeGenerator.GenerateRandomCode();
        ViewBag.RandomCode = randomCode;
        ViewBag.CodeCount = codeCount;
        return View("~/Views/Home/Index.cshtml");
    }
}
