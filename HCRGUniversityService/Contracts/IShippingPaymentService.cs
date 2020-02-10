using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;
namespace HCRGUniversityService.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBillingShippindAddress" in both code and config file together.
    [ServiceContract]
    public interface IShippingPaymentService
    {

        #region ShippingPayment
        [OperationContract]
        int addShippingPayment(DTO.ShippingPayment _shippingAddress);
        [OperationContract]
        int updateShippingPayment(DTO.ShippingPayment _shippingAddress);
        [OperationContract]
        void deleteShippingPayment(int id);
        [OperationContract]
        DTO.ShippingPayment getShippingPaymentByID(int id);
        [OperationContract]
        DTO.Paged.PagedShippingPayment getAllShippingPaymentByUserID(int UserID, int skip, int take);
        [OperationContract]
        DTO.ShippingPayment getPendingShippingPaymentByUserID(int userID);
        [OperationContract]
        void UpdateEducationShoppingCartTempByShippingPaymentID(int _educationShoppingTempID, int _shippingPaymentID, string PType);
        [OperationContract]
        void addEducationShoppingRecordByShippingPaymentID(int _shippingPaymentID);
        [OperationContract]
        DTO.ShippingPayment GetShippingPaymentByUserID(int uid);
        #endregion

        #region Billing Address
        [OperationContract]
        int addBillingAddress(BillingAddress _billingAddress);
        [OperationContract]
        int updateBillingAddress(BillingAddress _billingAddress);
        [OperationContract]
        void deleteBillingAddress(int id);
        [OperationContract]
        BillingAddress getBillingAddressByID(int id);
        [OperationContract]
        PagedBillingAddress getAllBillingAddressByUserID(int UserID, int skip, int take);
        [OperationContract]
        BillingAddress getBillingAddressByUserID(int userID);
        #endregion

        #region Shipping Address
        [OperationContract]
        int addShippingAddress(ShippingAddress _shippingAddress);
        [OperationContract]
        int updateShippingAddress(ShippingAddress _shippingAddress);
        [OperationContract]
        void deleteShippingAddress(int id);
        [OperationContract]
        ShippingAddress getShippingAddressByID(int id);
        [OperationContract]
        PagedShippingAddress getAllShippingAddressByUserID(int UserID, int skip, int take);
        [OperationContract]
        ShippingAddress getShippingAddressByUserID(int userID);
        #endregion
    }
}
