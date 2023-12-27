using AccontApi.Core;
using AccountApi.Application.Interfaces;
using AccountApi.Core;
using AccountApi.Logging;
using AccountsUIBlazor.Data;
using AccountsUIBlazor.UIModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountsUIBlazor.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : BaseApiController
    {
       

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _IMapper;


        
        /// <summary>
        /// Initialize CustomerController by injecting an object type of IUnitOfWork
        /// </summary>
        public CustomerController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this._unitOfWork = unitOfWork;
            this._IMapper = Mapper;

        }

      
        [HttpGet]
        public async Task<ApiResponse<List<UICustomer>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<UICustomer>>();

            try
            {
                var data = await _unitOfWork.Customers.GetAllAsync();
                List<UICustomer> customerList = _IMapper.Map<List<UICustomer>>(data);
                apiResponse.Success = true;
                apiResponse.Result = customerList;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        [HttpGet("{id}")]
        public async  Task<ApiResponse<UICustomer>> GetById(int id)
        {

            var apiResponse = new ApiResponse<UICustomer>();

            try
            {
                var data = await _unitOfWork.Customers.GetByIdAsync(id);
                UICustomer customer = _IMapper.Map<UICustomer>(data);
                apiResponse.Success = true;
                apiResponse.Result = customer;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        [HttpPost]
        //[Route("AddCustomer")]
        public async Task<IActionResult> Add(UICustomer Customer)
        {
          
            var apiResponse = new ApiResponse<UICustomer>();
            Customer customer = _IMapper.Map<Customer>(Customer);
            customer.IsActive = true;

            try
            {
                var data = await _unitOfWork.Customers.AddAsync(customer);
                UICustomer customerdata = _IMapper.Map<UICustomer>(data);
                apiResponse.Success = true;
                apiResponse.Result = customerdata;
               
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return Ok(apiResponse);
        }

        [HttpPut]
        public async Task<ApiResponse<UICustomer>> Update(Customer Customer)
        {
            var apiResponse = new ApiResponse<UICustomer>();

            try
            {
                var data = await _unitOfWork.Customers.UpdateAsync(Customer);
                UICustomer customerdata = _IMapper.Map<UICustomer>(data);
                apiResponse.Success = true;
                apiResponse.Result = customerdata;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        [HttpDelete]
        public async Task<ApiResponse<UICustomer>> Delete(int id)
        {
            var apiResponse = new ApiResponse<UICustomer>();

            try
            {
                var data = await _unitOfWork.Customers.DeleteAsync(id);
                UICustomer customerdata = _IMapper.Map<UICustomer>(data);
                apiResponse.Success = true;
                apiResponse.Result = customerdata;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        
    }
}
