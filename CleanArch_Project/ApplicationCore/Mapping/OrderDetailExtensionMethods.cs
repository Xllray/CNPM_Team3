using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;

namespace ApplicationCore.Mapping
{
    public static class OrderDetailExtensionMethods
    {
        public static OrderDetailDto ConvertToOrderDetailDto(this OrderDetail OrderDetail)
        {
            return new OrderDetailDto()
            {


                 OrderDetailId=OrderDetail.OrderDetailId,
                   DetailProductId =OrderDetail.DetailProductId,
                  DetailOrderId =OrderDetail.DetailOrderId,
                  Quantity =OrderDetail.Quantity



    };
        }

        public static IEnumerable<OrderDetailDto> ConvertToOrderDetailDtos(this IEnumerable<OrderDetail> OrderDetails)
        {
            foreach (OrderDetail OrderDetail in OrderDetails)
            {
                yield return OrderDetail.ConvertToOrderDetailDto();
            }
        }

        public static OrderDetail ConvertToOrderDetail(this OrderDetailDto OrderDetailDto)
        {
            return new OrderDetail()
            {
                OrderDetailId = OrderDetailDto.OrderDetailId,
                DetailProductId = OrderDetailDto.DetailProductId,
                DetailOrderId = OrderDetailDto.DetailOrderId,
                Quantity = OrderDetailDto.Quantity

            };
        }

        public static void Map(this OrderDetailDto OrderDetailDto, OrderDetail OrderDetail)
        {

            OrderDetail.OrderDetailId = OrderDetailDto.OrderDetailId;
            OrderDetail.DetailProductId = OrderDetailDto.DetailProductId;
            OrderDetail.DetailOrderId = OrderDetailDto.DetailOrderId;
            OrderDetail.Quantity = OrderDetailDto.Quantity;

        }
    }
}