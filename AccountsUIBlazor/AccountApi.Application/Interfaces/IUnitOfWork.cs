using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApi.Application.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IVendorRepository Vendor { get; }
        ISalesRepository Sales { get; }
        ICommissionAgentExpensesRepository CommissionAgentExpenses { get; }
        ICommissionAgentPercentageRepository CommissionAgentPercentage { get; }
        ICustomerPaymentReceivedRepository CustomerPaymentReceived { get; }
        IExpensesTypesRepository ExpensesTypes { get; }
        IStockInRepository StockIn { get; }
        IVendorExpensesPaymentRepository VendorExpensesPayment { get; }
        IVendorPaymentRepository VendorPayment { get; }
    }
}
