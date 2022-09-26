using Microsoft.AspNetCore.Mvc;
using Avaliacao3BimLP3.ViewModels;

namespace Avaliacao3BimLP3.Controllers;

public class LojaController : Controller
{
    private static List<LojaViewModel> lojas = new List<LojaViewModel>();

    public IActionResult Index()
    {
        return View(lojas);
    }
    public IActionResult Admin()
    {
        return View(lojas);
    }

    public IActionResult Show(int id)     
    {
        return View(lojas);
    }
    public IActionResult Cadastro()
    {
        return View(lojas);
    }

    public IActionResult NovaLoja(int id, string piso, string nome, string desc, string tipo, string email)
    {
        id = lojas.Count + 1;
        lojas.Add(new LojaViewModel(id, piso, nome, desc, tipo, email));

        return RedirectToAction("Admin");
    }

    public IActionResult DeletarLoja(int id)
    {
        lojas.RemoveAll(x => x.Id == id);
        return RedirectToAction("Admin");
    }
}