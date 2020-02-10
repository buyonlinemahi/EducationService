using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HCRGUniversityService.DTO;
using System.ServiceModel;

namespace HCRGUniversityService.Contracts
{
    [ServiceContract]
    public interface IShoppingEducationService
    {
        [OperationContract]
        int AddEducationToShoppingCart(EducationShoppingTemp educationShoppingTemp);
        [OperationContract]
        int UpdateEducationToShoppingCart(EducationShoppingTemp educationShoppingTemp);
        [OperationContract]
        int DeleteEducationFromShoppingCart(int educationShoppingTempID);
        [OperationContract]
        IEnumerable<EducationShoppingCart> GetEducationShoppingCartByUserID(int userID);
        [OperationContract]
        IEnumerable<EducationShoppingCart> GetShoppingDetailsByShippingPaymentID(int shippingPaymentID);
        [OperationContract]
        bool checkEducationinShoppingCart(int userID, int mainID, string type);
        [OperationContract]
        bool checkCoursePurchaseValidationByUserID(int userID, int educationID);
        [OperationContract]
        void ResetShippingOrderQuentityStock(int userID);
        //Product
        [OperationContract]
        int AddProductShoppingCart(ProductShoppingTemp productShoppingTemp);
        [OperationContract]
        int UpdateProductShoppingCart(ProductShoppingTemp productShoppingTemp);
        [OperationContract]
        int DeleteProductShoppingCart(int productShoppingTempID);
        [OperationContract]
        void DeleteProductShoppingCartByUserID(int userID);
        [OperationContract]
        int CheckAnyProductsIsOutOfStock(int userID);
        [OperationContract]
        string GetShoppingCartCoursesByUserID(int userID);
        
        [OperationContract]
        DTO.EducationShoppingTemp GetEducationShoppingTempByID(int _id);
        //Order Shopping

        [OperationContract]
        void AddEducationShoppingOrder(IEnumerable<DTO.EducationShoppingCart> shoppingcart);
        [OperationContract]
        void AddEducationShoppingOrderAllAccessPass(DTO.EducationShoppingCart shoppingcart);

        [OperationContract]
        int UpdateEducationShoppingOrder(EducationShopping educationShopping);
        [OperationContract]
        int UpdateProductShoppingOrder(ProductShopping productShopping);
        [OperationContract]
        DTO.ProductShoppingTemp GetProductShoppingTempByID(int id);
    }
}