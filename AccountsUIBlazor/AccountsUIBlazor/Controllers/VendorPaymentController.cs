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
    public class VendorPaymentController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _IMapper;


        /// <summary>
        /// Initialize StockInController by injecting an object type of IUnitOfWork
        /// </summary>
        public VendorPaymentController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this._unitOfWork = unitOfWork;
            this._IMapper = Mapper;

        }

        [HttpGet]
        public async Task<ApiResponse<List<VendorPayment>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<VendorPayment>>();

            try
            {
                var data = await _unitOfWork.VendorPayment.GetAllAsync();
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
        [Route("GetVendorList")]
        public async Task<IActionResult> GetVendorList()
        {

            //var apiResponse = new ApiResponse<List<VendorPayment>>();
            //UIStockIn vendorNames = new UIStockIn();
            //Vendor.IsActive = true;
            var Result = new List<VendorList>();
            try
            {
                 Result = new List<VendorList> { new VendorList { VendorId=1, VendorName="ven"},
                    new VendorList { VendorId = 2, VendorName = "ven1" } };

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
        public async  Task<ApiResponse<VendorPayment>> GetById(int id)
        {

            var apiResponse = new ApiResponse<VendorPayment>();

            try
            {
                var data = await _unitOfWork.VendorPayment.GetByIdAsync(id);
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
        [Route("AddVendorPayment")]
        public async Task<IActionResult> AddVendorPayment(UIVendorPayment UIVendorPayment)
        {
          
            var apiResponse = new ApiResponse<string>();
            VendorPayment vendorPayment = _IMapper.Map<VendorPayment>(UIVendorPayment);
            //Vendor.IsActive = true;

            try
            {
                var data = await _unitOfWork.VendorPayment.AddAsync(vendorPayment);
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
        public async Task<ApiResponse<string>> Update(UIVendorPayment vendorPayment)
        {
            var apiResponse = new ApiResponse<string>();
            VendorPayment vendorpayment = _IMapper.Map<VendorPayment>(vendorPayment);
            try
            {
                var data = await _unitOfWork.VendorPayment.UpdateAsync(vendorpayment);
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
                var data = await _unitOfWork.VendorPayment.DeleteAsync(id);
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
