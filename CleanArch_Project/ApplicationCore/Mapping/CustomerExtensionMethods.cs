using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;

namespace ApplicationCore.Mapping
{
    public static class CustomerExtensionMethods
    {
        public static CustomerDto ConvertToCustomerDto(this Customer Customer)
        {
            return new CustomerDto()
            {
                CustomerId =Customer.CustomerId,
                Name =Customer.Name,

                Phone=Customer.Phone,
               Email=Customer.Email,
               Address=Customer.Address



    };
        }

        public static IEnumerable<CustomerDto> ConvertToCustomerDtos(this IEnumerable<Customer> Customers)
        {
            foreach (Customer Customer in Customers)
            {
                yield return Customer.ConvertToCustomerDto();
            }
        }

        public static Customer ConvertToCustomer(this CustomerDto CustomerDto)
        {
            return new Customer()
            {
                CustomerId = CustomerDto.CustomerId,
                Name = CustomerDto.Name,

                Phone = CustomerDto.Phone,
                Email = CustomerDto.Email,
                Address = CustomerDto.Address

            };
        }

        public static void Map(this CustomerDto CustomerDto, Customer Customer)
        {
            Customer.CustomerId = CustomerDto.CustomerId;
            Customer.Name = CustomerDto.Name;

            Customer.Phone = CustomerDto.Phone;
            Customer.Email = CustomerDto.Email;
            Customer.Address = CustomerDto.Address;


        }
    }
}