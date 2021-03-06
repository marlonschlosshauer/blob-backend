﻿using System;
using AutoMapper;
using Blob_API.Model;
using Blob_API.RessourceModels;

namespace Blob_API.RessourceMapping
{
    public class OrderedCustomerProfile : Profile
    {
        public OrderedCustomerProfile()
        {
            // Define the orgin and destination model for the mapping process.
            CreateMap<CustomerRessource, OrderedCustomer>()
                .ForMember(dest => dest.OrderedAddress, src => src.MapFrom(x => x.Address))
                .ReverseMap();
        }
    }
}
