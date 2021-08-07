using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasamAssignment.Models
{
    public class PurchaseProductMap : Profile
    {
        public PurchaseProductMap()
        {
            CreateMap<Product, PurchaseProducts>();
            CreateMap<PurchaseProducts, Products>();
        }
    }
}
