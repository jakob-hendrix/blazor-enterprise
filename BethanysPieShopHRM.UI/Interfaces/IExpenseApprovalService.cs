using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.UI.Interfaces
{
    public interface IExpenseApprovalService
    {
        ExpenseStatus GetExpenseStatus(Expense expense, Employee employee);
    }
}