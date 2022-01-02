using CommercialSite.Common.DTOs.ShipmentInfo;
using CommercialSite.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.APIs
{
    [Headers("Authorization: Bearer", "Content-Type: application/json")]
    public interface IShipmentInfoApi
    {
        [Get("/shipmentInfo")]
        Task<ApiResponse<WebApiResponse<List<ShipmentInfoResponse>>>> List();

        [Get("/shipmentInfo/{id}")]
        Task<ApiResponse<WebApiResponse<ShipmentInfoResponse>>> Get(Guid id);

        [Post("/shipmentInfo")]
        Task<ApiResponse<WebApiResponse<ShipmentInfoResponse>>> Post(ShipmentInfoRequest request);

        [Put("/shipmentInfo/{id}")]
        Task<ApiResponse<WebApiResponse<ShipmentInfoResponse>>> Put([FromQuery] Guid id, [FromBody] ShipmentInfoRequest request);

        [Delete("/shipmentInfo/{id}")]
        Task<ApiResponse<WebApiResponse<ShipmentInfoResponse>>> Delete(Guid id);

        [Get("/shipmentInfo/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/shipmentInfo/getactive")]
        Task<ApiResponse<WebApiResponse<List<ShipmentInfoResponse>>>> GetActive();
    }
}
