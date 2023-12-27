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
    public class CustomerPaymentController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _IMapper;


        /// <summary>
        /// Initialize StockInController by injecting an object type of IUnitOfWork
        /// </summary>
        public CustomerPaymentController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this._unitOfWork = unitOfWork;
            this._IMapper = Mapper;

        }

        [HttpGet]
        public async Task<ApiResponse<List<CustomerPaymentReceived>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<CustomerPaymentReceived>>();

            try
            {
                var data = await _unitOfWork.CustomerPaymentReceived.GetAllAsync();
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

        [HttpGet]
        [Route("CustomerList")]
        public async Task<IActionResult> CustomerList()
        {

            //var apiResponse = new ApiResponse<List<CustomerPaymentReceived>>();
            //UIStockIn vendorNames = new UIStockIn();
            //Vendor.IsActive = true;
            var Result = new List<CustomerList>();
            try
            {
                 Result = new List<CustomerList> { new CustomerList { CustomerId=1, CustomerName="cust"},
                    new CustomerList { CustomerId = 2, CustomerName = "cust1" } };

                //  var data = await _unitOfWork.Vendor.GetAllAsync();
                //var names = _IMapper.Map<List<VendorNames>>(data);
                
                //apiResponse.Success = true;
               // apiResponse.Result = names.ToList();

            }
            catch (Exception ex)
            {
               // apiResponse.Success = false;
              //  apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            //catch (Exception ex)
            //{
            //    apiResponse.Success = false;
            //    apiResponse.Message = ex.Message;
            //    Logger.Instance.Error("Exception:", ex);
            //}

            return Ok(Result);
        }

        [HttpGet("{id}")]
        public async  Task<ApiResponse<CustomerPaymentReceived>> GetById(int id)
        {

            var apiResponse = new ApiResponse<CustomerPaymentReceived>();

            try
            {
                var data = await _unitOfWork.CustomerPaymentReceived.GetByIdAsync(id);
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

        [HttpGet]
        [Route("GetVendorLoadCount")]
        public async Task<int> GetVendorLoadCount(int vendorid,string createdDate)
        {

            var apiResponse = new ApiResponse<CustomerPaymentReceived>();

            try
            {
                // var data = await _unitOfWork.StockIn.GetVendorLoadCount(vendorid, createdDate);
                return 0;
               // apiResponse.Success = true;
               // apiResponse.Result = data;
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

            return 0;
        }

        [HttpPost]
        [Route("AddCustomerPayment")]
        public async Task<IActionResult> AddCustomerPayment(UICustomerPayment UICustomerPayment)
        {
          
            var apiResponse = new ApiResponse<string>();
            CustomerPaymentReceived custPayment = _IMapper.Map<CustomerPaymentReceived>(UICustomerPayment);
            //Vendor.IsActive = true;

            try
            {
                var data = await _unitOfWork.CustomerPaymentReceived.AddAsync(custPayment);
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

            return Ok(apiResponse);
        }

        [HttpPut]
        public async Task<ApiResponse<string>> Update(StockIn stockIn)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _unitOfWork.StockIn.UpdateAsync(stockIn);
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
                var data = await _unitOfWork.Vendor.DeleteAsync(id);
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

       
    }
}
