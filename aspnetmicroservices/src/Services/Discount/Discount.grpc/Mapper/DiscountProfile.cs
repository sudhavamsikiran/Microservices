using AutoMapper;
using Discount.grpc.Entities;
using Discount.grpc.Protos;
using Discount.grpc.Entities;
using Discount.grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
