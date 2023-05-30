using BudgetApp.Models.ViewModels;
using BudgetApp.Repositories;

namespace BudgetApp.Controllers;

public class HomeController : Controller
{
    private readonly IBudgetRepository _budgetRepository;

    public HomeController(IBudgetRepository budgetRepository)
    {
        _budgetRepository = budgetRepository;
    }

    public IActionResult Index()
    {
        var transactions = _budgetRepository.GetTransactions();
        var viewModel = new BudgetViewModel()
        {
            Transactions = transactions
        };
        
        return View(viewModel);
    }
}