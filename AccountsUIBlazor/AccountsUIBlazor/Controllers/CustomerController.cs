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
        #region ===[ Private Members ]=============================================================

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _IMapper;


        #endregion

        #region ===[ Constructor ]=================================================================

        /// <summary>
        /// Initialize CustomerController by injecting an object type of IUnitOfWork
        /// </summary>
        public CustomerController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this._unitOfWork = unitOfWork;
            this._IMapper = Mapper;

        }

        #endregion

        #region ===[ Public Methods ]==============================================================

        [HttpGet]
        public async Task<ApiResponse<List<Customer>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<Customer>>();

            try
            {
                var data = await _unitOfWork.Customers.GetAllAsync();
                apiResponse.Success = true;
                apiResponse.Result = data.ToList();
            }
            //catch (SqlException ex)
            //{
            //    apiResponse.Success = false;
            //    apiResponse.Message = ex.Message;
            //    Logger.Instance.Error("SQL Exception:", ex);
            //}
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        [HttpGet("{id}")]
        public async  Task<ApiResponse<Customer>> GetById(int id)
        {

            var apiResponse = new ApiResponse<Customer>();

            try
            {
                var data = await _unitOfWork.Customers.GetByIdAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            //catch (SqlException ex)
            //{
            //    apiResponse.Success = false;
            //    apiResponse.Message = ex.Message;
            //    Logger.Instance.Error("SQL Exception:", ex);
            //}
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
          //var results =   new ApiResponse<List<Customer>>();
            var apiResponse = new ApiResponse<string>();
            Customer customer = _IMapper.Map<Customer>(Customer);
            try
            {
                var data = await _unitOfWork.Customers.AddAsync(customer);
                apiResponse.Success = true;
                apiResponse.Result = data;
                //results.Result = data
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            //catch (Exception ex)
            //{
            //    apiResponse.Success = false;
            //    apiResponse.Message = ex.Message;
            //    Logger.Instance.Error("Exception:", ex);
            //}

            return Ok(apiResponse);
        }

        [HttpPut]
        public async Task<ApiResponse<string>> Update(Customer Customer)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _unitOfWork.Customers.UpdateAsync(Customer);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            //catch (Exception ex)
            //{
            //    apiResponse.Success = false;
            //    apiResponse.Message = ex.Message;
            //    Logger.Instance.Error("Exception:", ex);
            //}

            return apiResponse;
        }

        [HttpDelete]
        public async Task<ApiResponse<string>> Delete(int id)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _unitOfWork.Customers.DeleteAsync(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            //catch (SqlException ex)
            //{
            //    apiResponse.Success = false;
            //    apiResponse.Message = ex.Message;
            //    Logger.Instance.Error("SQL Exception:", ex);
            //}
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                Logger.Instance.Error("Exception:", ex);
            }

            return apiResponse;
        }

        #endregion
    }
}
