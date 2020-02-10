using System.ServiceModel;
using AutoMapper;
using HCRGUniversity.Core.BL;
using HCRGUniversityService.Contracts;
using HCRGUniversityService.CustomServiceBehaviors;
using System.Collections.Generic;
using HCRGUniversityService.DTO;

namespace HCRGUniversityService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AutoMapperServiceBehavior]
    public class ShippingPaymentService : IShippingPaymentService
    {
        private readonly IShippingAddress _shippingAddress;
        private readonly IBillingAddress _billingAddress;
        private readonly IShippingPayment _shippingPayment;

        public ShippingPaymentService(IShippingAddress shippingAddress, IBillingAddress billingAddress, IShippingPayment shippingPayment)
        {
            _shippingAddress = shippingAddress;
            _billingAddress = billingAddress;
            _shippingPayment = shippingPayment;
        }
        #region ShippingPayment

        public int addShippingPayment(DTO.ShippingPayment shippingPayment)
        {
            return _shippingPayment.addShippingPayment(Mapper.Map<DTO.ShippingPayment, HCRGUniversity.Core.Data.Model.ShippingPayment>(shippingPayment));
        }
        public int updateShippingPayment(DTO.ShippingPayment shippingPayment)
        {
            return _shippingPayment.updateShippingPayment(Mapper.Map<DTO.ShippingPayment, HCRGUniversity.Core.Data.Model.ShippingPayment>(shippingPayment));
        }
        public void deleteShippingPayment(int id)
        {
            _shippingPayment.deleteShippingPayment(id);
        }
        public DTO.ShippingPayment getShippingPaymentByID(int id)
        {
            return Mapper.Map<DTO.ShippingPayment>(_shippingPayment.getShippingPaymentByID(id));
        }
        public DTO.Paged.PagedShippingPayment getAllShippingPaymentByUserID(int UserID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedShippingPayment>(_shippingPayment.getAllShippingPaymentByUserID(UserID, skip, take));
        }
        public DTO.ShippingPayment getPendingShippingPaymentByUserID(int userID)
        {
            return Mapper.Map<DTO.ShippingPayment>(_shippingPayment.getPendingShippingPaymentByUserID(userID));
        }

        public void UpdateEducationShoppingCartTempByShippingPaymentID(int _educationShoppingTempID, int _shippingPaymentID, string PType)
        {
            _shippingPayment.UpdateEducationShoppingCartTempByShippingPaymentID(_educationShoppingTempID, _shippingPaymentID,PType);
        }

        public void addEducationShoppingRecordByShippingPaymentID(int _shippingPaymentID)
        {
            _shippingPayment.addEducationShoppingRecordByShippingPaymentID(_shippingPaymentID);
        }
        public DTO.ShippingPayment GetShippingPaymentByUserID(int uid)
        {
            return Mapper.Map<DTO.ShippingPayment>(_shippingPayment.GetShippingPaymentByUserID(uid));
        }
        #endregion

        #region BillingAddress
        public int addBillingAddress(DTO.BillingAddress billingAddress)
        {
            return _billingAddress.addBillingAddress(Mapper.Map<DTO.BillingAddress,HCRGUniversity.Core.Data.Model.BillingAddress>(billingAddress));
        }

        public int updateBillingAddress(BillingAddress billingAddress)
        {
            return _billingAddress.updateBillingAddress(Mapper.Map<DTO.BillingAddress, HCRGUniversity.Core.Data.Model.BillingAddress>(billingAddress));
        }
        public void deleteBillingAddress(int aboutUsID)
        {
            _billingAddress.deleteBillingAddress(aboutUsID);
        }

        public DTO.BillingAddress getBillingAddressByID(int id)
        {
            return Mapper.Map<DTO.BillingAddress>(_billingAddress.getBillingAddressByID(id));
        }

        public DTO.Paged.PagedBillingAddress getAllBillingAddressByUserID(int UserID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedBillingAddress>(_billingAddress.getAllBillingAddressByUserID(UserID, skip, take));
        }

        public BillingAddress getBillingAddressByUserID(int userID)
        {
            return Mapper.Map<DTO.BillingAddress>(_billingAddress.getBillingAddressByUserID(userID));
        }

        #endregion

        #region ShippingAddress
        public int addShippingAddress(DTO.ShippingAddress shippingAddress)
        {
            return _shippingAddress.addShippingAddress(Mapper.Map<DTO.ShippingAddress, HCRGUniversity.Core.Data.Model.ShippingAddress>(shippingAddress));
        }

        public int updateShippingAddress(ShippingAddress shippingAddress)
        {
            return _shippingAddress.updateShippingAddress(Mapper.Map<DTO.ShippingAddress, HCRGUniversity.Core.Data.Model.ShippingAddress>(shippingAddress));
        }
        public void deleteShippingAddress(int aboutUsID)
        {
            _shippingAddress.deleteShippingAddress(aboutUsID);
        }

        public DTO.ShippingAddress getShippingAddressByID(int id)
        {
            return Mapper.Map<DTO.ShippingAddress>(_shippingAddress.getShippingAddressByID (id));
        }

        public DTO.Paged.PagedShippingAddress getAllShippingAddressByUserID(int UserID, int skip, int take)
        {
            return Mapper.Map<DTO.Paged.PagedShippingAddress>(_shippingAddress.getAllShippingAddressByUserID(UserID, skip, take));
        }

        public ShippingAddress getShippingAddressByUserID(int userID)
        {
            return Mapper.Map<DTO.ShippingAddress>(_shippingAddress.getShippingAddressByUserID(userID));
        }

        #endregion
    }
}
