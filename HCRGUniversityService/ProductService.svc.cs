using System.ServiceModel;
using AutoMapper;
using HCRGUniversity.Core.BL;
using HCRGUniversityService.Contracts;
using HCRGUniversityService.CustomServiceBehaviors;
using System.Collections.Generic;
using HCRGUniversityService.DTO;
using HCRGUniversityService.DTO.Paged;

namespace HCRGUniversityService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AutoMapperServiceBehavior]
    public class ProductService : IProductService
    {

        private readonly IProduct _product;
        private readonly IProductShippingDetail _productShippingDetail;

        public ProductService(IProduct product, IProductShippingDetail productShippingDetail)
        {
            _product = product;
            _productShippingDetail = productShippingDetail;
        }

        #region Product
        public int AddProduct(DTO.Product product)
        {
            return _product.AddProduct(Mapper.Map<DTO.Product, HCRGUniversity.Core.Data.Model.Product>(product));
        }

        public int UpdateProduct(DTO.Product product)
        {
            return _product.UpdateProduct(Mapper.Map<DTO.Product, HCRGUniversity.Core.Data.Model.Product>(product));
        }

        public void DeleteProduct(int productID)
        {
            _product.DeleteProduct(productID);
        }

        public Product GetProductByID(int productID)
        {
            return Mapper.Map<Product>(_product.GetProductByID(productID));
        }

        public PagedProduct GetPagedProductByProductName(string productName, int skip, int take)
        {
            return Mapper.Map<PagedProduct>(_product.GetPagedProductByProductName(productName, skip, take));
        }

        public PagedProduct GetPagedProduct(int skip, int take)
        {
            return Mapper.Map<PagedProduct>(_product.GetPagedProduct(skip, take));
        }
        public DTO.Paged.PagedProductPurchase GetPagedProductByProductType(string productType, int userid, int skip, int take)
        {
            return Mapper.Map<PagedProductPurchase>(_product.GetPagedProductByProductType(productType, userid, skip, take));
        }

        public IEnumerable<DTO.ProductShopping> GetProductShoppingAllByProductID(int _productID)
        {
            return Mapper.Map<IEnumerable<ProductShopping>>(_product.GetProductShoppingAllByProductID(_productID));
        }
        #endregion

        #region Product Qty

        public int addProductQuantity(DTO.ProductQuantity productQuantity)
        {
            return _product.AddProductQuantity(Mapper.Map<DTO.ProductQuantity, HCRGUniversity.Core.Data.Model.ProductQuantity>(productQuantity));
        }

        public int updateProductQuantity(ProductQuantity productQuantity)
        {
            return _product.UpdateProductQuantity(Mapper.Map<DTO.ProductQuantity, HCRGUniversity.Core.Data.Model.ProductQuantity>(productQuantity));
        }
        public ProductQuantity getProductQuantityByID(int productQuantityID)
        {
            return Mapper.Map<ProductQuantity>(_product.GetProductQuantityByID(productQuantityID));
        }

        public DTO.Paged.PagedProductQuantity getProductQuantityDetailByProductID(int productID, int skip, int take)
        {
            return Mapper.Map<PagedProductQuantity>(_product.GetProductQuantityDetailByProductID(productID, skip, take));
        }


        public DTO.Paged.PagedProductQuantity GetProductQuantityByProductID(int productID)
        {
            return Mapper.Map<PagedProductQuantity>(_product.GetProductQuantityByProductID(productID));
        }

        #endregion

        #region Product Shipping Detail

        public int addProductShippingDetail(ProductShippingDetail productShippingDetail)
        {
            return _productShippingDetail.AddProductShippingDetail(Mapper.Map<DTO.ProductShippingDetail, HCRGUniversity.Core.Data.Model.ProductShippingDetail>(productShippingDetail));
        }
        public int updateProductShippingDetail(ProductShippingDetail productShippingDetail)
        {
            return _productShippingDetail.UpdateProductShippingDetail(Mapper.Map<DTO.ProductShippingDetail, HCRGUniversity.Core.Data.Model.ProductShippingDetail>(productShippingDetail));
        }
        public ProductShippingDetail getProductShippingDetailByID(int _productShippingDetailID)
        {
            return Mapper.Map<ProductShippingDetail>(_productShippingDetail.GetProductShippingDetailByID(_productShippingDetailID));
        }

        public DTO.Paged.PagedProductShippingDetail getProductShippingDetail(int _skip, int _take)
        {
            return Mapper.Map<PagedProductShippingDetail>(_productShippingDetail.GetProductShippingDetail(_skip, _take));
        }

        public DTO.ProductShippingAddressDetailByID getProductShippingAddressDetailByID(int? _shippingPaymentID)
        {
            return Mapper.Map<ProductShippingAddressDetailByID>(_productShippingDetail.GetProductShippingAddressDetailByID(_shippingPaymentID.Value));
        }
        public DTO.Paged.PagedProductPurchase getProductPurchaseDetailByID(int? _shippingPaymentID, int _skip, int _take)
        {
            return Mapper.Map<PagedProductPurchase>(_productShippingDetail.GetProductPurchaseDetailByID(_shippingPaymentID.Value, _skip, _take));
        }

        public DTO.Paged.PagedProductPurchasesRecord getProductPurchaseDetail(int _skip, int _take, int OrganizationID)
        {
            return Mapper.Map<PagedProductPurchasesRecord>(_productShippingDetail.GetProductPurchaseDetail(_skip, _take, OrganizationID));
        }
        #endregion

    }
}  
