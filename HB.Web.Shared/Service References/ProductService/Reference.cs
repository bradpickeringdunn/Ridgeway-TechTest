﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HB.Web.Shared.ProductService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductService.IProductServiceContract")]
    public interface IProductServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductServiceContract/LoadProductCategories", ReplyAction="http://tempuri.org/IProductServiceContract/LoadProductCategoriesResponse")]
        HB.Services.Models.Products.Results.LoadProductCategoriesResult LoadProductCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductServiceContract/LoadProductCategories", ReplyAction="http://tempuri.org/IProductServiceContract/LoadProductCategoriesResponse")]
        System.Threading.Tasks.Task<HB.Services.Models.Products.Results.LoadProductCategoriesResult> LoadProductCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductServiceContract/LoadProductsBy", ReplyAction="http://tempuri.org/IProductServiceContract/LoadProductsByResponse")]
        HB.Services.Models.Products.Results.LoadProductsResult LoadProductsBy(HB.Services.Models.Products.Requests.LoadProductsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductServiceContract/LoadProductsBy", ReplyAction="http://tempuri.org/IProductServiceContract/LoadProductsByResponse")]
        System.Threading.Tasks.Task<HB.Services.Models.Products.Results.LoadProductsResult> LoadProductsByAsync(HB.Services.Models.Products.Requests.LoadProductsRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceContractChannel : HB.Web.Shared.ProductService.IProductServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceContractClient : System.ServiceModel.ClientBase<HB.Web.Shared.ProductService.IProductServiceContract>, HB.Web.Shared.ProductService.IProductServiceContract {
        
        public ProductServiceContractClient() {
        }
        
        public ProductServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HB.Services.Models.Products.Results.LoadProductCategoriesResult LoadProductCategories() {
            return base.Channel.LoadProductCategories();
        }
        
        public System.Threading.Tasks.Task<HB.Services.Models.Products.Results.LoadProductCategoriesResult> LoadProductCategoriesAsync() {
            return base.Channel.LoadProductCategoriesAsync();
        }
        
        public HB.Services.Models.Products.Results.LoadProductsResult LoadProductsBy(HB.Services.Models.Products.Requests.LoadProductsRequest request) {
            return base.Channel.LoadProductsBy(request);
        }
        
        public System.Threading.Tasks.Task<HB.Services.Models.Products.Results.LoadProductsResult> LoadProductsByAsync(HB.Services.Models.Products.Requests.LoadProductsRequest request) {
            return base.Channel.LoadProductsByAsync(request);
        }
    }
}
