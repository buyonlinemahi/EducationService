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
    public class ShoppingEducationService : IShoppingEducationService
    {
        private readonly IEducationShoppingTemp _educationShoppingTemp;
        private readonly IEducationShopping _educationShopping;

        public ShoppingEducationService(IEducationShoppingTemp educationShoppingTemp,IEducationShopping educationShopping)
        {
            _educationShoppingTemp = educationShoppingTemp;
            _educationShopping = educationShopping;
        }

        public int AddEducationToShoppingCart(EducationShoppingTemp educationShoppingTemp)
        {
            return _educationShoppingTemp.AddEducationShoppingCart(Mapper.Map<EducationShoppingTemp, HCRGUniversity.Core.Data.Model.EducationShoppingTemp>(educationShoppingTemp));
        }

        public int DeleteEducationFromShoppingCart(int educationShoppingTempID)
        {
            return _educationShoppingTemp.DeleteEducationShoppingCart(educationShoppingTempID);
        }

        public IEnumerable<EducationShoppingCart> GetShoppingDetailsByShippingPaymentID(int shippingPaymentID)
        {
            return Mapper.Map<IEnumerable<EducationShoppingCart>>(_educationShoppingTemp.GetShoppingDetailsByShippingPaymentID(shippingPaymentID));
        }

        public IEnumerable<EducationShoppingCart> GetEducationShoppingCartByUserID(int userID)
        {
            return Mapper.Map<IEnumerable<EducationShoppingCart>>(_educationShoppingTemp.GetEducationShoppingCartByUserID(userID));
        }

        public bool checkEducationinShoppingCart(int userID, int mainID, string type)
        {
            return _educationShoppingTemp.checkEducationinShoppingCart(userID,mainID,type) ;
        }

        public bool checkCoursePurchaseValidationByUserID(int userID, int educationID)
        {
            return _educationShoppingTemp.checkCoursePurchaseValidationByUserID(userID, educationID);
        }

        public DTO.EducationShoppingTemp GetEducationShoppingTempByID(int _id)
        {
            return Mapper.Map<EducationShoppingTemp>(_educationShoppingTemp.GetEducationShoppingTempByID(_id));
        }

        public int UpdateEducationToShoppingCart(DTO.EducationShoppingTemp educationShoppingTemp)
        {
            return _educationShoppingTemp.UpdateEducationShoppingCart(Mapper.Map<DTO.EducationShoppingTemp, HCRGUniversity.Core.Data.Model.EducationShoppingTemp>(educationShoppingTemp));
        }

        //ShoppingOrder

        public void AddEducationShoppingOrder(IEnumerable<DTO.EducationShoppingCart> shoppingcart)
        {
          _educationShopping.AddEducationShoppingOrder(Mapper.Map<IEnumerable<DTO.EducationShoppingCart>, IEnumerable<HCRGUniversity.Core.Data.Model.EducationShoppingCart>>(shoppingcart));
        }

        public void AddEducationShoppingOrderAllAccessPass(DTO.EducationShoppingCart shoppingcart)
        {
            _educationShopping.AddEducationShoppingOrderAllAccessPass(Mapper.Map<DTO.EducationShoppingCart, HCRGUniversity.Core.Data.Model.EducationShoppingCart>(shoppingcart));
        }
        

        public int UpdateEducationShoppingOrder(DTO.EducationShopping educationShopping)
        {
            return _educationShopping.UpdateEducationShoppingOrder(Mapper.Map<DTO.EducationShopping, HCRGUniversity.Core.Data.Model.EducationShopping>(educationShopping));
        }

        public int UpdateProductShoppingOrder(DTO.ProductShopping productShopping)
        {
            return _educationShopping.UpdateProductShoppingOrder(Mapper.Map<DTO.ProductShopping, HCRGUniversity.Core.Data.Model.ProductShopping>(productShopping));
        }

        public int CheckAnyProductsIsOutOfStock(int userID)
        {
            return _educationShoppingTemp.CheckAnyProductsIsOutOfStock(userID);
        }
        public string GetShoppingCartCoursesByUserID(int userID)
        {
            return _educationShoppingTemp.GetShoppingCartCoursesByUserID(userID);
        }


//        Product
        public int AddProductShoppingCart(ProductShoppingTemp productShoppingTemp)
        {
            return _educationShoppingTemp.AddProductShoppingCart(Mapper.Map<ProductShoppingTemp, HCRGUniversity.Core.Data.Model.ProductShoppingTemp>(productShoppingTemp));
        }

        public int UpdateProductShoppingCart(ProductShoppingTemp productShoppingTemp)
        {
            return _educationShoppingTemp.UpdateProductShoppingCart(Mapper.Map<ProductShoppingTemp, HCRGUniversity.Core.Data.Model.ProductShoppingTemp>(productShoppingTemp));
        }

        public int DeleteProductShoppingCart(int productShoppingTempID)
        {
            return _educationShoppingTemp.DeleteProductShoppingCart(productShoppingTempID);
        }

        public void DeleteProductShoppingCartByUserID(int userID)
        {
             _educationShoppingTemp.DeleteProductShoppingCartByUserID(userID);
        
        }

        public DTO.ProductShoppingTemp GetProductShoppingTempByID(int id)
        {
            return Mapper.Map<DTO.ProductShoppingTemp>(_educationShoppingTemp.GetProductShoppingTempByID(id));
        }

        public void ResetShippingOrderQuentityStock(int userID)
        {
            _educationShoppingTemp.ResetShippingOrderQuentityStock(userID);
        }


      
    }
}