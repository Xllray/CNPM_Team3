using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;

namespace ApplicationCore.Mapping
{
    public static class OrderExtensionMethods
    {
        public static OrderDto ConvertToOrderDto(this Order Order)
        {
            return new OrderDto()
            {


                 OrderId =Order.OrderId,
                 OrderCustomerId =Order.OrderCustomerId,
                 OrderDate=Order.OrderDate


             };
        }

        public static IEnumerable<OrderDto> ConvertToOrderDtos(this IEnumerable<Order> Orders)
        {
            foreach (Order Order in Orders)
            {
                yield return Order.ConvertToOrderDto();
            }
        }

        public static Order ConvertToOrder(this OrderDto OrderDto)
        {
            return new Order()
            {
                OrderId = OrderDto.OrderId,
                OrderCustomerId = OrderDto.OrderCustomerId,
                OrderDate = OrderDto.OrderDate

            };
        }

        public static void Map(this OrderDto OrderDto, Order Order)
        {

            Order.OrderId = OrderDto.OrderId;
                 Order.OrderCustomerId = OrderDto.OrderCustomerId;
            Order.OrderDate = OrderDto.OrderDate;

        }
    }
}