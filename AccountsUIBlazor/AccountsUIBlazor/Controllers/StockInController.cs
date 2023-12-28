using AccontApi.Core;
using AccountApi.Application.Interfaces;
using AccountApi.Core;
using AccountApi.Logging;
using AccountsUIBlazor.Data;
using AccountsUIBlazor.Pages;
using AccountsUIBlazor.UIModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountsUIBlazor.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class StockInController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _IMapper;

        public StockInController(IUnitOfWork unitOfWork, IMapper Mapper)
        {
            this._unitOfWork = unitOfWork;
            this._IMapper = Mapper;

        }

        [HttpGet]
        public async Task<ApiResponse<List<UIStockIn>>> GetAll()
        {
            var apiResponse = new ApiResponse<List<UIStockIn>>();

            try
            {
                var data = await _unitOfWork.StockIn.GetAllAsync();
                apiResponse.Success = true;
                List<UIStockIn> stockinData = _IMapper.Map<List<UIStockIn>>(data);
                apiResponse.Result = stockinData;
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

        [HttpGet]
        [Route("GetVendorNames")]
        public async Task<IActionResult> GetVendorList()
        {

            //var apiResponse = new ApiResponse<List<VendorNames>>();
            UIStockIn vendorNames = new UIStockIn();
            //Vendor.IsActive = true;
            var Result = new List<VendorNames>();
            try
            {
                 Result = new List<VendorNames> { new VendorNames { VendorId=1, VendorName="rams"},
                    new VendorNames { VendorId = 2, VendorName = "rams1" } };

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
        [HttpPost]
        [Route("PostStockInsAsPerVendorId")]
        public async Task<IActionResult> PostStockInsAsPerVendorId(UIVendorCalenderModel UiCalenderModel)
        {
            List<UISalesStockInData> sales = new List<UISalesStockInData>();
            //var apiResponse = new ApiResponse<string>();

            //customer.IsActive = true;

            try
            {
                //var data = await _unitOfWork.StockIn.GetStockInDataAsperDates(
                //    UiCalenderModel.FromDate.ToString(),
                //    UiCalenderModel .ToDate.ToString(), UiCalenderModel.VendorId);
                sales.Add(new UISalesStockInData { LoadName = "load1", VendorId = 1, Quantity = 100, StockInId = 1 });
                sales.Add(new UISalesStockInData { LoadName = "load2", VendorId = 2, Quantity = 700, StockInId = 2 });

                //sales = _IMapper.Map<List<UISalesStockInData>>(data);

                //apiResponse.Success = true;
                //apiResponse.Result = data;

            }
            catch (Exception ex)
            {
                //apiResponse.Success = false;
                //apiResponse.Message = ex.Message;
                Logger.Instance.Error("SQL Exception:", ex);
            }
            //catch (Exception ex)
            //{
            //    apiResponse.Success = false;
            //    apiResponse.Message = ex.Message;
            //    Logger.Instance.Error("Exception:", ex);
            //}

            return Ok(sales);
        }

        [HttpGet("{id}")]
        public async  Task<ApiResponse<UIStockIn>> GetById(int id)
        {

            var apiResponse = new ApiResponse<UIStockIn>();

            try
            {
                var data = await _unitOfWork.StockIn.GetByIdAsync(id);
                apiResponse.Success = true;
                UIStockIn stockinData = _IMapper.Map<UIStockIn>(data);
                apiResponse.Result = stockinData;
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

        [HttpGet]
        [Route("GetVendorLoadCount")]
        public async Task<int> GetVendorLoadCount(int vendorid,string createdDate)
        {

            var apiResponse = new ApiResponse<AccountApi.Core.StockIn>();

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
        [Route("AddVendor")]
        public async Task<IActionResult> Add(UIStockIn stockin)
        {
          
            var apiResponse = new ApiResponse<UIStockIn>();
            AccountApi.Core.StockIn stockinData = _IMapper.Map<AccountApi.Core.StockIn>(stockin);
            //Vendor.IsActive = true;

            try
            {
                var data = await _unitOfWork.StockIn.AddAsync(stockinData);
                apiResponse.Success = true;
                UIStockIn stockinDataresults = _IMapper.Map<UIStockIn>(data);
                apiResponse.Result = stockinDataresults;
               
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
        public async Task<ApiResponse<UIStockIn>> Update(UIStockIn uIStockIn)
        {
            var apiResponse = new ApiResponse<UIStockIn>();

            try
            {
                AccountApi.Core.StockIn stockinData = _IMapper.Map<AccountApi.Core.StockIn>(uIStockIn);
                var data = await _unitOfWork.StockIn.UpdateAsync(stockinData);
                apiResponse.Success = true;

                UIStockIn stockinDataresults = _IMapper.Map<UIStockIn>(data);
                apiResponse.Result = stockinDataresults;
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
