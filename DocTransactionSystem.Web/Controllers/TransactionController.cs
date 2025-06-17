using Microsoft.AspNetCore.Mvc;
using DocTransactionSystem.Data.Repositories;
using DocTransactionSystem.Models;

namespace DocTransactionSystem.Web.Controllers;

public class TransactionController : Controller
{
    private readonly ITransactionRepository _repo;

    public TransactionController(ITransactionRepository repo)
    {
        _repo = repo;
    }

    public IActionResult Index()
    {
        var transactions = _repo.GetAll();
        return View(transactions);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Transaction model)
    {
        if (ModelState.IsValid)
        {
            _repo.Add(model);
            return RedirectToAction(nameof(Index));
        }
        return View(model);
    }

    // Edit, Delete, Details... سيتم إضافتها لاحقاً
}