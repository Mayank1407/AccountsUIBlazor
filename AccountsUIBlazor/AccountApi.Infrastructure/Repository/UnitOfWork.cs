using AccountApi.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApi.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICustomerRepository customerRepository,
            IVendorRepository vendorRepository,
             ISalesRepository salesRepository,
            ICommissionAgentExpensesRepository commissionAgentExpensesRepository,
            ICommissionAgentPercentageRepository commissionAgentPercentageRepository,
            ICustomerPaymentReceivedRepository customerPaymentReceivedRepository,
            IExpensesTypesRepository expensesTypesRepository,
            IStockInRepository stockInRepository,
            IVendorExpensesPaymentRepository vendorExpensesPaymentRepository,
            IVendorPaymentRepository vendorPaymentRepository)
        {
            Customers = customerRepository;
            Vendor = vendorRepository;
            Sales = salesRepository;
            CommissionAgentExpenses = commissionAgentExpensesRepository;
            CommissionAgentPercentage = commissionAgentPercentageRepository;
            CustomerPaymentReceived = customerPaymentReceivedRepository;
            ExpensesTypes = expensesTypesRepository;
            StockIn = stockInRepository;
            VendorExpensesPayment = vendorExpensesPaymentRepository;
            VendorPayment = vendorPaymentRepository;
            
        }

        public ICustomerRepository Customers { get; set; }
        public IVendorRepository Vendor { get; set; }
        public ICommissionAgentExpensesRepository CommissionAgentExpenses { get; set; }
        public ICommissionAgentPercentageRepository CommissionAgentPercentage { get; set; }

        public ICustomerPaymentReceivedRepository CustomerPaymentReceived { get; set; }
        public IExpensesTypesRepository ExpensesTypes { get; set; }
        public ISalesRepository Sales { get; set; }
        public IStockInRepository StockIn { get; set; }
        public IVendorExpensesPaymentRepository VendorExpensesPayment { get; set; }
        public IVendorPaymentRepository VendorPayment { get; set; }
       
    }
}
