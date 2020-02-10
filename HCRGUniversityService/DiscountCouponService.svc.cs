using System.ServiceModel;
using AutoMapper;
using HCRGUniversity.Core.BL;
using HCRGUniversityService.Contracts;
using HCRGUniversityService.CustomServiceBehaviors;
using System.Collections.Generic;

namespace HCRGUniversityService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AutoMapperServiceBehavior]
    public class DiscountCouponService : IDiscountCouponService
    {
        private readonly IDiscountCoupon _discountCoupon;
        public DiscountCouponService(IDiscountCoupon discountCoupon)
        {
            _discountCoupon = discountCoupon;
        }

        public int AddDiscountCoupon(DTO.DiscountCoupon discountCoupon)
        {
            return _discountCoupon.AddDiscountCoupon(Mapper.Map<DTO.DiscountCoupon, HCRGUniversity.Core.BL.Model.DiscountCoupon>(discountCoupon));
        }

        public int UpdateDiscountCoupon(DTO.DiscountCoupon discountCoupon)
        {
            return _discountCoupon.UpdateDiscountCoupon(Mapper.Map<DTO.DiscountCoupon, HCRGUniversity.Core.BL.Model.DiscountCoupon>(discountCoupon));
        }

        public void DeleteDiscountCoupon(int couponID)
        {
            _discountCoupon.DeleteDiscountCoupon(couponID);
        }

        public IEnumerable<DTO.DiscountCoupon> getAllDiscountCoupons()
        {
            return Mapper.Map<IEnumerable<DTO.DiscountCoupon>>(_discountCoupon.getAllDiscountCoupons());
        }

        public DTO.DiscountCoupon GetDiscountCouponByID(int couponID)
        {
            return Mapper.Map<DTO.DiscountCoupon>(_discountCoupon.GetDiscountCouponByID(couponID));
        }

        public DTO.DiscountCoupon GetDiscountCouponByCouponCode(string couponCode)
        {
            return Mapper.Map<DTO.DiscountCoupon>(_discountCoupon.GetDiscountCouponByCouponCode(couponCode));
        }

        public int UpdateDiscountCouponStatus(string couponCode, bool value)
        {
            return _discountCoupon.UpdateDiscountCouponStatus(couponCode, value);
        }

        public IEnumerable<DTO.DiscountCouponForCourses> GetDiscountCouponForCourses(int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.DiscountCouponForCourses>>(_discountCoupon.GetDiscountCouponForCourses(ClientID));
        }

        public IEnumerable<DTO.DiscountCouponForCourses> GetDiscountCouponForProducts(int ClientID)
        {
            return Mapper.Map<IEnumerable<DTO.DiscountCouponForCourses>>(_discountCoupon.GetDiscountCouponForProducts(ClientID));
        }

        public DTO.Paged.PagedDiscountCoupon GetAllPagedDiscountCoupon(int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedDiscountCoupon>(_discountCoupon.GetAllPagedDiscountCoupon(skip, take));
        }
        public DTO.Paged.PagedDiscountCoupon GetAllPagedDiscountCouponForCourses(int skip, int take, int ClientID)
        {
            return Mapper.Map<DTO.Paged.PagedDiscountCoupon>(_discountCoupon.GetAllPagedDiscountCouponForCourse(skip, take, ClientID));
        }
    }
}