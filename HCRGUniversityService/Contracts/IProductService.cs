using System.ServiceModel;
using HCRGUniversityService.DTO;
using System.Collections.Generic;
using HCRGUniversityService.DTO.Paged;

namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IProductService
    {
        #region Product
        [OperationContract]
        int AddProduct(Product product);
        [OperationContract]
        int UpdateProduct(Product product);
        [OperationContract]
        void DeleteProduct(int productID);
        [OperationContract]
        DTO.Paged.PagedProduct GetPagedProductByProductName(string productName, int skip, int take);
        [OperationContract]
        Product GetProductByID(int productID);
        [OperationContract]
        DTO.Paged.PagedProduct GetPagedProduct(int skip, int take);
        [OperationContract]
        DTO.Paged.PagedProductPurchase GetPagedProductByProductType(string productType, int userid, int skip, int take);
        [OperationContract]
        IEnumerable<DTO.ProductShopping> GetProductShoppingAllByProductID(int _productID);
        #endregion

        #region Product Qty
        [OperationContract]
        int addProductQuantity(ProductQuantity productQuantity);
        [OperationContract]
        int updateProductQuantity(ProductQuantity productQuantity);
        [OperationContract]
        ProductQuantity getProductQuantityByID(int productQuantityID);
        [OperationContract]
        DTO.Paged.PagedProductQuantity getProductQuantityDetailByProductID(int productID, int skip, int take);
        [OperationContract]
        DTO.Paged.PagedProductQuantity GetProductQuantityByProductID(int productID);
        #endregion

        #region Product Shipping Detail
        [OperationContract]
        int addProductShippingDetail(ProductShippingDetail productShippingDetail);
        [OperationContract]
        int updateProductShippingDetail(ProductShippingDetail productShippingDetail);
        [OperationContract]
        ProductShippingDetail getProductShippingDetailByID(int _productShippingDetailID);
        [OperationContract]
        DTO.Paged.PagedProductShippingDetail getProductShippingDetail(int _skip, int _take);
        [OperationContract]
        DTO.ProductShippingAddressDetailByID getProductShippingAddressDetailByID(int? _shippingPaymentID);
        [OperationContract]
        DTO.Paged.PagedProductPurchase getProductPurchaseDetailByID(int? _shippingPaymentID, int _skip, int _take);
        [OperationContract]
        DTO.Paged.PagedProductPurchasesRecord getProductPurchaseDetail(int _skip, int _take, int OrganizationID);
        #endregion
    }
}
 