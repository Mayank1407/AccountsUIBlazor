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
        public UnitOfWork(ICustomerRepository customerRepository)
        {
            Customers = customerRepository;
        }

        public ICustomerRepository Customers { get; set; }

    }
}
