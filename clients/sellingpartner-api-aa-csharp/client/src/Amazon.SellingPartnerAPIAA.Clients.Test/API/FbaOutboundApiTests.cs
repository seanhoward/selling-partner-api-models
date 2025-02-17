/* 
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: 2020-07-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;

namespace Amazon.SellingPartnerAPIAA.Clients.FulfillmentOutbound.Test
{
    /// <summary>
    ///  Class for testing FbaOutboundApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FbaOutboundApiTests
    {
        private FbaOutboundApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new FbaOutboundApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FbaOutboundApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FbaOutboundApi
            //Assert.IsInstanceOfType(typeof(FbaOutboundApi), instance, "instance is a FbaOutboundApi");
        }

        
        /// <summary>
        /// Test CancelFulfillmentOrder
        /// </summary>
        [Test]
        public void CancelFulfillmentOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sellerFulfillmentOrderId = null;
            //var response = instance.CancelFulfillmentOrder(sellerFulfillmentOrderId);
            //Assert.IsInstanceOf<CancelFulfillmentOrderResponse> (response, "response is CancelFulfillmentOrderResponse");
        }
        
        /// <summary>
        /// Test CreateFulfillmentOrder
        /// </summary>
        [Test]
        public void CreateFulfillmentOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFulfillmentOrderRequest body = null;
            //var response = instance.CreateFulfillmentOrder(body);
            //Assert.IsInstanceOf<CreateFulfillmentOrderResponse> (response, "response is CreateFulfillmentOrderResponse");
        }
        
        /// <summary>
        /// Test CreateFulfillmentReturn
        /// </summary>
        [Test]
        public void CreateFulfillmentReturnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFulfillmentReturnRequest body = null;
            //string sellerFulfillmentOrderId = null;
            //var response = instance.CreateFulfillmentReturn(body, sellerFulfillmentOrderId);
            //Assert.IsInstanceOf<CreateFulfillmentReturnResponse> (response, "response is CreateFulfillmentReturnResponse");
        }
        
        /// <summary>
        /// Test DeliveryOffers
        /// </summary>
        [Test]
        public void DeliveryOffersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDeliveryOffersRequest body = null;
            //var response = instance.DeliveryOffers(body);
            //Assert.IsInstanceOf<GetDeliveryOffersResponse> (response, "response is GetDeliveryOffersResponse");
        }
        
        /// <summary>
        /// Test GetFeatureInventory
        /// </summary>
        [Test]
        public void GetFeatureInventoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string marketplaceId = null;
            //string featureName = null;
            //string nextToken = null;
            //DateTime? queryStartDate = null;
            //var response = instance.GetFeatureInventory(marketplaceId, featureName, nextToken, queryStartDate);
            //Assert.IsInstanceOf<GetFeatureInventoryResponse> (response, "response is GetFeatureInventoryResponse");
        }
        
        /// <summary>
        /// Test GetFeatureSKU
        /// </summary>
        [Test]
        public void GetFeatureSKUTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string marketplaceId = null;
            //string featureName = null;
            //string sellerSku = null;
            //var response = instance.GetFeatureSKU(marketplaceId, featureName, sellerSku);
            //Assert.IsInstanceOf<GetFeatureSkuResponse> (response, "response is GetFeatureSkuResponse");
        }
        
        /// <summary>
        /// Test GetFeatures
        /// </summary>
        [Test]
        public void GetFeaturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string marketplaceId = null;
            //var response = instance.GetFeatures(marketplaceId);
            //Assert.IsInstanceOf<GetFeaturesResponse> (response, "response is GetFeaturesResponse");
        }
        
        /// <summary>
        /// Test GetFulfillmentOrder
        /// </summary>
        [Test]
        public void GetFulfillmentOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sellerFulfillmentOrderId = null;
            //var response = instance.GetFulfillmentOrder(sellerFulfillmentOrderId);
            //Assert.IsInstanceOf<GetFulfillmentOrderResponse> (response, "response is GetFulfillmentOrderResponse");
        }
        
        /// <summary>
        /// Test GetFulfillmentPreview
        /// </summary>
        [Test]
        public void GetFulfillmentPreviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetFulfillmentPreviewRequest body = null;
            //var response = instance.GetFulfillmentPreview(body);
            //Assert.IsInstanceOf<GetFulfillmentPreviewResponse> (response, "response is GetFulfillmentPreviewResponse");
        }
        
        /// <summary>
        /// Test GetPackageTrackingDetails
        /// </summary>
        [Test]
        public void GetPackageTrackingDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? packageNumber = null;
            //var response = instance.GetPackageTrackingDetails(packageNumber);
            //Assert.IsInstanceOf<GetPackageTrackingDetailsResponse> (response, "response is GetPackageTrackingDetailsResponse");
        }
        
        /// <summary>
        /// Test ListAllFulfillmentOrders
        /// </summary>
        [Test]
        public void ListAllFulfillmentOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? queryStartDate = null;
            //string nextToken = null;
            //var response = instance.ListAllFulfillmentOrders(queryStartDate, nextToken);
            //Assert.IsInstanceOf<ListAllFulfillmentOrdersResponse> (response, "response is ListAllFulfillmentOrdersResponse");
        }
        
        /// <summary>
        /// Test ListReturnReasonCodes
        /// </summary>
        [Test]
        public void ListReturnReasonCodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sellerSku = null;
            //string marketplaceId = null;
            //string sellerFulfillmentOrderId = null;
            //string language = null;
            //var response = instance.ListReturnReasonCodes(sellerSku, marketplaceId, sellerFulfillmentOrderId, language);
            //Assert.IsInstanceOf<ListReturnReasonCodesResponse> (response, "response is ListReturnReasonCodesResponse");
        }
        
        /// <summary>
        /// Test SubmitFulfillmentOrderStatusUpdate
        /// </summary>
        [Test]
        public void SubmitFulfillmentOrderStatusUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sellerFulfillmentOrderId = null;
            //SubmitFulfillmentOrderStatusUpdateRequest body = null;
            //var response = instance.SubmitFulfillmentOrderStatusUpdate(sellerFulfillmentOrderId, body);
            //Assert.IsInstanceOf<SubmitFulfillmentOrderStatusUpdateResponse> (response, "response is SubmitFulfillmentOrderStatusUpdateResponse");
        }
        
        /// <summary>
        /// Test UpdateFulfillmentOrder
        /// </summary>
        [Test]
        public void UpdateFulfillmentOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateFulfillmentOrderRequest body = null;
            //string sellerFulfillmentOrderId = null;
            //var response = instance.UpdateFulfillmentOrder(body, sellerFulfillmentOrderId);
            //Assert.IsInstanceOf<UpdateFulfillmentOrderResponse> (response, "response is UpdateFulfillmentOrderResponse");
        }
        
    }

}