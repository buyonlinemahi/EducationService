using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;


namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IDiscountCouponService
    {
        [OperationContract]
        int AddDiscountCoupon(DiscountCoupon discountCoupon);
        [OperationContract]
        int UpdateDiscountCoupon(DiscountCoupon discountCoupon);
        [OperationContract]
        void DeleteDiscountCoupon(int CouponID);
        [OperationContract]
        DiscountCoupon GetDiscountCouponByID(int CouponID);
        [OperationContract]
        IEnumerable<DiscountCoupon> getAllDiscountCoupons();
        [OperationContract]
        DiscountCoupon GetDiscountCouponByCouponCode(string CouponCode);
        [OperationContract]
        int UpdateDiscountCouponStatus(string couponCode, bool value);
        [OperationContract]
        IEnumerable<DiscountCouponForCourses> GetDiscountCouponForCourses(int ClientID);
        [OperationContract]
        IEnumerable<DiscountCouponForCourses> GetDiscountCouponForProducts(int ClientID);
        [OperationContract]
        PagedDiscountCoupon GetAllPagedDiscountCoupon(int skip, int take);
        [OperationContract]
        PagedDiscountCoupon GetAllPagedDiscountCouponForCourses(int skip, int take, int ClientID);
    }
}