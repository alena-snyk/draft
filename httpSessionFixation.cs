using System.Web;
using System.Web.Mvc;

[HttpGet]
public ActionResult index(string val)
{
    Response.AddHeader("Set-Cookie", val);  // Noncompliant
    HttpCookie cookie = new HttpCookie("ASP.NET_SessionId", val);  // Noncompliant
    Response.AppendCookie(cookie);
    return View("");
}
